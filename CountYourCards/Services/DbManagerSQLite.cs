using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountYourCards.Models;
using Microsoft.EntityFrameworkCore;

namespace CountYourCards.Services {
    public class DbManagerSQLite : DbContext {
            public DbSet<User> Users { get; set; }
            public DbSet<Spielstand> Spielstände { get; set; }
            
        
            public DbManagerSQLite() {
                SQLitePCL.Batteries_V2.Init();
                this.Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
                string dbPath = Path.Combine(FileSystem.AppDataDirectory, "CountYourCards.db");
            // C:\Users\dduli\AppData\Local\User Name\com.companyname.countyourcards\Data\CountYourCards.db
            optionsBuilder.UseSqlite($"Filename={dbPath}");
            }
        }
    }