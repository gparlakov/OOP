namespace Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount()
            : base()
        {
        }

        /// <summary>
        /// Constructor for LoanAccount
        /// </summary>
        /// <param name="customer">Customer instance</param>
        /// <param name="balance">How much</param>
        /// <param name="interest">Mothly Interest rate in %</param>
        public LoanAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public override decimal CalculateInterest(int numberMonths)
        {
            if (this.customer.CustomerType == CustomerType.Individual)
            {
                numberMonths -= 3;
            }
            if (this.customer.CustomerType == CustomerType.Institution)
            {
                numberMonths -= 2;
            }
            if (numberMonths <= 0)
            {
                int numberMoths = 2;
                if (this.customer.CustomerType == CustomerType.Individual)
                {
                    numberMonths = 3;   
                }
                throw new BankException(string.Format("For this type of customer iterest rate can be calculated for {0} moths or more",numberMonths));
            }
            return this.Interest * numberMonths * this.Balance / 100;
        }
    }
}
