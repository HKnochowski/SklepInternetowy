using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GameStore.Data_Access_Layer
{
    public class GameStoreContext : DbContext
    {
        //Konstruktor do którego przekazujemy nasz ConnectionString
        public GameStoreContext() : base("GameStoreContext")
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Copie> Copies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Wyłączenie konwencji która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}