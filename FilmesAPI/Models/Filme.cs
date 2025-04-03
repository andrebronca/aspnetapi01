namespace FilmesAPI.Models;

public class Filme
{
	public string Titulo { get; set; }
	public string Genero { get; set; }
	public int Duracao { get; set; }

	public override string ToString()
	{
		return @"Título: {Titulo}, Gênero: {Genero}, Duração: {Duracao}";
	}
}
