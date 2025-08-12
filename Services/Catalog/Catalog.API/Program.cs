var builder = WebApplication.CreateBuilder(args);

//===== ADD SERVICES TO THE CONTAINER =====\\
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(options =>
{
    options.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();

//===== CONFIGURE THE HTTP REQUEST PIPELINE =====\\
app.MapCarter();

app.Run();
