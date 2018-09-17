using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Domain
{
    class Creditcard
    {
        public double Limit { get; set; }
        public Account Account { get; }
        public int Csvcode { get; }
        public int CreditCardNumber { get; }
        public Person Person { get; set; }
        
        public Creditcard(double limit, Person person, int csv, int creditCardNumber, Account account)
        {
            Limit = limit;            
            Csvcode = csv;
            CreditCardNumber = creditCardNumber;
            Person = person;
            Account = account;
        }


        public void Pay(Account receiversaccount,int amount)
        {
            Account.Withdraw(amount);
            receiversaccount.Deposit(amount);
        }
    }
}
