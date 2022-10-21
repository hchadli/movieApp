namespace Domain.Entities
{
    public class TvShow
    {

        public ICollection<TvShowSeason> TvShowSeasons { get; set; }


        public TvShow()
        {
            TvShowSeasons = new List<TvShowSeason>();
        }
    }
}
