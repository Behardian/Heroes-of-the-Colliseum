namespace HeroesOfTheColliseumMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageUrlToHeroTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Heroes", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Heroes", "ImageUrl");
        }
    }
}
