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
            public ICollection<MediaDto> Media { get; set; }
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
