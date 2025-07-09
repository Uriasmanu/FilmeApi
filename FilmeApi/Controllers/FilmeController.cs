using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filmes.Add(filme);

        Console.WriteLine($"Filme adicionado: {filme.Titulo}, Duração: {filme.Duracao}");

        return CreatedAtAction(nameof(AdicionaFilme), new { id = filmes.Count }, filme);
    }
}
