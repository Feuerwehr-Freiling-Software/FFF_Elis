using ELISWCFService;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;

namespace FFF_Elis.Components.Components;

public partial class RueckmeldeListe : ComponentBase
{
    [Parameter] public List<Einsatzrueckmeldung> Rueckmeldungen { get; set; }

    protected override void OnParametersSet()
    {
        Rueckmeldungen = Rueckmeldungen.OrderBy(r => r.Status).ToList();
    }
}