using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //instances of the class -> objects
            var account = new Account {Name = "Jenny"};
            //acount.Id =1;
            //account.Name = "Jenny";
            account.Deposit(400);
            account.Withdrawl(200);
            //use () to call the method
            //instance members - performing an action on an object
            //properties store data methods perform action on data
            //account.Balance = 500;

            Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:C}", account.Id, account.Name, account.Balance);

            var account2 = new Account();
            account2.Name = "My savings";
            Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:C}", account2.Id, account2.Name, account2.Balance);
        }
    }
}
