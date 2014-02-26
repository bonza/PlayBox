namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DistanceToSunNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Planets", "DistanceFromSun", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Planets", "DistanceFromSun", c => c.Int(nullable: false));
        }
    }
}
