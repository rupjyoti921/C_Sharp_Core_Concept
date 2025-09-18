var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


//app.run(async (context) =>
//{
//    await context.response.writeasync("welcome to asp.net core");
//}
//);
//**app.run() does not allow to run multiple middleware or the next middleware

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("welcome to asp.net core\n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync(" Rupjyoti");
}
);

app.Run();
