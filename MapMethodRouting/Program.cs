var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


/*
app.Map("/Home", () => "Hey, Alhumdulilah!!"); // Map with all Get,Post,Put,Delete
app.MapGet("/", () => "Hello World! From GET");
app.MapPost("/", () => "Hello World! From POST");
app.MapPut("/", () => "Hello World! From PUT");
app.MapDelete("/", () => "Hello World! From DELETE");
*/

app.UseRouting();
app.UseEndpoints(endpoints => 
{
	endpoints.MapGet("/Home", async (context) =>
	{
		await context.Response.WriteAsync("This is my HomepAge-GET");
	});
	endpoints.MapPost("/Home", async (context) =>
	{
		await context.Response.WriteAsync("This is my HomepAge-POST");
	});
	endpoints.MapPut("/Home", async (context) =>
	{
		await context.Response.WriteAsync("This is my HomepAge-PT");
	});
	endpoints.MapDelete("/Home", async (context) =>
	{
		await context.Response.WriteAsync("This is my HomepAge-Delete");
	});
});

//If endpoint not works well & shows error
app.Run(async (HttpContext context) =>
{
	await context.Response.WriteAsync("Page Not Found");
});

app.Run();
