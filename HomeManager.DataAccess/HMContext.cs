using HomeManager.DataAccess.Migrations;
using HomeManager.DataAccess.Models;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace HomeManager.DataAccess
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HMContext : DbContext
    {
        public virtual DbSet<Entry> Entires { get; set; }
        public virtual DbSet<EntryGroup> EntryGroups { get; set; }

        public HMContext() : base("DefaultConnection") { }

        public HMContext(string connection): base(connection) { }

        static HMContext()
        {
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<HMContext>());
            //Database.SetInitializer<GmContext>(null);
        }

        public static HMContext Create()
        {
            return new HMContext();
        }
    } 
}
