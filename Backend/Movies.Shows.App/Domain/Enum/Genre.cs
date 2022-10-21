namespace Domain.Enum
{
    [Flags]
    public enum Genre
    {
        ACTION = 1,
        ROMANCE = 2,
        THRILLER = 4,
        SPORTS = 8,
        COMEDY = 16,
        SCIFI = 32,
        HORROR = 64,
    }
}
