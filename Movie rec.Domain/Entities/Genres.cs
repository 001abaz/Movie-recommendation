
namespace Movie_rec.Domain.Entities
{
    public class Genres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovieGenres> MovieGenres { get; set; }
    }
}
