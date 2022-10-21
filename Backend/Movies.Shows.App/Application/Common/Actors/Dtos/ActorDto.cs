using Application.Common.Movies.Dtos;
using Application.Common.TvShows.Dtos;

namespace Api.Dto
{
    public class ActorDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }


        }
        public class Detail : Index
        {
            public ICollection<MovieDto.Index> Movies { get; set; }
            public ICollection<TvShowDto.Index> TvShows { get; set; }
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
