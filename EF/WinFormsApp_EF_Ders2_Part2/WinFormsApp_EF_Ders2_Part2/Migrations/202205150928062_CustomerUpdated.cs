namespace WinFormsApp_EF_Ders2_Part2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Description", c => c.String(maxLength: 17));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Description");
        }
    }
}
