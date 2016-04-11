namespace EFMigrationTests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongId = c.Int(nullable: false, identity: true),
                        SongName = c.String(),
                    })
                .PrimaryKey(t => t.SongId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
        }
    }
}
