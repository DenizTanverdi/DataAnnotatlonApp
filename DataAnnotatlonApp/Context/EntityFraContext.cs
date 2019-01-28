using DataAnnotatlonApp.Entity;
using System.Data.Entity;

namespace DataAnnotatlonApp.Context
{
    public  class EntityFraContext:DbContext
    {
        public EntityFraContext():base("name=EFCon")
        {
            if (!Database.Exists())
            {
                Database.Create();
            }
            else { }
        }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Kisiler> Kisiler { get; set; }
       
        public DbSet<Adresler> Adresler { get; set; }
    }
}
