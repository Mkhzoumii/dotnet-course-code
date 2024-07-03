namespace Models
{
    public class Computer
    {
        // private string _motherPoard;
        public int ComputerId { get; set; }
        public string Motherboard { get; set; }
        public int? CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Decimal Price { get; set; }
        public string? VideoCard { get; set; }
        public Computer()
        {
            if (VideoCard == null)
            {
                VideoCard = " ";
            }
            if (Motherboard == null)
            {
                Motherboard = " ";
            }
            if (CPUCores == null)
            {
                CPUCores = 0;

            }

        }

        internal static object AsEnumerable(string v)
        {
            throw new NotImplementedException();
        }
    }
}