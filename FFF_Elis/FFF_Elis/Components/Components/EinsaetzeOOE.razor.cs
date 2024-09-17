using System.Xml.Serialization;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace FFF_Elis.Components.Components;

public partial class EinsaetzeOOE : ComponentBase
{
    [Inject] public IJSRuntime JS { get; set; }
    [Inject] public HttpClient HttpClient { get; set; }

    public Webext2 Einsatz { get; set; }
    
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
            await InvokeAsync(StartScroll);
        }
    }

    private async void StartScroll()
    {
        await JS.InvokeVoidAsync("startAutoScroll", "einsatzcard-container");
    }
}