using Microsoft.EntityFrameworkCore;

namespace DemoHostingMNO.Models
{
    public class MijnContext : DbContext
    {
        public MijnContext(DbContextOptions<MijnContext> options) : base(options)
        {
            
        }

        //TADA!
 

        public DbSet<Pakjes> Pakjes { get; set; }
    }
}
