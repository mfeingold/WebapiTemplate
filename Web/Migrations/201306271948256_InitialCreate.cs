namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserRealm = c.String(),
                        RealmID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.ApplicationPermissions",
                c => new
                    {
                        ApplicationPermissionID = c.Int(nullable: false, identity: true),
                        Permission = c.String(),
                        Application_ApplicationID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ApplicationPermissionID)
                .ForeignKey("dbo.Applications", t => t.Application_ApplicationID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Application_ApplicationID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ApplicationID = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ApplicationPermissions", new[] { "User_UserID" });
            DropIndex("dbo.ApplicationPermissions", new[] { "Application_ApplicationID" });
            DropForeignKey("dbo.ApplicationPermissions", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.ApplicationPermissions", "Application_ApplicationID", "dbo.Applications");
            DropTable("dbo.Applications");
            DropTable("dbo.ApplicationPermissions");
            DropTable("dbo.Users");
        }
    }
}
