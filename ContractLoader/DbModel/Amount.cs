using System;

namespace ContractLoader.DbModel
{
    public class Amount
    {
        public Decimal value { get; set; }
        public string currency { get; set; }

        public Amount()
        { }

        public Amount(decimal amount, string currency)
        {
            this.value = amount;
            this.currency = currency;
        }

        public override string ToString()
        {
            return String.Format("{0:0.##} {1}", value, currency);
        }
    }
}
