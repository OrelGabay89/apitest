var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseExceptionHandler("/Home/Error");
app.UseHsts();


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Get the port from the environment variable or use a default port (e.g., 5000)
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";

app.Run($"http://*:{port}");