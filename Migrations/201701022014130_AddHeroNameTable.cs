namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHeroNameTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeroNames",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HeroNames");
        }
    }
}
