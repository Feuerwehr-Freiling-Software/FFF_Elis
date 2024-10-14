using Blazored.LocalStorage;
using FFF_Elis.Components;
using FFF_Elis.Components.Services;
using MudBlazor.Services;
using Nominatim.API.Address;
using Nominatim.API.Geocoders;
using Nominatim.API.Interfaces;
using Nominatim.API.Web;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FElisContextConnection") ?? throw new InvalidOperationException("Connection string 'FElisContextConnection' not found.");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddHttpClient();

builder.Services.AddScoped<INominatimWebInterface, NominatimWebInterface>();
builder.Services.AddScoped<IAddressSearcher, AddressSearcher>();
builder.Services.AddScoped<IForwardGeocoder, ForwardGeocoder>();
builder.Services.AddScoped<IReverseGeocoder, ReverseGeocoder>();

builder.Services.AddSingleton<GoogleService>();
builder.Services.AddScoped<GeocodingService>();

builder.Services.AddHttpClient();


builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();