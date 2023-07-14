var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");*/

app.MapControllerRoute(
	name: "default",
	pattern:"{controller=Home}/{action=Details}/{id?}"
	);

app.Run();
