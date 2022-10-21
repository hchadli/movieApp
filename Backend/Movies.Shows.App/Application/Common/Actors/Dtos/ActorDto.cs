using Application.Common.Movies.Dtos;
using Application.Common.TvShows.Dtos;

namespace Api.Dto
{
    public class ActorDto
    {
        public class ActorIndex
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }

        }
        public class ActorDetail : ActorIndex
        {
            public ICollection<MovieDto.MovieIndex> Movies { get; set; }
            public ICollection<TvShowDto.TvShowIndex> TvShows { get; set; }
        }

        public class Create
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
        }

        public class Delete
        {
            public int Id { get; set; }
        }
    }
}
