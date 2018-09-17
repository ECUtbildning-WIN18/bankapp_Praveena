using ConsoleApp1.Domain;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person( "Praveena", "S", 12345 );
            Person P2 = new Person("Emma", "M" , 67891);
            Account A1 = new Account(8091, 10000, P1);
            Account A2 = new Account(5789, 15000, P2);
            Creditcard C1 = new Creditcard(5000, P1, 350, 12345678,A1);
            C1.Pay(A1, 6000);
            A2.Withdraw(6000);
            A1.Deposit(6000);
            Console.WriteLine(A1.Balance);
            Console.WriteLine(A2.Balance);


        }
    }
}
