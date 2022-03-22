using CRUDSPWithCore5.Models;
using CRUDWithSPDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithSP.Entites
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        public virtual DbSet<StudentMaster> StudentMasters { get; set; }
        public virtual DbSet<CityMaster> CityMasters { get; set; }
    }
}
