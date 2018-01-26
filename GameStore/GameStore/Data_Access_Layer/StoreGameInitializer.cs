using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameStore.Models;
using GameStore.Migrations;
using System.Data.Entity.Migrations;

namespace GameStore.Data_Access_Layer
{
    public class StoreGameInitializer : MigrateDatabaseToLatestVersion<StoreGameContext, Configuration >
    {
        public static void SeedStoreGame(StoreGameContext context)
        {
            var games = new List<Game>
            {
                new Game {  GameName="Witcher 3: Wild Hunt",
                            GameTypeId =1,
                            GameDescription ="Gra wydana przez polskie studia CD Project RED",
                            GamePremiere = new DateTime(2015,5,11),
                            GameRating =9,
                            OrToBuy =true},

                new Game {  GameName="The Elder Scroll V: Skyrim",
                            GameTypeId =1,
                            GameDescription ="Ga wydana przez studio Bethesda Game",
                            GamePremiere = new DateTime(2011,11,11),
                            GameRating =9,
                            OrToBuy =true},

                new Game {  GameName="Frost Punk",
                            GameTypeId =2,
                            GameDescription ="Gra tworzona przez polskie studio 11BitStudio",
                            GamePremiere = new DateTime(2018,3,31),
                            OrToBuy =false},

                new Game {  GameName="Grand Theft Auto V",
                            GameTypeId =3,
                            GameDescription ="Gra wydana przez studio Rockstar Games",
                            GamePremiere = new DateTime(2013,9,13),
                            GameRating =9,
                            OrToBuy =true},

                new Game {  GameName="Far Cry 5",
                            GameTypeId =3,
                            GameDescription ="Gra tworzona przez znane studio Ubisoft",
                            GamePremiere = new DateTime(2018,3,27),
                            GameRating =8,
                            OrToBuy =false}
            };

            games.ForEach(game => context.Games.AddOrUpdate(game));
            context.SaveChanges();

            var gamesTypes = new List<GameType>
            {
                new GameType {  GameTypeId=1,
                                NameGameType ="RPG",
                                DescriptionGameType ="gatunek gier komputerowych, w którym gracz kontroluje bohatera (lub drużynę) poruszającego się po fikcyjnym świecie",
                                FileGameType ="RPG.png"},

                new GameType {  GameTypeId=2,
                                NameGameType ="Strategia",
                                DescriptionGameType ="pojęcie odnoszące się do szerokiej grupy gier – przede wszystkim jednak chodzi tu o jedno- bądź wieloosobowe gry, w których wygrana zależy nie tylko od losu, ale przede wszystkim od strategii, wiedzy i planowania",
                                FileGameType ="Strategy.png"},

                new GameType {  GameTypeId=3,
                                NameGameType ="FPP",
                                DescriptionGameType ="określenie perspektywy graficznej w grach komputerowych, w których gracz widzi świat oglądany oczami głównego bohatera.",
                                FileGameType ="FPP.png"},
            };

            gamesTypes.ForEach(gameType => context.GamesTypes.AddOrUpdate(gameType));
            context.SaveChanges();

        }
    }
}