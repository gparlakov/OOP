using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        /// <summary>
        /// Withdraws sum from account if sum > 0 and sum < account.balance
        /// </summary>
        /// <param name="sum"></param>
        public void Withdraw(decimal sum)
        {
            if (this.balance < sum)
            {
                throw new BankException("Balance of this account is less than thew sum you're trying to withdraw.");
            }
            else if (sum < 0)
            {
                throw new BankException("Sum of withdraw can't be negative.");
            }
            else
            {
                this.balance -= sum;
            }
        }

        protected override decimal CalculateInterest(int numberMonths, decimal interestRate)
        {
            if (this.balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberMonths, interestRate);
            }
        }
    }
}
