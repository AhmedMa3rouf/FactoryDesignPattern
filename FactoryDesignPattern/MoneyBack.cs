using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class MoneyBack : ICreditCard
    {
        public string MoneyNumber { get; set; } = "1589523";
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Money Back Credit Card";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
