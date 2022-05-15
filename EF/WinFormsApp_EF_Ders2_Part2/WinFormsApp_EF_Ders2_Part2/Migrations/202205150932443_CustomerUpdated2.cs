namespace WinFormsApp_EF_Ders2_Part2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerUpdated2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Description2", c => c.String(maxLength: 170));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Description2");
        }
    }
}
