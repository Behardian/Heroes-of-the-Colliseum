namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHeroesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Heroes (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (1, 'Grimwald', 34, 20, 6, 90)");
            Sql("INSERT INTO Heroes (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (2, 'Gorlock', 37, 12, 12, 100)");
            Sql("INSERT INTO Heroes (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (3, 'Hirohito', 37, 18, 15, 70)");
            Sql("INSERT INTO Heroes (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (4, 'Thomas', 40, 14, 15, 60)");
            Sql("INSERT INTO Heroes (Id, Name, Attack, Defence, CritDam, HitPoints) VALUES (5, 'Uberon', 40, 16, 12, 70)");
        }
        
        public override void Down()
        {
        }
    }
}
