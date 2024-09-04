using Blazored.LocalStorage;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using WebLibrary.BusinessObjects;
using WebLibrary.Components.Dialogs;
using WebLibrary.Enums;

namespace FFF_Elis.Components.Components;

public partial class EditPresentation : ComponentBase
{
    [Inject] public ILocalStorageService LocalStorage { get; set; }
    
    [Inject] private IDialogService DialogService { get; set; } = null!;
    
    private ClientSettings _clientSettings = new ClientSettings();
    private bool _moveMode = false;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await ReloadItems();
        }
    }

    private bool MoveMode
    {
        get => _moveMode;
        set {
            if(value == false) ReloadItems();
            _moveMode = value;
        }
    }

    private async Task ReloadItems()
    {
        var res = await LocalStorage.GetItemAsync<List<swapyPresentationItem>>("swapyPresentationItems");
        _clientSettings = await GetClientSettings();
        
        // reorder items
        foreach (var item in res)
        {
            var visualItem = _clientSettings.VisualItems.FirstOrDefault(x => x.Name == item.item);
            if (visualItem != null)
            {
                _clientSettings.VisualItems.Remove(visualItem);
                _clientSettings.VisualItems.Insert(int.Parse(item.slot) - 1, visualItem);
            }
        }
        
        await InvokeAsync(StateHasChanged);
    }
    
    private async Task AddNewItem()
    {
        List<CustomInputItem> items = new List<CustomInputItem>()
        {
            new CustomInputItem(){Key = "Name", Value = string.Empty, Placeholder = "Name", Label = "Name der Ansicht", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Url", Value = string.Empty, Placeholder = "Url", Label = "Url oder Pfad", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Beschreibung", Value = string.Empty, Placeholder = "Beschreibung", Label = "Beschreibung der Ansicht", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Dauer", Value = 0, Placeholder = "Dauer", Label = "Dauer der Ansicht", InputType = CustomInputType.Number, Min = 5, Step = 1},
            new CustomInputItem(){Key = "Typ", InputType = CustomInputType.Dropdown, Label = "Typ der Ansicht", Value = new List<string>(){ "Foto", "Video", "Webseite", "Text", "Datei" }}
        };
        
        var parameters = new DialogParameters()
        {
            { "Message", "Neue Präsentationsansicht erstellen" },
            { "InputFields", items }
        };

        var _settings = new DialogOptions()
        {
            FullWidth = true,
            MaxWidth = MaxWidth.Large
        };
        
        var dialog = await DialogService.ShowAsync<CustomInputDialog>("", parameters, _settings);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            var data = (List<CustomInputItem>)result.Data;
            
            var name = data?.FirstOrDefault(x => x.Key == "Name")?.ReturnAsString ?? string.Empty;
            var url = data?.FirstOrDefault(x => x.Key == "Url")?.ReturnAsString ?? string.Empty;
            var description = data?.FirstOrDefault(x => x.Key == "Beschreibung")?.ReturnAsString ?? string.Empty;
            var duration = Convert.ToInt32(data?.FirstOrDefault(x => x.Key == "Dauer")?.AsNumber);
            var dialogType = (string?)data?.FirstOrDefault(x => x.Key == "Typ")?.ReturnValue ?? string.Empty;

            VisualItemType visualType = VisualItemType.Text;
            
            switch (dialogType)
            {
                case "Foto":
                    visualType = VisualItemType.Image;
                    break;
                case "Video":
                    visualType = VisualItemType.Video;
                    break;
                case "Webseite":
                    visualType = VisualItemType.Webpage;
                    break;
                case "Text":
                    visualType = VisualItemType.Text;
                    break;
                case "Datei":
                    visualType = VisualItemType.File;
                    break;
                default:
                    visualType = VisualItemType.Text;
                    break;
            }
            
            var visualItem = new VisualItem()
            {
                Name = name,
                Url = url,
                Description = description,
                Duration = duration,
                Type = visualType
            };
            
            _clientSettings.VisualItems.Add(visualItem);
            await SaveSettings();
            await InvokeAsync(StateHasChanged);
        }
        
        
        await SaveSettings();
        await InvokeAsync(StateHasChanged);
    }

    private async Task RemoveItem(VisualItem item)
    {
        _clientSettings.VisualItems.Remove(item);
        await SaveSettings();
        await InvokeAsync(StateHasChanged);
    }

    private async Task EditItem(VisualItem item)
    {
        string type = string.Empty;
        switch (item.Type)
        {
            case VisualItemType.Image:
                type = "Foto";
                break;
            case VisualItemType.Video:
                type = "Video";
                break;
            case VisualItemType.Webpage:
                type = "Webseite";
                break;
            case VisualItemType.Text:
                type = "Text";
                break;
            case VisualItemType.File:
                type = "Datei";
                break;
            default:
                type = "Text";
                break;
        };
        
        List<CustomInputItem> items = new List<CustomInputItem>()
        {
            new CustomInputItem(){Key = "Name", Value = item.Name, ReturnAsString = item.Name,Placeholder = "Name", Label = "Name der Ansicht", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Url", ReturnAsString = item.Url, Placeholder = "Url", Label = "Url oder Pfad", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Beschreibung", ReturnAsString = item.Description, Placeholder = "Beschreibung", Label = "Beschreibung der Ansicht", InputType = CustomInputType.TextField},
            new CustomInputItem(){Key = "Dauer", Value = item.Duration, Placeholder = "Dauer", Label = "Dauer der Ansicht", InputType = CustomInputType.Number, Min = 5, Step = 1},
            new CustomInputItem(){Key = "Typ", InputType = CustomInputType.Dropdown, Label = "Typ der Ansicht", Value = new List<string>(){ "Foto", "Video", "Webseite", "Text", "Datei" }, ReturnValue = type}
        };
        
        var parameters = new DialogParameters()
        {
            { "Message", "Neue Präsentationsansicht erstellen" },
            { "InputFields", items }
        };

        var _settings = new DialogOptions()
        {
            FullWidth = true,
            MaxWidth = MaxWidth.Large
        };
        
        var dialog = await DialogService.ShowAsync<CustomInputDialog>("", parameters, _settings);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            var data = (List<CustomInputItem>)result.Data;
            
            var name = data?.FirstOrDefault(x => x.Key == "Name")?.ReturnAsString ?? string.Empty;
            var url = data?.FirstOrDefault(x => x.Key == "Url")?.ReturnAsString ?? string.Empty;
            var description = data?.FirstOrDefault(x => x.Key == "Beschreibung")?.ReturnAsString ?? string.Empty;
            var duration = Convert.ToInt32(data?.FirstOrDefault(x => x.Key == "Dauer")?.AsNumber);
            var dialogType = (string?)data?.FirstOrDefault(x => x.Key == "Typ")?.ReturnValue ?? string.Empty;

            VisualItemType visualType = VisualItemType.Text;
            
            switch (dialogType)
            {
                case "Foto":
                    visualType = VisualItemType.Image;
                    break;
                case "Video":
                    visualType = VisualItemType.Video;
                    break;
                case "Webseite":
                    visualType = VisualItemType.Webpage;
                    break;
                case "Text":
                    visualType = VisualItemType.Text;
                    break;
                case "Datei":
                    visualType = VisualItemType.File;
                    break;
                default:
                    visualType = VisualItemType.Text;
                    break;
            }
            
            var visualItem = new VisualItem()
            {
                Name = name,
                Url = url,
                Description = description,
                Duration = duration,
                Type = visualType
            };
            
            var visualItemToUpdate = _clientSettings.VisualItems.FirstOrDefault(x => x.Name == item.Name);
            
            if(visualItemToUpdate == null) return;
            
            visualItemToUpdate.Name = visualItem.Name;
            visualItemToUpdate.Url = visualItem.Url;
            visualItemToUpdate.Description = visualItem.Description;
            visualItemToUpdate.Duration = visualItem.Duration;
            visualItemToUpdate.Type = visualItem.Type;
            
            await SaveSettings();
            await InvokeAsync(StateHasChanged);
        }
    }

    private async Task<ClientSettings> GetClientSettings()
    {
        var res = await LocalStorage.GetItemAsync<ClientSettings>("ClientSettings");
        if (res == null)
        {
            res = new ClientSettings();
            await SaveSettings();
        }
        
        return res;
    }
    
    private async Task SaveSettings()
    {
        await LocalStorage.SetItemAsync("ClientSettings", _clientSettings);
    }
}