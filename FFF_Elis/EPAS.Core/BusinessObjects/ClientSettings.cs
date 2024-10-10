namespace FFF_Elis.Components.BusinessObjects;

public class ClientSettings
{
    public bool ShowEinsaetze { get; set; } = false;
    public bool ShowCalendar { get; set; } = false;
    public string ApiKey { get; set; } = string.Empty;
    public string FirebrigadeName { get; set; } = string.Empty;
    public List<VisualItem> VisualItems { get; set; } = 
    [
        new VisualItem() {Description = "Example Weatherpage", Duration = 20, Type = VisualItemType.Webpage, Url = "https://meteoblue.com/de/meteotv/af27d5", Name = "Weatherpage"},
        new VisualItem() { Name = "Homepage", Type = VisualItemType.Webpage, Url = "https://feuerwehr-freiling.at", Duration = 10, Description = "Homepage der FFF" },
    ];
}