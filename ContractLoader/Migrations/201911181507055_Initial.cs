namespace ContractLoader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        contractCode = c.String(nullable: false, maxLength: 128),
                        phaseOfContract = c.String(),
                        originalAmount_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        originalAmount_currency = c.String(),
                        installmentAmount_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        installmentAmount_currency = c.String(),
                        currentBalance_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        currentBalance_currency = c.String(),
                        overdueBalance_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        overdueBalance_currency = c.String(),
                        dateOfLastPayment = c.DateTime(nullable: false),
                        nextPaymentDate = c.DateTime(nullable: false),
                        dateAccountOpened = c.DateTime(nullable: false),
                        realEndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.contractCode);
            
            CreateTable(
                "dbo.Individuals",
                c => new
                    {
                        CustomerCode = c.String(nullable: false, maxLength: 128),
                        contractCode = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.CustomerCode, t.contractCode })
                .ForeignKey("dbo.Contracts", t => t.contractCode, cascadeDelete: true)
                .Index(t => t.contractCode);
            
            CreateTable(
                "dbo.SubjectRoles",
                c => new
                    {
                        customerCode = c.String(nullable: false, maxLength: 128),
                        contractCode = c.String(nullable: false, maxLength: 128),
                        roleOfCustomer = c.String(),
                        guaranteeAmount_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        guaranteeAmount_currency = c.String(),
                    })
                .PrimaryKey(t => new { t.customerCode, t.contractCode })
                .ForeignKey("dbo.Contracts", t => t.contractCode, cascadeDelete: true)
                .Index(t => t.contractCode);
            
            CreateTable(
                "dbo.IdentificationNumbers",
                c => new
                    {
                        nationalID = c.String(nullable: false, maxLength: 128),
                        individual_CustomerCode = c.String(maxLength: 128),
                        individual_contractCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.nationalID)
                .ForeignKey("dbo.Individuals", t => new { t.individual_CustomerCode, t.individual_contractCode })
                .Index(t => new { t.individual_CustomerCode, t.individual_contractCode });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentificationNumbers", new[] { "individual_CustomerCode", "individual_contractCode" }, "dbo.Individuals");
            DropForeignKey("dbo.SubjectRoles", "contractCode", "dbo.Contracts");
            DropForeignKey("dbo.Individuals", "contractCode", "dbo.Contracts");
            DropIndex("dbo.IdentificationNumbers", new[] { "individual_CustomerCode", "individual_contractCode" });
            DropIndex("dbo.SubjectRoles", new[] { "contractCode" });
            DropIndex("dbo.Individuals", new[] { "contractCode" });
            DropTable("dbo.IdentificationNumbers");
            DropTable("dbo.SubjectRoles");
            DropTable("dbo.Individuals");
            DropTable("dbo.Contracts");
        }
    }
}
