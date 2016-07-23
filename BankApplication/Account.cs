using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{   //creating class 
    public class Account
    {
        #region Variables

        private decimal balance;
        #endregion


        #region Static
        //region for static members. the memory is stored seperately
        //private static int lastId = 0;

        #endregion

        #region Properties
        [Key]
        //these are instance members
        public int Id { get; private set; }

        public string Name { get; set; }

        public decimal Balance
        {
            get
            { return balance; }
            private set
            {
                if (value >= 0)
                { balance = value;}
            }
        }

        public AccountTypes TypeOfAccount { get; set; }
        //now, use can select TypeOfAccount from the enum list in AccountTypes
        
        public virtual Customer Customer { get; set; }

        #endregion

        #region Constructor

        public Account()
        {
            //Id = ++lastId;
            Balance = 300;
        }

        #endregion

        #region Methods
        //Deposit money into account
        //<para name = amount> amount to be deposited
        public void Deposit(decimal amount)
        {
            Balance += amount;

        }

        public void Withdrawl(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
        }

        #endregion
    }
}
