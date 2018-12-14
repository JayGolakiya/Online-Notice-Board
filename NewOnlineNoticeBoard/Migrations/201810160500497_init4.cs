namespace NewOnlineNoticeBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllNotices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CEN_NoticeId = c.Int(),
                        CHN_NoticeId = c.Int(),
                        ECN_NoticeId = c.Int(),
                        ICN_NoticeId = c.Int(),
                        ITN_NoticeId = c.Int(),
                        MHN_NoticeId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CE_Notice", t => t.CEN_NoticeId)
                .ForeignKey("dbo.CH_Notice", t => t.CHN_NoticeId)
                .ForeignKey("dbo.EC_Notice", t => t.ECN_NoticeId)
                .ForeignKey("dbo.IC_Notice", t => t.ICN_NoticeId)
                .ForeignKey("dbo.IT_Notice", t => t.ITN_NoticeId)
                .ForeignKey("dbo.MH_Notice", t => t.MHN_NoticeId)
                .Index(t => t.CEN_NoticeId)
                .Index(t => t.CHN_NoticeId)
                .Index(t => t.ECN_NoticeId)
                .Index(t => t.ICN_NoticeId)
                .Index(t => t.ITN_NoticeId)
                .Index(t => t.MHN_NoticeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AllNotices", "MHN_NoticeId", "dbo.MH_Notice");
            DropForeignKey("dbo.AllNotices", "ITN_NoticeId", "dbo.IT_Notice");
            DropForeignKey("dbo.AllNotices", "ICN_NoticeId", "dbo.IC_Notice");
            DropForeignKey("dbo.AllNotices", "ECN_NoticeId", "dbo.EC_Notice");
            DropForeignKey("dbo.AllNotices", "CHN_NoticeId", "dbo.CH_Notice");
            DropForeignKey("dbo.AllNotices", "CEN_NoticeId", "dbo.CE_Notice");
            DropIndex("dbo.AllNotices", new[] { "MHN_NoticeId" });
            DropIndex("dbo.AllNotices", new[] { "ITN_NoticeId" });
            DropIndex("dbo.AllNotices", new[] { "ICN_NoticeId" });
            DropIndex("dbo.AllNotices", new[] { "ECN_NoticeId" });
            DropIndex("dbo.AllNotices", new[] { "CHN_NoticeId" });
            DropIndex("dbo.AllNotices", new[] { "CEN_NoticeId" });
            DropTable("dbo.AllNotices");
        }
    }
}
