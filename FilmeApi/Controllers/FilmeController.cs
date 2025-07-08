using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class FilmeController : ControllerBase
{
    private static Lista<Filme> filmes = new Lista<Filme>();

    public void AdicionaFilme(Filme filme)
    {
        filmes.Add(filme);
    }
}
