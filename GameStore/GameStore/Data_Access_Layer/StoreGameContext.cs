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

        /*static StoreGameContext()
        {
            Database.SetInitializer<StoreGameContext>(new StoreGameInitializer());
        }*/

        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Copie> Copies { get; set; }
        public DbSet<GameLanguage> GamesLanguages { get; set; }
        public DbSet<GamePublisher> GamesPublishers { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlatformType> PlatformsTypes { get; set; }
        public DbSet<SystemRequir> SystemRequirs { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<UserAccount> UsersAccounts { get; set; }

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