namespace WinFormsApp_EF_Ders2_Part2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerUpdated3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Description");
            DropColumn("dbo.Customers", "Description2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Description2", c => c.String(maxLength: 170));
            AddColumn("dbo.Customers", "Description", c => c.String(maxLength: 17));
        }
    }
}
