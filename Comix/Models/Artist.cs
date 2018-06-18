namespace Comix.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Comic[] Comics { get; set; }
    }
}