using Domain.Enum;

namespace Domain.Entities
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genres { get; set; }
        public string Description { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<TvShowSeason> TvShowSeasons { get; set; }


        public TvShow()
        {
            TvShowSeasons = new List<TvShowSeason>();
        }
    }
}
