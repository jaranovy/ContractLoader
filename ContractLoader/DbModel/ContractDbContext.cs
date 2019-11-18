using System.Data.Entity;

namespace ContractLoader.DbModel
{
    class ContractDbContext : DbContext
    {
        public ContractDbContext() : base("name=ContractDb")
        {
            Database.SetInitializer<ContractDbContext>(null);
        }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<Individual> individuals { get; set; }
        public DbSet<IdentificationNumber> identificationNumbers { get; set; }
        public DbSet<SubjectRole> subjectRoles { get; set; }
    }
}
