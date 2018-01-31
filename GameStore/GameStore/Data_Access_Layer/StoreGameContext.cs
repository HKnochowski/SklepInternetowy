namespace GameStore.Data_Access_Layer
{
    using GameStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class StoreGameContext : DbContext
    {
        //Konstruktor do którego przekazujemy nasz ConnectionString
        public StoreGameContext()
            : base("name=StoreGameContext")
        {
        }

        //static StoreGameContext()
        //{
        //    Database.SetInitializer<StoreGameContext>(new StoreGameInitializer());
        //}

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Copie> Copies { get; set; }
       /*TODO public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GameLanguage> GameLanguage { get; set; }
        public DbSet<GamePublisher> GamePublisher { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<PlatformType> PlatformType { get; set; }
        public DbSet<SalesInvoice> SalesInvoice { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<SystemRequir> SystemRequir { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<WishList> WishList { get; set; } */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Wy³¹czenie konwencji która automatycznie tworzy liczbê mnog¹ dla nazw tabel w bazie danych
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}