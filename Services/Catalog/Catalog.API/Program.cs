var builder = WebApplication.CreateBuilder(args);

//===== ADD SERVICES TO THE CONTAINER =====\\

var app = builder.Build();

//===== CONFIGURE THE HTTP REQUEST PIPELINE =====\\

app.Run();
