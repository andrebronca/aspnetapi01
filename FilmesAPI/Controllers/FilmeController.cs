using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
	private static List<Filme> filmes = new();

	[HttpPost]
	public void AdicionaFilme([FromBody] Filme filme)
	{
		filmes.Add(filme);
		ExibeFilmes();
	}

	private void ExibeFilmes()
	{
		foreach (var item in filmes)
		{
			Console.WriteLine(item.Titulo + ", " + item.Genero + ", " + item.Duracao);
		}
	}
}
