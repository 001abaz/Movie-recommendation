namespace Movie_rec.Domain.Entities
{
    public class MovieGenres
    {
        public int Id { get; set; }
        public int MoviesId { get; set; }
        public int GenresId { get; set; }
        public Movies Movies { get; set; }
        public Genres Genres { get; set; }
    }
}
