using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using WebLibrary.BusinessObjects;
using WebLibrary.Components.Dialogs;
using WebLibrary.Enums;

namespace FFF_Elis.Components.Pages;

public partial class VisuSettings : ComponentBase
{
    [Inject] private IDialogService DialogService { get; set; } = null!;
    
    private List<VisualItem> VisualItems { get; set; } = [];
    private int SelectedIndex { get; set; } = 0;
}