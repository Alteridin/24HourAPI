namespace _24Hour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "CommentIdz", c => c.Guid(nullable: false));
            AddColumn("dbo.Post", "PostIdz", c => c.Guid(nullable: false));
            AddColumn("dbo.Like", "LikeIdz", c => c.Guid(nullable: false));
            AddColumn("dbo.Reply", "ReplyIdz", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reply", "ReplyIdz");
            DropColumn("dbo.Like", "LikeIdz");
            DropColumn("dbo.Post", "PostIdz");
            DropColumn("dbo.Comment", "CommentIdz");
        }
    }
}
