using System;
using System.Linq;

namespace Bank
{
    class MortgageAccount : Account,IInterestCalculatable
    {
        public MortgageAccount()
            : base()
        {
        }

        /// <summary>
        /// Constructor for MortgageAccount
        /// </summary>
        /// <param name="customer">Customer instance</param>
        /// <param name="balance">How much</param>
        /// <param name="interest">Mothly Interest rate in %</param>
        public MortgageAccount(Customer customer, decimal balance, decimal interest)
            :base(customer,balance,interest)
        {
        }

        public override decimal CalculateInterest(int numberMonths)
        {
            decimal interestRate = 0;

            if (numberMonths <= 0)
            {
                throw new BankException("Number of months should be greater than 0");
            }

            if (this.customer.CustomerType == CustomerType.Individual)
            {
                if (numberMonths <= 6)
                {
                    interestRate = 0;
                }
                else
                {
                    interestRate = this.Interest / 100 * this.Balance * (numberMonths - 6);
                }
            }
            else if (this.customer.CustomerType == CustomerType.Institution)
            {
                if (numberMonths <= 12)
                {
                    interestRate = base.CalculateInterest(numberMonths) / 2;
                }
                else
                {
                    interestRate = base.CalculateInterest(12) / 2 + base.CalculateInterest(numberMonths - 12);
                }
            }

            return interestRate;
        }

    }
}
