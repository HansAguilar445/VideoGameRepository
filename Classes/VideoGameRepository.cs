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
            Studio WildcardStudio = new("Wildcard Studio", 4_000_000);
            Studios.Add(WildcardStudio);

            Publisher WildcardPublishing = new("Wildcard Publishing", 4_000_000);
            Publishers.Add(WildcardPublishing);

            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studios.Add(coffeeStainStudio);

            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publishers.Add(coffeeStainPublishing);



            Studio KeenSoftwareHouseStudio = new("Keen Software House Studios", 500_000);
            Studios.Add(KeenSoftwareHouseStudio);

            Publisher KeenSoftwareHousePublishing = new("Keen Software House Publishing", 500_000);
            Publishers.Add(KeenSoftwareHousePublishing);

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

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);
            pc.AddGame(satisfactory);

            VideoGame ARKSurvivalEvolved = new(
                title: "ARK: Survival Evolved",
                category: "Survival",
                year: 2017,
                playerCount: 100,
                price: 20f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            VideoGames.Add(ARKSurvivalEvolved);

            WildcardPublishing.AddGame(ARKSurvivalEvolved);
            WildcardPublishing.AddStudio(WildcardStudio);
            pc.AddGame(ARKSurvivalEvolved);

            offeeStainStudio.AddGame(SpaceEngineers);
            coffeeStainPublishing.AddStudio(KeenSoftwareHousePublishing);
            pc.AddGame(SpaceEngineers);

            VideoGame SpaceEngineers = new(
                title: "Space Engineers",
                category: "Survival",
                year: 2019,
                playerCount: 20,
                price: 22f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            VideoGames.Add(SpaceEngineers);


            KeenSoftwareHousePublishing.AddGame(SpaceEngineers);
            KeenSoftwareHousePublishing.AddStudio(KeenSoftwareHousePublishing);
            pc.AddGame(SpaceEngineers);


        }
    }
}
