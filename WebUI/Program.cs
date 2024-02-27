using ApiAccess.Abstract;
using ApiAccess.Base;
using Shared.Helpers.Abstract;
using Shared.Helpers.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region DependencyInjection
builder.Services.AddScoped<IRequestService, RequestManager>();
builder.Services.AddScoped<IHaberApiRequest, HaberApiRequest>();
builder.Services.AddScoped<IYazarApiRequest, YazarApiRequest>();
builder.Services.AddScoped<IKategoriApiRequest, KategoriApiRequest>();
builder.Services.AddScoped<IYorumApiRequest, YorumApiRequest>();
builder.Services.AddScoped<ICommonApiRequest, CommonApiRequest>();
builder.Services.AddScoped<ISlaytApiRequest, SlaytApiRequest>();
#endregion

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

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
