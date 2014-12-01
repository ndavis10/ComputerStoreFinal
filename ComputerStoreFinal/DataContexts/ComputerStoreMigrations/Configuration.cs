namespace ComputerStoreFinal.DataContexts.ComputerStoreMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ComputerStoreFinal.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ComputerStoreFinal.DataContexts.ComputerStoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\ComputerStoreMigrations";
        }

        protected override void Seed(ComputerStoreFinal.DataContexts.ComputerStoreDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var Parts = new List<Part>
            {
                new Part{ PartID = 1, ModelNumber = "F3-12800CL9D-8GBRL",
                    PartName = "G.SKILL Ripjaws Series 8GB (2 x 4GB) 240-Pin DDR3 SDRAM DDR3 1600 (PC3 12800) Desktop Memory",
                    PartDescription = "Description goes here.", PartPrice = 79.99m, PartImg = "", CategoryID = 3},
                new Part{ PartID = 2, ModelNumber = "F3-1866C9D-16GSR", 
                    PartName = "G.SKILL Sniper Series 16GB (2 x 8GB) 240-Pin DDR3 SDRAM DDR3 1866 (PC3 14900)",
                    PartDescription = "Description goes here.", PartPrice = 164.99m, PartImg = "", CategoryID = 3},
                new Part{ PartID = 3, ModelNumber = "F3-1866C8Q-32GTX", PartName = 
                    "G.SKILL Trident X Series 32GB (4 x 8GB) 240-Pin DDR3 SDRAM DDR3 1866 (PC3 14900)",
                    PartDescription = "Description goes here.", PartPrice = 349.99m, PartImg = "", CategoryID = 3},
                new Part{ PartID = 4, ModelNumber = "R9280X-DC2T-3GD5", PartName = "ASUS Radeon R9 280X 3GB",                    PartDescription = "Description goes here.", PartPrice = 259.99m, PartImg = "", CategoryID = 4},
                new Part{ PartID = 5, ModelNumber = "STRIX-GTX970-DC2OC-4GD5", PartName = "ASUS GeForce GTX 970 4GB",                     PartDescription = "Description goes here.", PartPrice = 349.99m, PartImg = "", CategoryID = 4},
                new Part{ PartID = 6, ModelNumber = "STRIX-GTX980-DC2OC-4GD5", PartName = "ASUS GeForce GTX 980 4G",                    PartDescription = "Description goes here.", PartPrice = 579.99m, PartImg = "", CategoryID = 4},
                new Part{ PartID = 7, ModelNumber = "ARESIII-8GD5", PartName = "ASUS Radeon R9 295X2 8GB",                    PartDescription = "Description goes here.", PartPrice = 1499, PartImg = "", CategoryID = 4},
                new Part{ PartID = 8, ModelNumber = "CA-PH410-G1", PartName = "NZXT Phantom 410 Series",                    PartDescription = "Description goes here.", PartPrice = 99.99m, PartImg = "", CategoryID = 6},
                new Part{ PartID = 9, ModelNumber = "S210-001", PartName = "NZXT Source 210",                    PartDescription = "Description goes here.", PartPrice = 44.99m, PartImg = "", CategoryID = 6},
                new Part{ PartID = 10, ModelNumber = "921RB-001-BL", PartName = "NZXT Guardian 921",                    PartDescription = "Description goes here.", PartPrice = 69.99m, PartImg = "", CategoryID = 6},
                new Part{ PartID = 11, ModelNumber = "M12II 520 Bronze", PartName = "SeaSonic M12II 520 Bronze 520W",                    PartDescription = "Description goes here.", PartPrice = 69.99m, PartImg = "", CategoryID = 7},
                new Part{ PartID = 12, ModelNumber = "SS-1250XM2", PartName = "SeaSonic X-1250 1250W",                     PartDescription = "Description goes here.", PartPrice = 239.99m, PartImg = "", CategoryID = 7},                new Part{ PartID = 13, ModelNumber = "SS-850KM3 Active PFC F3", PartName = "SeaSonic X Series X-850 850W",                    PartDescription = "Description goes here.", PartPrice = 169.99m, PartImg = "", CategoryID = 7},
                new Part{ PartID = 14, ModelNumber = "Z97-A", PartName = "ASUS Z97-A",                     PartDescription = "Description goes here.", PartPrice = 149.99m, PartImg = "", CategoryID = 1},
                new Part{ PartID = 15, ModelNumber = "Z97-P", PartName = "ASUS Z97-P",                    PartDescription = "Description goes here.", PartPrice = 119.99m, PartImg = "", CategoryID = 1},
                new Part{ PartID = 16, ModelNumber = "MAXIMUS VII HERO", PartName = "ASUS MAXIMUS VII HERO",                    PartDescription = "Description goes here.", PartPrice = 219.99m, PartImg = "", CategoryID = 1},                new Part{ PartID = 17, ModelNumber = "BX80646I74790K", PartName = "Intel Core i7-4790K",                     PartDescription = "Description goes here.", PartPrice = 349.99m, PartImg = "", CategoryID = 2},
                new Part{ PartID = 18, ModelNumber = "BX80646I54690K", PartName = "Intel Core i5-4690K",
                    PartDescription = "Description goes here.", PartPrice = 219.99m, PartImg = "", CategoryID = 2}
            };
        }
    }
}
