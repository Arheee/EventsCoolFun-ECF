using EventsCoolFun_ECF_.Data;
using Microsoft.EntityFrameworkCore;
using EventsCoolFun_ECF_.Models;
using EventsCoolFun_ECF_.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuration de la connexion à la base de données
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Configuration pour MongoDB
builder.Services.AddSingleton<MongoDbContext>();

// Enregistrement du service EventService
builder.Services.AddScoped<EventService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

//cache en memoire pour la session 
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromSeconds(30); //durée de session
    option.Cookie.HttpOnly = true; // securise le cookie
    option.Cookie.IsEssential = true; // Necessaire pour les cookies de session 
});

// Ajouter HttpContextAccessor
builder.Services.AddHttpContextAccessor();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession(); //active la session 
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
