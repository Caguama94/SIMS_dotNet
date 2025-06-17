using Microsoft.Identity.Client.Extensions.Msal;

namespace SIMS_dotNet.Models
{
    public class Warehouses
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public int? StorageCapacity { get; set; }
        public int? AvailableStorageCapacity { get; set; }

    }
}
