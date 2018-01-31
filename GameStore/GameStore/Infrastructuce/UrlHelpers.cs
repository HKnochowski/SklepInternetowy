using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Infrastructuce
{
    public static class UrlHelpers
    {
        public static string NewsImagePath(this UrlHelper helper, string NameImageNewsGame)
        {
            var NewsGamesFolder = AppConfig.NewsGamesFolderRelative;
            var pathway = Path.Combine(NewsGamesFolder, NameImageNewsGame);
            var PathRelative = helper.Content(pathway);

            return PathRelative;
        }

        public static string BestsellerImagePath(this UrlHelper helper, string NameImageBestsellerGame)
        {
            var BestsellerGamesFolder = AppConfig.BestsellerGamesFolderRelative;
            var pathway = Path.Combine(BestsellerGamesFolder, NameImageBestsellerGame);
            var PathRelative = helper.Content(pathway);

            return PathRelative;
        }

        public static string RecommendedImagePath(this UrlHelper helper, string NameImageRecommendedGame)
        {
            var RecommendedGamesFolder = AppConfig.RecommendedGamesFolderRelative;
            var pathway = Path.Combine(RecommendedGamesFolder, NameImageRecommendedGame);
            var PathRelative = helper.Content(pathway);

            return PathRelative;
        }
    }
}