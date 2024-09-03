using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;

namespace FFF_Elis.Components.Components;

public partial class EditPresentation : ComponentBase
{
    public List<VisualItem> VisualItems { get; set; } = new List<VisualItem>();

    private async Task AddNewItem()
    {
        VisualItems.Add(new VisualItem() { Name = "Test", Description = "test", Type = VisualItemType.Webpage, Duration = 10, Url = "benis" });
        await InvokeAsync(StateHasChanged);
    }
}