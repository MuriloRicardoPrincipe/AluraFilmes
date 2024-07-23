using System.ComponentModel.DataAnnotations;

namespace AluraFilmesAPI.Dtos
{
    public class ReadSessaoDto
    {

        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
    }
}
