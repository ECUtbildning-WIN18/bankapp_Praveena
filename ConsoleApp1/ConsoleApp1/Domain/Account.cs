using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Domain
{
    class Account
    {
        public int AccountNumber { get; }
        public int Balance { get; set; }
        public Person Person { get; set; }
        
        public Creditcard Creditcard { get; }

        public Account(int accountnumber, int balance,Person person )
        {
            AccountNumber = accountnumber;
            Balance = balance;
            Person = person;

        }
        public void Withdraw(int amount)
        {
            Balance = Balance - amount;
            
        }
        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }
        
    }
}
