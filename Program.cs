using Microsoft.IdentityModel.Tokens;
using MinimalApi.Domain.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá mundo!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "teste@test.com.br" && loginDTO.Password == "1234")
            return Results.Ok("Login realizdo com sucesso");
    return Results.Unauthorized();
}
);

app.Run();
