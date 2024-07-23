namespace AluraFilmesAPI.Dtos;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public ReadEnderecoDto ReadEnderecoDto { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
}
