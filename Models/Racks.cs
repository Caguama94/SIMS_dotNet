namespace SIMS_dotNet.Models
{
    public class Racks
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public int? AssignedWarehouse { get; set; }
        public int? Slots { get; set; } = 24;
        public int? EmptySlots { get; set; }
    }
}
