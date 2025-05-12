using Museum.Frontend.Components;
using Museum.Frontend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

var baseUrl = builder.Configuration["BaseUrl"];

builder.Services.AddTransient(typeof(MuseumClient), (provider) =>
{
    return new MuseumClient(baseUrl, provider.GetRequiredService<HttpClient>());
});

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

app.MapRazorComponents<App>();
    //.AddInteractiveServerRenderMode();

app.Run();
