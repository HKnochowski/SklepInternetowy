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
    }
}