using EPAS.BusinessLogic.Dtos;
using EPAS.Core.Models;
using Microsoft.AspNetCore.Components;

namespace EPAS.Components.Components;

public partial class OperationResponseListComponent : ComponentBase
{
    [Parameter] public List<OperationResponseDto> Responses { get; set; }

    protected override void OnParametersSet()
    {
        Responses = Responses.OrderBy(r => r.Response).ToList();
    }
}