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


        }
    }
}
