namespace GameStore.Data_Access_Layer
{
    using GameStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class StoreGameContext : DbContext
    {
        //Konstruktor do kt�rego przekazujemy nasz ConnectionString
        public StoreGameContext()
            : base("name=StoreGameContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Copie> Copies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Wy��czenie konwencji kt�ra automatycznie tworzy liczb� mnog� dla nazw tabel w bazie danych
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}