namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMonsterTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (1, 'Medusa', 31, 14, 15, 70)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (2, 'Hydra', 28, 18, 3, 120)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (3, 'Nemean Lion', 31, 18, 3, 110)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (4, 'Cyclops', 28, 18, 6, 110)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (5, 'Minotaur', 31, 14, 12, 110)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (6, 'Harpy', 28, 20, 12, 70)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (7, 'Chimera', 25, 20, 15, 80)");
            Sql("INSERT INTO Monsters (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (8, 'Titan', 34, 20, 15, 120)");
        }
        
        public override void Down()
        {
        }
    }
}
