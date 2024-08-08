using Microsoft.EntityFrameworkCore;

namespace CCTruckQ.Data
{
   public class AppContext : DbContext
   {
      public AppContext() { }

      public AppContext(DbContextOptions<AppContext> options) : base(options) { }
   }
}
