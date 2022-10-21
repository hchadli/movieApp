﻿namespace Domain.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Media> Media { get; set; }


        public Actor()
        {
            Media = new List<Media>();
        }
    }
}
