namespace College360API.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Floor { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}