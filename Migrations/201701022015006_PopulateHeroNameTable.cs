namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHeroNameTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO HeroNames (Id, Name) VALUES (1, 'Grimwald')");
            Sql("INSERT INTO HeroNames (Id, Name) VALUES (2, 'Gorlock')");
            Sql("INSERT INTO HeroNames (Id, Name) VALUES (3, 'Hirohito')");
            Sql("INSERT INTO HeroNames (Id, Name) VALUES (4, 'Thomas')");
            Sql("INSERT INTO HeroNames (Id, Name) VALUES (5, 'Uberon')");
        }
        
        public override void Down()
        {
        }
    }
}
