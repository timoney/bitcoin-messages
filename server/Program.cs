using server.Database;
using server.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/latest", () => {
  //Database database = new Database();
  //List<BlockchainMessage> messages = database.select();
  //var result = JsonConvert.SerializeObject(messages);
  //return result;
  return $"sup {target}";
}).WithName("GetLatest");

app.Run(url);