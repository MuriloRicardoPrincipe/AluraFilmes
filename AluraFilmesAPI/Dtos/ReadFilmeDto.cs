using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos;

public class ReadFilmeDto
{

    public string Titulo { get; set; }

    public int Duracao { get; set; }

    public string Genero { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}
