namespace Bank
{
    public class DepositAccount : Account
    {
        public DepositAccount()
            : base()
        {

        }

        /// <summary>
        /// Constructor for DepositAccount
        /// </summary>
        /// <param name="customer">Customer instance</param>
        /// <param name="balance">How much</param>
        /// <param name="interest">Mothly Interest rate in %</param>
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
            if (this.Balance < sum)
            {
                throw new BankException("Balance of this account is less than thew sum you're trying to withdraw.");
            }
            else if (sum < 0)
            {
                throw new BankException("Sum of withdraw can't be negative.");
            }
            else
            {
                this.Balance -= sum;
            }
        }

        public override decimal CalculateInterest(int numberMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberMonths);
            }
        }
    }
}
