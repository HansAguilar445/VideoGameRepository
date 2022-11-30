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
            Studio maddyMakesGamesStudio = new("Maddy Makes Games", 3_000_000);

            Studios.Add(maddyMakesGamesStudio);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studio halLabs = new("HAL Laboratories", 1_000_000);
            Studio atlus = new("Atlus", 1_000_000);

            Studios.Add(coffeeStainStudio);
            Studios.Add(monolithSoft);
            Studios.Add(halLabs);
            Studios.Add(atlus);
            
            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);

            Publisher maddyMakesGamesPublishing = new("Maddy Makes Games", 36_000_000);
            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(maddyMakesGamesPublishing);

            Publisher nintendo = new("Nintendo", 15_000_000_000);
            Publisher sega = new("Sega", 2_730_000_000);
            Publishers.Add(nintendo);
            Publishers.Add(sega);

            nintendo.AddStudio(monolithSoft);
            nintendo.AddStudio(halLabs);

            sega.AddStudio(atlus);

            Studio KeenSoftwareHouseStudio = new("Keen Software House Studios", 500_000);
            Studios.Add(KeenSoftwareHouseStudio);

            Publisher KeenSoftwareHousePublishing = new("Keen Software House Publishing", 500_000);
            Publishers.Add(KeenSoftwareHousePublishing);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);

            Consoles.Add(pc);
            Consoles.Add(wiiU);
            Consoles.Add(nSwitch);

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

            VideoGame celeste = new(
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

            WildcardPublishing.AddStudio(WildcardStudio);
            pc.AddGame(ARKSurvivalEvolved);

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

            coffeeStainStudio.AddGame(SpaceEngineers);
            pc.AddGame(SpaceEngineers);

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

            maddyMakesGamesStudio.AddGame(celeste);
            maddyMakesGamesPublishing.AddStudio(maddyMakesGamesStudio);


            VideoGame xenoblade = new(
                title: "Xenoblade Chronicles: Definitive Edition",
                category: "JRPG",
                year: 2020,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade2 = new(
                title: "Xenoblade Chronicles 2",
                category: "JRPG",
                year: 2017,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade3 = new(
                title: "Xenoblade Chronicles 3",
                category: "JRPG",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenobladeX = new(
                title: "Xenoblade Chronicles X",
                category: "JRPG",
                year: 2015,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame forgottenLand = new(
                title: "Kirby and the Forgotten Land",
                category: "3D Platformer",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: halLabs,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 7
            );

            VideoGame smtV = new(
                title: "Shin Megami Tensei V",
                category: "JRPG",
                year: 2021,
                playerCount: 1,
                price: 80f,
                studio: atlus,
                consoles: new() { nSwitch },
                publisher: sega,
                ageRating: 16
                );

            VideoGames.Add(xenoblade);
            VideoGames.Add(xenoblade2);
            VideoGames.Add(xenoblade3);
            VideoGames.Add(xenobladeX);
            VideoGames.Add(forgottenLand);
            VideoGames.Add(smtV);

            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);
            monolithSoft.AddGame(xenobladeX);

            halLabs.AddGame(forgottenLand);

            atlus.AddGame(smtV);

            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);
            nSwitch.AddGame(smtV);

            wiiU.AddGame(xenobladeX);

            pc.AddGame(satisfactory);
            pc.AddGame(celeste);
        }
    }
}
