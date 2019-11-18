using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContractLoader.DbModel
{
    public class Contract
    {
        [Key]
        public string contractCode { get; set; }

        public string phaseOfContract { get; set; }
        public Amount originalAmount { get; set; }
        public Amount installmentAmount { get; set; }
        public Amount currentBalance { get; set; }
        public Amount overdueBalance { get; set; }
        public DateTime dateOfLastPayment { get; set; }
        public DateTime nextPaymentDate { get; set; }
        public DateTime dateAccountOpened { get; set; }
        public DateTime realEndDate { get; set; }

        public virtual ICollection<Individual> individuals { get; set; } = new List<Individual>();

        public virtual ICollection<SubjectRole> subjectRoles { get; set; } = new List<SubjectRole>();
    }
}
