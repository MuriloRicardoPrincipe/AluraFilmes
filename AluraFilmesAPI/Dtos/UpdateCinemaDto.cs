using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
}
