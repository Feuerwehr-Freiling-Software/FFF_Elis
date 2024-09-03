using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;

namespace FFF_Elis.Components.Pages;

public partial class VisuSettings : ComponentBase
{
    private List<VisualItem> VisualItems { get; set; } = [];
    private int SelectedIndex { get; set; } = 0;

    #region Präsentation

    private void AddPresentationItem()
    {
        VisualItems.Add(new VisualItem { Type = VisualItemType.Webpage });
    }
    
    private void RemovePresentationItem(VisualItem item)
    {
        VisualItems.Remove(item);
    }

    #endregion
}