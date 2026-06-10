using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MinimalApi.Domain.DTOs;
using MinimalApi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(
    options => options.UseSqlServer(
                        builder.Configuration.GetConnectionString(
                            "sqlServer"
                            )
                        )
    );
var app = builder.Build();

app.MapGet("/", () => "Olá mundo!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "1213@test.com.br" && loginDTO.Password == "semSenha")
            return Results.Ok("Login realizdo com sucesso");
    return Results.Unauthorized();
}
);

app.Run();
