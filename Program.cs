using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

            allSongs.Add(("Nickelback", "Gotta Be Somebody"));
            allSongs.Add(("Nickelback", "RockStar"));
            allSongs.Add(("Nickelback", "If Today Was Your Last Day"));
            allSongs.Add(("Imagine Dragons", "Thunder"));
            allSongs.Add(("Beastie Boys", "Fight For Your Right"));
            allSongs.Add(("Barry Manilow", "Mandy"));
            allSongs.Add(("Def Leppard", "Pour Some Sugar On Me"));

            foreach ((string, string) item in allSongs)
            {
                if (!item.Item1.Contains("Nickelback"))
                {
                    goodSongs.Add(item);
                }
            }
            foreach ((string, string) song in goodSongs)
            {
                Console.WriteLine($"{song.Item1} has a good song titled {song.Item2}.");
            }
        }
    }
}
