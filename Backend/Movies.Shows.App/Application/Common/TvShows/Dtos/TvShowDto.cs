using Api.Dto;
using Domain.Entities;
using Domain.Enum;

namespace Application.Common.TvShows.Dtos
{
    public class TvShowDto
    {
        public class TvShowIndex
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public Genre Genres { get; set; }
            public string Description { get; set; }
            public ICollection<ActorDto.ActorIndex> Actors { get; set; }
            public ICollection<TvShowSeason> TvShowSeasons { get; set; }
        }
        public class TvShowDetail : TvShowIndex
        {

        }

        public class TvShowCreate
        {

        }

        public class TvShowDelete
        {

        }
    }
}
