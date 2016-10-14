using System.Data.Entity;

namespace FilmDatabas.DataAccessKayer
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext():base("MovieDatabase")
        {

        }
        public DbSet<Models.Movie> Movies { get; set; }
    }
}