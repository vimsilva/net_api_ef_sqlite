using API_EF_SQLite.CashFlow;
using API_EF_SQLite.CashFlow.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICashFlowCore, CashFlowCore>();
builder.Services.AddScoped<ICashFlowContext, CashFlowContext>();
builder.Services.AddDbContext<CashFlowContext>(options => options.UseSqlite("Data Source=cashflow.db"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
