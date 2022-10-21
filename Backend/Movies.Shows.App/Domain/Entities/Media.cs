using Domain.Enum;

namespace Domain.Entities
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Actor> Actors { get; set; }

        public Media()
        {
            Actors = new List<Actor>();
            Genres = new List<Genre>();
        }
    }
}
