using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;

namespace worldtest
{
    class Program
    {
        private static Menu _menu;
        static void Main(string[] args)
        {
            Game.OnStart += Game_OnGameLoad;
        }
        static void Game_OnGameLoad(EventArgs args)
        {
            //this happens when injection into game
            Game.PrintChat("Loaded");
            //top menu
            _menu = new Menu("axxo", "axxo.display", true);
            _menu.AddToMainMenu();
        }


    }
}
