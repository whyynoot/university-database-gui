using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;


namespace DatabaseContext
{
    public class UniversityContext : DbContext
    {
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Curators> Curators { get; set; }
        public DbSet<Professors> Professors { get; set; }

        public UniversityContext(string connectionString): base(GetOptions(connectionString))
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>();
            modelBuilder.Entity<Students>();
            modelBuilder.Entity<Curators>();
            modelBuilder.Entity<Professors>();
            modelBuilder.Entity<Professors>().HasMany(s => s.Groups).WithMany(c => c.Professors);
            modelBuilder.Entity<Groups>().HasMany(s => s.Professors).WithMany(c => c.Groups);
        }


        private static DbContextOptions GetOptions(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            if (connectionString.Contains(".db"))
            {
                optionsBuilder.UseSqlite(connectionString);
            }
            else
            {
                optionsBuilder.UseNpgsql(connectionString);
            }
            ModelBuilder modelBuilder = new ModelBuilder();
            modelBuilder.Entity<Students>().HasKey(s => s.Id);
            modelBuilder.Entity<Students>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Students>().Property(s => s.Age).IsRequired();
            modelBuilder.Entity<Students>().HasAlternateKey(s => s.GroupId);
            modelBuilder.Entity<Groups>().HasKey(g => g.Id);
            modelBuilder.Entity<Groups>().Property(g => g.Name).IsRequired();
            modelBuilder.Entity<Groups>().Property(g => g.CreationDate).IsRequired();
            //modelBuilder.Entity<Groups>().HasMany(s => s.Professors);
            modelBuilder.Entity<Curators>().HasKey(c => c.Id);
            modelBuilder.Entity<Curators>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Curators>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Curators>().HasAlternateKey(s => s.GroupId);
            // new Enity
            modelBuilder.Entity<Professors>().HasKey(c => c.Id);
            modelBuilder.Entity<Professors>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Professors>().HasMany(s => s.Groups).WithMany(c => c.Professors);
            modelBuilder.Entity<Groups>().HasMany(s => s.Professors).WithMany(c => c.Groups);
            return optionsBuilder.Options;
        }
    }

    
}
