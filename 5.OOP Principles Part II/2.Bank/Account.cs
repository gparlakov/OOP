namespace Bank
{
    public abstract class Account : IInterestCalculatable
    {
        protected Customer customer;
        private decimal balance;
        private decimal interest;      
                
        public Account()
        {
        }

        /// <summary>
        /// Constructor for mother-class
        /// </summary>
        /// <param name="customer">Customer instance</param>
        /// <param name="balance">How much</param>
        /// <param name="interest">Mothly Interest rate in %</param>
        public Account(Customer customer, decimal balance, decimal interest)
            :this()
        {
            this.customer = customer;
            this.Balance = balance;
            this.Interest = interest;             
        }

        /// <summary>
        /// Changes the Balance of this account. Only child classes have access to change it
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
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

        /// <summary>
        /// Sets and gets the montly interest rate in % for this account. Only child classes have access to change it
        /// </summary>
        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new BankException("Interest can't be negative!");
                }
                else
                {
                    this.interest = value;
                }
            }
        }

        /// <summary>
        /// Deposit non-negative ammount in account
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

        //the mother method which is overloaded in the child-classes 
        public virtual decimal CalculateInterest(int numberMonths)
        {
            return this.Interest / 100 * numberMonths * this.Balance;
        }
    }
  
    
  
    
}
