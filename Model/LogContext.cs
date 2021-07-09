using Microsoft.EntityFrameworkCore;
using woodcalc_00.Model;

namespace woodcalc_00
{
    public class LogContext : DbContext
    {
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Tree> Trees { get; set; }
        public virtual DbSet<Calculation> Calculations { get; set; }
        public virtual DbSet<Quality> Qualities  { get; set; }
        public virtual DbSet<CalculationParameters> CalculationParameters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=logs.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculation>()
                .HasMany(c => c.Logs)
                .WithOne(e => e.Calculation)
                .IsRequired();
            modelBuilder.Entity<Tree>()
                .HasMany(c => c.Logs)
                .WithOne(e => e.Tree)
                .HasForeignKey("TreeId");                 
            modelBuilder.Entity<Quality>()
                .HasMany(c => c.Logs)
                .WithOne(e => e.Quality);
            modelBuilder.Entity<CalculationParameters>()
                .HasOne(c => c.Calculation)
                .WithMany(e => e.CalculationParameters)
                .HasForeignKey("CalculationId");
            modelBuilder.Entity<CalculationParameters>()
                .HasMany(c => c.Trees)
                .WithOne(e => e.CalculationParameters)                
                .IsRequired();
            modelBuilder.Entity<Quality>().HasData(
                new Quality { Id = 1, QualityClass = "A" },
                new Quality { Id = 2, QualityClass = "B" },
                new Quality { Id = 3, QualityClass = "C" },
                new Quality { Id = 4, QualityClass = "D" }
                );
            modelBuilder.Entity<Calculation>().HasData(
                new Calculation { Id = 1, TypeOfCalculation = "Huberův vzorec", CalculationParameters = null },
                new Calculation { Id = 2, TypeOfCalculation = "Smalianův vzorec", CalculationParameters = null },
                new Calculation { Id = 3, TypeOfCalculation = "Newtonův vzorec", CalculationParameters = null },
                new Calculation { Id = 4, TypeOfCalculation = "ČSN 48 0007", CalculationParameters = null },
                new Calculation { Id = 5, TypeOfCalculation = "ČSN 48 0009", CalculationParameters = null }
                );
            modelBuilder.Entity<CalculationParameters>().HasData(
                new CalculationParameters { Id = 1, Name = "1. skupina", CalculationId = 5, E0 = 0.57723, E1 = 0.006897, E2 = 1.3123 },
                new CalculationParameters { Id = 2, Name = "2. skupina", CalculationId = 5, E0 = 0.24017, E1 = 0.001915, E2 = 1.7866 },
                new CalculationParameters { Id = 3, Name = "3. skupina", CalculationId = 5, E0 = 1.7015, E1 = 0.008762, E2 = 1.4568 },
                new CalculationParameters { Id = 4, Name = "4. skupina", CalculationId = 5, E0 = -0.04088, E1 = 0.16634, E2 = 0.56076 },
                new CalculationParameters { Id = 5, Name = "5. skupina", CalculationId = 5, E0 = 1.2474, E1 = 0.042323, E2 = 1.0623 }
                );
            modelBuilder.Entity<Tree>().HasData(
                new Tree { Id = 1, TypeOfTree = "smrk", CalculationParametersId = 1 },
                new Tree { Id = 2, TypeOfTree = "jedle", CalculationParametersId = 1 },
                new Tree { Id = 3, TypeOfTree = "borovice - kůra", CalculationParametersId = 2 },
                new Tree { Id = 4, TypeOfTree = "borovice vejmutovka", CalculationParametersId = 2 },
                new Tree { Id = 5, TypeOfTree = "douglaska", CalculationParametersId = 2 },
                new Tree { Id = 6, TypeOfTree = "borovice - borka (oddenkové výřezy)", CalculationParametersId = 3 },
                new Tree { Id = 7, TypeOfTree = "modřín", CalculationParametersId = 3 },
                new Tree { Id = 8, TypeOfTree = "buk", CalculationParametersId = 4 },
                new Tree { Id = 9, TypeOfTree = "habr", CalculationParametersId = 4 },
                new Tree { Id = 10, TypeOfTree = "javor", CalculationParametersId = 4 },
                new Tree { Id = 11, TypeOfTree = "jeřáb", CalculationParametersId = 4 },
                new Tree { Id = 12, TypeOfTree = "lípa", CalculationParametersId = 4 },
                new Tree { Id = 13, TypeOfTree = "osika", CalculationParametersId = 4 },
                new Tree { Id = 14, TypeOfTree = "bříza", CalculationParametersId = 5 },
                new Tree { Id = 15, TypeOfTree = "dub", CalculationParametersId = 5 },
                new Tree { Id = 16, TypeOfTree = "jasan", CalculationParametersId = 5 },
                new Tree { Id = 17, TypeOfTree = "jilm", CalculationParametersId = 5 },
                new Tree { Id = 18, TypeOfTree = "olše", CalculationParametersId = 5},
                new Tree { Id = 19, TypeOfTree = "topol", CalculationParametersId = 5 }
                );
        }
    }
}
