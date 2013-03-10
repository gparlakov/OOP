/*A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage  * accounts. Customers could be individuals or companies.	All accounts have customer, balance and interest rate (monthly based).  * Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.All accounts can calculate their interest amount for a given period (in months). In * the common case its is calculated as follows: number_of_months * interest_rate.Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.Deposit accounts have no interest if their balance is positive and less than 1000.Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, 
 * base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 * 
 */



using System;
using System.Linq;

namespace Bank
{
    class BankTest
    {
        static void Main()
        {
            try
            {
                Customer person = new Customer("Pesho", CustomerType.Individual);
                Customer institution = new Customer("School", CustomerType.Institution);

                DepositAccount depositPerson = new DepositAccount(person, 1500, 0.5m);             
                Console.WriteLine("Deposit account of a person for 12 months gives {0} ",depositPerson.CalculateInterest(12));
                depositPerson.Withdraw(501);
                Console.WriteLine("Deposit account (with balance less than 1000) of a person for 12 months gives {0} \n", depositPerson.CalculateInterest(12));


                Account mortgagePerson = new MortgageAccount(person, 150, 0.6m);
                Account mortgageInstitution = new MortgageAccount(institution, 150, 0.6m);
                Console.WriteLine("Mortgage account of a person for 5 months gives {0} ", mortgagePerson.CalculateInterest(5));// 5 months - no interest
                Console.WriteLine("Mortgage account of a person for 7 months gives {0} \n", mortgagePerson.CalculateInterest(7));// 7 months - gives interest

                Console.WriteLine("Mortgage account of a institution for 5 months gives {0} ", mortgageInstitution.CalculateInterest(5));// 5 months - no interest
                Console.WriteLine("Mortgage account of a institution for 20 months gives {0} \n", mortgageInstitution.CalculateInterest(20));// 20 months- special interest
                

                Account loanInstitution = new LoanAccount(institution, 1000, 0.7m);
                Account loanPerson = new LoanAccount(person, 1000, 0.7m);
                Console.WriteLine("Loan account of a person for 5 months gives {0} ", loanPerson.CalculateInterest(5));// 5 months - no interest
                Console.WriteLine("Loan account of a person for 7 months gives {0} \n", loanPerson.CalculateInterest(7));// 7 months - gives interest
                                   
                Console.WriteLine("Loan account of a institution for 5 months gives {0} ", loanInstitution.CalculateInterest(5));// 5 months - no interest
                Console.WriteLine("Loan account of a institution for 20 months gives {0} ", loanInstitution.CalculateInterest(7));// 7 months- special interest

            }
            catch (BankException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
