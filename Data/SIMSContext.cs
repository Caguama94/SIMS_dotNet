using Microsoft.EntityFrameworkCore;

namespace SIMS_dotNet.Data
{
    public class SIMSContext : DbContext
    {
        public SIMSContext(DbContextOptions<SIMSContext> options) : base(options)
        {
        }       
    }
}
    

    