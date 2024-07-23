using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos
{
    public class UpdateEnderecoDto
    {

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }
    }
}
