namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUrlToMonstersTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Monsters", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Monsters", "ImageUrl");
        }
    }
}
