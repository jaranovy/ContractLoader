using System.ComponentModel.DataAnnotations;

namespace ContractLoader.DbModel
{
    public class IdentificationNumber
    {
        [Key]
        public string nationalID { get; set; }

        public Individual individual { get; set; }
    }
}
