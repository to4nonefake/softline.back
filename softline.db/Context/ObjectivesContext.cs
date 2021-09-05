using Microsoft.EntityFrameworkCore;
using softline.db.Model;

namespace softline.db.Context {
    public class ObjectivesContext : DbContext {
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SoftLineDB;Trusted_Connection=True");
        }
    }
}