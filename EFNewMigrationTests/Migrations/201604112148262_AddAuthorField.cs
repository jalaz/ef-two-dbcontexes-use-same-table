namespace EFNewMigrationTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Author");
        }
    }
}
