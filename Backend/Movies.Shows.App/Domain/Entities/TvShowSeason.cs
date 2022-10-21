namespace Domain.Entities
{
    public class TvShowSeason
    {
        public int Id { get; set; }
        public int SeasonNumber { get; set; }
        public string Description { get; set; }
        public int TvShowId { get; set; }
        public TvShow TvShow { get; set; }
        public ICollection<TvShowEpisode> TvShowEpisodes { get; set; }


        public TvShowSeason()
        {
            TvShowEpisodes = new List<TvShowEpisode>();
        }
    }
}
