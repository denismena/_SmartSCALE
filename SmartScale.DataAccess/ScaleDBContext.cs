using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SmartScales.Model;

namespace SmartScale.DataAccess
{
    public class ScaleDBContext : DbContext
    {
        public ScaleDBContext(): base("smartScalesDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ScaleDBContext, Migrations.Configuration>("smartScalesDBConnectionString"));
        }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<Furnizori> Furnizori { get; set; }
        public DbSet<Clienti> Clienti { get; set; }
        public DbSet<Soferi> Soferi { get; set; }
        public DbSet<Masini> Masini { get; set; }
        public DbSet<Articole> Articole { get; set; }
        public DbSet<Operatori> Operatori { get; set; }
        public DbSet<CantarSetari> SetariCantare { get; set; }
        public DbSet<AppInitSettings> AppInitSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table names match entity names by default (don't pluralize)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // Globally disable the convention for cascading deletes
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
