namespace GameStore.Migrations
{
    using GameStore.Data_Access_Layer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<GameStore.Data_Access_Layer.StoreGameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameStore.Data_Access_Layer.StoreGameContext";
        }

        /*protected override void Seed(GameStore.Data_Access_Layer.StoreGameContext context)
        {
            StoreGameInitializer.SeedStoreGame(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }*/
    }
}
