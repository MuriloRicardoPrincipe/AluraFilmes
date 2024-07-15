using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O campo de duração é obrigatório")]
    [Range(1, 360, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
    public int Duracao { get; set; }

    public string Genero { get; set; }
}
