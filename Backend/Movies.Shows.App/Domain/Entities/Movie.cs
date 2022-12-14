using Domain.Enum;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genres { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public ICollection<Actor> Actors { get; set; }

    }
}
