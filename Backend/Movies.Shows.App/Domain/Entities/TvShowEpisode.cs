namespace Domain.Entities
{
    public class TvShowEpisode
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TvShowSeasonId { get; set; }
        public TvShowSeason TvShowSeason { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Actor> Actors { get; set; }


        public TvShowEpisode()
        {
            Actors = new List<Actor>();
        }
    }
}
