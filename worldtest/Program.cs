using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;

namespace worldtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.OnStart += Game_OnGameLoad;
        }
        static void Game_OnGameLoad(EventArgs args)
        {
            //this happens when injection into game
            Game.PrintChat("Loaded");
        }


    }
}
