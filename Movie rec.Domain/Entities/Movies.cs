namespace Movie_rec.Domain.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public int Runtime { get; set; }
        public List<Ratings> Ratings { get; set; }
        public List<Genres> Genres { get; set; }

    }
}
