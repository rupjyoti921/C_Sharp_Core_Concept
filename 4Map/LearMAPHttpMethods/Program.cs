var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/", () => "Hello World!");   //default for every http method hit this

//app.MapGet("/", () => "Hello World!--Get");
//app.MapPost("/", () => "Hello World! ---Post");
//app.MapPut("/", () => "Hello World!----Put");
//app.MapDelete("/", () => "Hello World!-----Delete");

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>       //MapPost, MapPut, MapDelete
    {
        await context.Response.WriteAsync("This is home page.. ");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found");
});


app.Run();
