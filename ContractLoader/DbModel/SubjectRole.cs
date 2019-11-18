using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ContractLoader.DbModel
{
    public class SubjectRole
    {
        [Key]
        [Column(Order = 1)]
        public string customerCode { get; set; }
        [Key]
        [Column(Order = 2)]
        public string contractCode { get; set; }
        public string roleOfCustomer { get; set; }
        public Amount guaranteeAmount { get; set; }
    }
}
