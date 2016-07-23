using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public static class Bank
    {
        #region Properties
        public static string Name { get; set; }
        #endregion

        #region Methods

        public static Customer CreateCustomer
            (string name, string emailAddress, string address)
        {
            var customer = new Customer
            {//assign parameter name to property
                Name = name,
                Address = address,
                EmailAddress = emailAddress
            };
            return Customer;
        }
        #endregion 
    }
}
