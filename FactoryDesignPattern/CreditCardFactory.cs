using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CreditCardType creditCardType)
        {
            ICreditCard creditCard = null;
            switch (creditCardType)
            {
                case CreditCardType.MoneyBack:
                    creditCard = new MoneyBack();
                    break;
                case CreditCardType.Titanuim:
                    creditCard = new Titanium();
                    break;
                case CreditCardType.Platinum:
                    creditCard = new Platinum();
                    break;
                default:
                    break;
            }
            return creditCard;
        }
    }
}
