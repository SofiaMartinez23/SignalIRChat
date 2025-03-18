using ChatSignalIr;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();  // Add SignalR services

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Chat}/{action=ListaChats}/{id?}")
    .WithStaticAssets();

app.MapHub<ChatHub>("/Chats");  // Map the SignalR Hub

app.Run();
