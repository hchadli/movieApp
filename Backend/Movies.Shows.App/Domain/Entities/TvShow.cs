namespace Domain.Entities
{
    public class TvShow : Media
    {

        public ICollection<TvShowSeason> TvShowSeasons { get; set; }


        public TvShow()
        {
            TvShowSeasons = new List<TvShowSeason>();
        }
    }
}
