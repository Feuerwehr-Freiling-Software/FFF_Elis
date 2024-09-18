using System.Xml.Serialization;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace FFF_Elis.Components.Components;

public partial class EinsaetzeOOE : ComponentBase
{
    [Inject] public IJSRuntime JS { get; set; }
    [Inject] public HttpClient HttpClient { get; set; }

    public Webext2 Einsatz { get; set; } = new Webext2();

    protected override async Task OnInitializedAsync()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Webext2));
        using (StringReader reader = new StringReader(await HttpClient.GetStringAsync("https://cf-einsaetze.ooelfv.at/webext2/rss/webext2_laufend.xml")))
        {
            Einsatz = (Webext2)serializer.Deserialize(reader);
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await InvokeAsync(ShowMap);
        }
    }
    
    public async Task ShowMap()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Webext2));
        using (StringReader reader = new StringReader(await HttpClient.GetStringAsync("https://cf-einsaetze.ooelfv.at/webext2/rss/webext2_laufend.xml")))
        {
            Einsatz = (Webext2)serializer.Deserialize(reader);
        }
        
        List<EinsatzMapEntry> mapEntries = new();
        foreach (var item in Einsatz.Einsaetze.Einsatz.Where(x => x.Einsatzart != "SELBST"))
        {
            mapEntries.Add(new EinsatzMapEntry
            {
                EinsatzTyp = item?.Einsatzart ?? "SONSTIGE",
                Alarmstufe = item?.Alarmstufe ?? 0,
                lat = (float)item.Lat,
                lon = (float)item.Lng
            });
        }
        
        await JS.InvokeVoidAsync("RegisterMap", mapEntries);
    }
}