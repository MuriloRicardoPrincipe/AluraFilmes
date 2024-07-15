using AluraFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraFilmesAPI.Data;

public class FilmesContext : DbContext
{
    public FilmesContext( DbContextOptions<FilmesContext> opts) : base(opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
}
