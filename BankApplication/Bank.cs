using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public enum AccountTypes
    {
        //by default enums are static
        //each enums have an integer value assigned by C# 0-3
        Checking = 1,
        Savings = 2,
        Cd = 4,
        Loan = 8
    }
    public static class Bank
    {
        
       #region Properties
        public static string Name { get; set; }
        #endregion

        #region Methods

        public static Customer CreateCustomer
            (string name, string emailAddress, string address)
        {
            return CreateCustomer(name, emailAddress, address, "Default Checking Account", AccountTypes.Checking);
        }

        /*var customer = new Customer
            {//assign parameter name to property
                Name = name,
                Address = address,
                EmailAddress = emailAddress
            };
            var db = new BankModel();
            //just made a connection to the database
            db.Customers.Add(customer);
            //in the db, add a customer to the Customer table
            db.SaveChanges();
            //saves the changes to the db
            db.Dispose();

            CreateAccount("Default checking account", AccountTypes.Checking, customer);
            //close the db, but since it's a local variable, it will close at the end of this method
            return customer;*/
        
        //overloaded method - same name as other method, but different parameters
        public static Customer CreateCustomer
            (string name, string emailAddress, string address, string accountName, AccountTypes typeOfAccount)
    { 

        var customer = new Customer
                {//assign parameter name to property
                    Name = name,
                    Address = address,
                    EmailAddress = emailAddress
                };
                var db = new BankModel();
                //just made a connection to the database
                db.Customers.Add(customer);
                //in the db, add a customer to the Customer table
                db.SaveChanges();
                //saves the changes to the db
                db.Dispose();

                CreateAccount("Default checking account", AccountTypes.Checking, customer);
                //close the db, but since it's a local variable, it will close at the end of this method
                return customer;
            
        }

        public static Account CreateAccount(string accountName, AccountTypes typeOfAccount, Customer customer)
        {
            var account = new Account
            {
                Name = accountName,
                TypeOfAccount = typeOfAccount,
                Customer = customer,
            };
            var db = new BankModel();
            db.Accounts.Add(account);
            db.SaveChanges();
            db.Dispose();

            return account;
        }

        public static IEnumerable<Account> 
            //bank mantains a collection of accounts
            GetAllAccountsByCustomerEmail(string emailAddress)
            //ennumeration of account, allows anyone with interface to enumerate through account
        {
            var db = new BankModel();
            var customer = db.Customers.Where(c => c.EmailAddress == emailAddress).FirstOrDefault();
            //.where is a link and then define the predicate with a lamba expression
            //lamba is a delegate - a function pointer
            //"c" is doing a query on customer table, c is each customer...it will do a "for" loop for each customer
            //FirstOrDefault() means you return the first person or the default if there are none - also a link query
            if (customer == null)
            {
                return null;
            }
            return db.Accounts.Where(a => a.Customer.Id == customer.Id);
        }

        #endregion
    }
}
