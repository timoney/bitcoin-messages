using server.Database;
using server.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/latest", () => {
  //Database database = new Database();
  //List<BlockchainMessage> messages = database.select();
  //var result = JsonConvert.SerializeObject(messages);
  //return result;
  return "sup";
}).WithName("GetLatest");

app.Run();