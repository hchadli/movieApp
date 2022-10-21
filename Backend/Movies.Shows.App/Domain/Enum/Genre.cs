namespace Domain.Enum
{
    [Flags]
    public enum Genre
    {
        ACTION = 0,
        ROMANCE = 1,
        THRILLER = 2,
        SPORTS = 4,
        COMEDY = 8,
        SCIFI = 16,
        HORROR = 32,
    }
}
