using Blazored.LocalStorage;
using EPAS.BusinessLogic.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EPAS.Components;
using EPAS.Components.Account;
using EPAS.Controllers;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using EPAS.Hubs;
using EPAS.Shared.Services;
using FFF_Elis.Components.Services;
using MudBlazor;
using MudBlazor.Services;
using Nominatim.API.Address;
using Nominatim.API.Geocoders;
using Nominatim.API.Interfaces;
using Nominatim.API.Web;
using Serilog;
using Serilog.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();
builder.Services.AddScoped<INominatimWebInterface, NominatimWebInterface>();
builder.Services.AddScoped<IAddressSearcher, AddressSearcher>();
builder.Services.AddScoped<IForwardGeocoder, ForwardGeocoder>();
builder.Services.AddScoped<IReverseGeocoder, ReverseGeocoder>();

builder.Services.AddScoped<IOperationService, OperationService>();

builder.Services.AddScoped<IAPIKeyService, APIKeyService>();
builder.Services.AddSingleton<GoogleService>();
builder.Services.AddScoped<GeocodingService>();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
});
builder.Services.AddMudBlazorDialog();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddSignalR(c => c.EnableDetailedErrors = true);

var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:54341", apiKey: "hcg2fR1GTS92dTgvjw66")
    .MinimumLevel.Information() // Set the minimum log level to Information
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

logger.Information("Starting EPAS API");

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "EPAS", Version = "v1" });
});

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();
// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseEndpoints(x =>
{
    x.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
});


app.MapDefaultControllerRoute();

app.UseStatusCodePagesWithReExecute("/StatusCode/{0}");

app.MapHub<OperationHub>("/operationHub");
try
{
    app.Run();
}
catch (Exception e)
{
    logger.Fatal(e, "Application terminated unexpectedly");
}