namespace NTLA1721050223.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creat_Table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 20, unicode: false),
                        PersonName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 20),
                        PersonName = c.String(nullable: false, maxLength: 50),
                        University = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.Person");
        }
    }
}
