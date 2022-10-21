using Domain.Entities;
using Domain.Enum;

namespace Application.Common.TvShows.Dtos
{
    public class TvShowDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public Genre Genres { get; set; }
            public string Description { get; set; }
            public DateTime ReleaseDate { get; set; }
            public ICollection<Actor> Actors { get; set; }
            public ICollection<TvShowSeason> TvShowSeasons { get; set; }
        }
        public class Detail : Index
        {

        }

        public class Create
        {

        }

        public class Delete
        {

        }
    }
}
