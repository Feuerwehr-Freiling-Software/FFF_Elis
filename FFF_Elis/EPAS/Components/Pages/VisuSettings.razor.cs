﻿using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace EPAS.Components.Pages;

public partial class VisuSettings : ComponentBase
{
    [Inject] private IDialogService DialogService { get; set; } = null!;

    private List<VisualItem> VisualItems { get; set; } = [];
    private int SelectedIndex { get; set; } = 0;
}