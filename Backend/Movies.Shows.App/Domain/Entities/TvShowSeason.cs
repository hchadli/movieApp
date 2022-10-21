namespace Domain.Entities
{
    public class TvShowSeason
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<TvShowEpisode> TvShowEpisodes { get; set; }


        public TvShowSeason()
        {
            TvShowEpisodes = new List<TvShowEpisode>();
        }
    }
}
