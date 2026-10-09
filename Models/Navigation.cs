namespace College360API.Models
{
    public class Navigation
    {
        public int Id { get; set; }

        public int FromLocationId { get; set; }

        public int ToLocationId { get; set; }

        public double Pitch { get; set; }

        public double Yaw { get; set; }

        public double EntryYaw { get; set; }

        public string Direction { get; set; } = string.Empty;
    }
}