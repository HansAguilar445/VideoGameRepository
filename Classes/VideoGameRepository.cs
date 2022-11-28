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
            Studios.Add(coffeeStainStudio);

            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publishers.Add(coffeeStainPublishing);

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
            VideoGames.Add(satisfactory);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);
            pc.AddGame(satisfactory);

            Studio hopooGames = new("Hopoo Games", 5_000_000);
            Studios.Add(hopooGames);

            Publisher gearbox = new("Gearbox", 5);
            Publishers.Add(gearbox);

            VideoGame riskOfRain = new(
                title: "Risk of Rain",
                category: "Roguelike",
                year: 2013,
                playerCount: 4,
                price: 11f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain);

            hopooGames.AddGame(riskOfRain);
            gearbox.AddStudio(hopooGames);
            pc.AddGame(riskOfRain);

            VideoGame riskOfRain2 = new(
                title: "Risk of Rain 2",
                category: "Roguelike",
                year: 2018,
                playerCount: 4,
                price: 29f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain2);

            hopooGames.AddGame(riskOfRain2);
            pc.AddGame(riskOfRain2);

            Studio ninjaKiwi = new("Ninja Kiwi", 3_000_000);
            Studios.Add(ninjaKiwi);

            Publisher ninjaKiwiPublishing = new("Ninja Kiwi Publishing", 1_000_000);
            Publishers.Add(ninjaKiwiPublishing);

            VideoGame bloonsTD6 = new(
                title: "Bloons TD 6",
                category: "Tower Defense",
                year: 2018,
                playerCount: 4,
                price: 15.49f,
                studio: ninjaKiwi,
                consoles: new() { pc },
                publisher: ninjaKiwiPublishing,
                ageRating: 9
                );
            VideoGames.Add(bloonsTD6);

            ninjaKiwi.AddGame(bloonsTD6);
            ninjaKiwiPublishing.AddStudio(ninjaKiwi);
            pc.AddGame(bloonsTD6);
        }
    }
}
