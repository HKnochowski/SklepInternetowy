using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GameStore.Infrastructuce
{
    public class AppConfig
    {
        private static string _NewsGamesFolderRelative = ConfigurationManager.AppSettings["NewsGamesFolder"];

        public static string NewsGamesFolderRelative
        {
            get
            {
                return _NewsGamesFolderRelative;
            }
         
        }

        private static string _BestsellerGamesFolderRelative = ConfigurationManager.AppSettings["BestsellerGamesFolder"];

        public static string BestsellerGamesFolderRelative
        {
            get
            {
                return _BestsellerGamesFolderRelative;
            }

        }

        private static string _RecommendedGamesFolderRelative = ConfigurationManager.AppSettings["RecommendedGamesFolder"];

        public static string RecommendedGamesFolderRelative
        {
            get
            {
                return _RecommendedGamesFolderRelative;
            }

        }

        private static string _CategoryListGamesFolderRelative = ConfigurationManager.AppSettings["CategoryListGamesFolder"];

        public static string CategoryListGamesFolderRelative
        {
            get
            {
                return _CategoryListGamesFolderRelative;
            }

        }

        private static string _GameLogoGamesFolderRelative = ConfigurationManager.AppSettings["GameLogoGamesFolder"];

        public static string GameLogoGamesFolderRelative
        {
            get
            {
                return _GameLogoGamesFolderRelative;
            }

        }
    }
}