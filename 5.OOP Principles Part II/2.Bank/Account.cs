using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal iterest;        

        protected virtual decimal CalculateInterest(int numberMonths, decimal interestRate)
        {
            return numberMonths * interestRate;
        }

        /// <summary>
        /// Constructor for mother-class
        /// </summary>
        /// <param name="customer">Person or Institution</param>
        /// <param name="balance"></param>
        /// <param name="interest"></param>
        public Account (Customer customer, decimal balance, decimal interest)
        {
            this.customer = customer;
            this.Balance = balance;
            this.Iterest = interest; 
        }

        private decimal Balance
        {
            set
            {
                if (value < 0)
                {
                    throw new BankException("Ammount of money in a newly created account can't be negative!");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        private decimal Iterest
        {
            set
            {
                if (value < 0)
                {
                    throw new BankException("Interest can't be negative!");
                }
                else
                {
                    this.iterest = value;
                }
            }
        }

        /// <summary>
        /// Deposin non-negative ammount in accound
        /// </summary>
        /// <param name="sum"></param>
        public virtual void Deposit(decimal sum)
        {
            if (sum < 0)
            {
                throw new BankException("Deposit ammount can't be < 0 (equals Withdrawal).");
            }
            else
            {
                this.balance += sum;
            }
        }        
      
    }
}
