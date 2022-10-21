using Domain.Entities;
using Domain.Enum;

namespace Application.Common.Movies.Dtos
{
    public class MovieDto
    {
        public class MovieIndex
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public Genre Genres { get; set; }
            public string Description { get; set; }
            public DateTime ReleaseDate { get; set; }
            public ICollection<Actor> Actors { get; set; }

        }
        public class Detail : MovieIndex
        {

        }

        public class Create
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public Genre Genres { get; set; }
            public string Description { get; set; }
            public DateTime ReleaseDate { get; set; }

        }

        public class Delete
        {
            public int Id { get; set; }

        }
    }
}
