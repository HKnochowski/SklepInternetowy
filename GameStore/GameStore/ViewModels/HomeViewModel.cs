using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> News { get; set; }
        public IEnumerable<Game> Bestsellery { get; set; }
        public IEnumerable<Game> Recommended { get; set; }
        public IEnumerable<Game> NewsActive { get; set; }
        public IEnumerable<GameType> gameType { get; set; }
    }
}