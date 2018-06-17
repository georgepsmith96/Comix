using System;

namespace Comix.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Artist[] Writers { get; set; }
        public Artist[] Artists { get; set; }
        public Artist Cover { get; set; }
        public Character[] Characters { get; set; }
        public Series Series { get; set; }
        public Genre Genre { get; set; }
        public DateTime DatePublished { get; set; }
    }
}