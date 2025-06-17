namespace SIMS_dotNet.Models
{
    public class Slots
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? ProductStock {  get; set; }
        public int? AssignedRack {  get; set; }
        public double? Lenght { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Volume { get; set; }
    }
}
