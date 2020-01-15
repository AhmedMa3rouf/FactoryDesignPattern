using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    enum CreditCardType
    {
        MoneyBack, Titanuim, Platinum

    }
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard m_CreditCard = null;
            Console.WriteLine("Please Choose your credit card type (0,1,2)");
            CreditCardType x = (CreditCardType) Enum.Parse(typeof(CreditCardType),Console.ReadLine());
            switch (x)
            {
                case CreditCardType.MoneyBack:
                    m_CreditCard = new MoneyBack();
                    break;
                case CreditCardType.Titanuim:
                    m_CreditCard = new Titanium();
                    break;
                case CreditCardType.Platinum:
                    m_CreditCard = new Platinum();
                    break;
                default:
                    break;
            }

            Console.WriteLine("First Without use Factory Design Patterns");
            Console.WriteLine("");
            Console.WriteLine($"Card Type is {m_CreditCard?.GetCardType() ?? "Invalid card"}");
            Console.WriteLine($"Credit Limit is {m_CreditCard?.GetCreditLimit() ?? 0}");
            Console.WriteLine($"Annual Charge is {m_CreditCard?.GetAnnualCharge() ?? 0}");

            Console.WriteLine("");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");

            Console.WriteLine("Second Use Factory Design Patterns");
            Console.WriteLine("");
            ICreditCard creditCardFactory = CreditCardFactory.GetCreditCard(x);

            if (x== CreditCardType.MoneyBack)
                ((MoneyBack)creditCardFactory).GetAnnualCharge
            Console.WriteLine($"Card Type is {creditCardFactory?.GetCardType() ?? "Invalid card"}");
            Console.WriteLine($"Credit Limit is {creditCardFactory?.GetCreditLimit() ?? 0}");
            Console.WriteLine($"Annual Charge is {creditCardFactory?.GetAnnualCharge() ?? 0}");

            Console.ReadLine();
        }
    }
}
