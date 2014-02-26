namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistanceToSun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planets", "DistanceFromSun", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planets", "DistanceFromSun");
        }
    }
}
