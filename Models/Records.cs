namespace SIMS_dotNet.Models
{
    public class Records
    {
        public int Id { get; set; }
        public string? Type {  get; set; }
        public string? Description { get; set; }
        public string? User {  get; set; }
        public string? Warehouse {  get; set; }
        public DateTime Created { get; set; }= DateTime.Now;
        public DateTime? LastUpdated { get; set; } = DateTime.Now;
    }
}
