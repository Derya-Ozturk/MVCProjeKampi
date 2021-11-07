namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class writer_mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
            AlterColumn("dbo.Contents", "HeadingID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            DropColumn("dbo.Writers", "WriterAbout");
        }
    }
}
