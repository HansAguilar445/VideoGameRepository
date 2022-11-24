using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRepository.Classes
{
    internal class VideoGameRepository
    {
        public HashSet<VideoGame> VideoGames { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get; set; } = new();
        public HashSet<Publisher> Publishers { get; set; } = new();
        public HashSet<Studio> Studios { get; set; } = new();

        public VideoGameRepository()
        {
            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studio maddyMakesGamesStudio = new("Maddy Makes Games", 3_000_000);
            Studios.Add(coffeeStainStudio);
            Studios.Add(maddyMakesGamesStudio);

            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publisher maddyMakesGamesPublishing = new("Maddy Makes Games", 36_000_000);
            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(maddyMakesGamesPublishing);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            Consoles.Add(pc);

            VideoGame satisfactory = new(
                title: "Satisfactory",
                category: "Simulation",
                year: 2018,
                playerCount: 4,
                price: 40f,
                studio: coffeeStainStudio,
                consoles: new() { pc },
                publisher: coffeeStainPublishing,
                ageRating: 10
                );

            VideoGames celeste = new(
                title: "Celeste",
                category: "Platformer",
                year: 2018,
                playerCount: 1,
                price: 20f,
                studio: maddyMakesGamesStudio,
                consoles: new() { pc },
                publisher: maddyMakesGamesPublishing,
                ageRating: 10
                );

            VideoGames.Add(satisfactory);
            VideoGames.Add(celeste);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);

            maddyMakesGamesStudio.AddGame(celeste);
            maddyMakesGamesPublishing.AddStudio(maddyMakesGamesStudio);

            pc.AddGame(satisfactory);
            pc.AddGame(celeste);
        }
    }
}
