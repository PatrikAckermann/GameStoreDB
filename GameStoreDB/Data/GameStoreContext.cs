using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameStoreDB.Models;

namespace GameStoreDB.Data
{
    internal class GameStoreContext : DbContext
    {
        public DbSet<Spiel> Spiele { get; set; } = null!;
        public DbSet<Lagerbestand> Lagerbestaende { get; set; } = null!;
        public DbSet<Spieltyp> Spieltypen { get; set; } = null!;
        public DbSet<Hersteller> Hersteller { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GameStoreDB;Integrated Security=True;");
        }
    }
}
