using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos
{
    public class CreateEnderecoDto
    {
        [Required]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }
    }
}
