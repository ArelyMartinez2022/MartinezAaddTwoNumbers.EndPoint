/*
ARELY MARTINEZ 
OCT 25, 2022 11:23AM
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT TWO NUMBERS AND IT REPSOND 
WITH THE SUM. THEY WOULD 
INPUT THROUGH POSTMAN LIKE 
OUTPUT: https://localhost:7119/input/ADDING/2/5
OUTPUT: 2 + 5 = 7

PEER REVIEW: NAME -- REVIEW Samuel Laguna
I ran the code it works good. The inputs 
work just fine. There where no erros, this 
code is all good.
*/
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
