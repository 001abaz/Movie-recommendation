
namespace Movie_rec.Domain.Entities
{
    public class Ratings
    {
        public int Id { get; set; }

        public int Rating { get; set; }
        public int UsersId { get; set; }
        
        public int MoviesId { get; set; }
        public Users Users { get; set; }
        public Movies Movies { get; set; }

    }
}
