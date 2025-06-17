namespace SIMS_dotNet.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public double? Format { get; set; }
        //TODO: public var image
        public string? Appearance { get; set; }
        public string? Material { get; set; }
        public string? SurfaceFinish { get; set; }
        public DateTime DateOfFabrication { get; set; } = DateTime.Now;
        public int? Batch { get; set; }
        public double? BoxLenght { get; set; }
        public double? BoxWidth { get; set; }
        public double? BoxHeight { get; set; }
        public double? BoxWeight { get; set; }
        public int? QtyPerBox { get; set; }
        public double? SurfacePerBox { get; set; }
        public double? Cost { get; set; }
        public double? Stock { get; set; }
        public int? AssignedSlot { get; set; }


    }
}
