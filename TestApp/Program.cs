using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PUBGSDK;

namespace TestApp
{
    internal class Program
    {
        private static string api_key = "";

        private static void Main(string[] args)
        {
            api_key = File.ReadAllText("api_key.txt");

            var x = new Authorization(api_key);
            var m = new Match(x);


            var match = m.GetMatchById("db796808-296e-47bc-a037-ea87de85e880");
            Console.WriteLine(match.Data.Id);

            var p = new Player(x);
            var player = p.GetPlayerById("account.65e2d47314f14da7be244659b9323796");
            Console.WriteLine(player.Data.Attributes.Name);


            //Please notice, that the api silently ignores invalid name's
            var players = p.GetPlayersByNames(new List<string> {"Scarjit", "some_stupid_value"});
            Console.WriteLine(players.Data.First().Attributes.Name);

            //Please notice, that the api silently ignores invalid id's
            var players2 =
                p.GetPlayersByIds(new List<string> {"some_stupid_value", "account.821c1d0c2a494626b8aaf7414a3034f9"});
            Console.WriteLine(players2.Data.First().Attributes.Name);


            var telem = m.GetTelemetry(match);

            Console.WriteLine(telem.First().Url);

            var t = new Telemetry();
            var xtelem = t.GetTelemetry(telem.First().Url);

            Console.WriteLine(xtelem.First().T);


            Console.WriteLine("PRESS ENTER TO EXIT");
            Console.ReadLine();
        }
    }
}