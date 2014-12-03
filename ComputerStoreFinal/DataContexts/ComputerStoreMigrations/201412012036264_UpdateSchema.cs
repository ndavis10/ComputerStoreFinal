namespace ComputerStoreFinal.DataContexts.ComputerStoreMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSchema : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Parts", "ModelNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Parts", "ModelNumber", c => c.Int(nullable: false));
        }
    }
}
