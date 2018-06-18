namespace Comix.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Comic[] Comics { get; set; }
    }
}