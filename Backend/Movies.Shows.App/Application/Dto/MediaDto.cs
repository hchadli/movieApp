using Domain.Enum;

namespace Api.Dto
{
    public class MediaDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string Title { get; set; }


        }
        public class Detail : Index
        {
            public Genre Genre { get; set; }
            public string Description { get; set; }
            public DateTime ReleaseDate { get; set; }
            public ICollection<ActorDto> Actors { get; set; }
        }

        public class Create
        {
            public string Title { get; set; }
            public Genre Genre { get; set; }
            public string Description { get; set; }
            public DateTime ReleaseDate { get; set; }
        }

        public class Delete
        {
            public int Id { get; set; }

        }
    }
}
