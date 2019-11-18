using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractLoader.DbModel
{
    public class Individual
    {
        [Key]
        [Column(Order = 1)]
        public string CustomerCode { get; set; }
        [Key]
        [Column(Order = 2)]
        public string contractCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<IdentificationNumber> identificationNumbers = new List<IdentificationNumber>();
    }
}
