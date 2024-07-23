using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos
{
    public class ReadEnderecoDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }
    }
}
