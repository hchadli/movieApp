namespace Domain.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<TvShow> TvShows { get; set; }


        public Actor()
        {
            Movies = new List<Movie>();
            TvShows = new List<TvShow>();
        }
    }
}
