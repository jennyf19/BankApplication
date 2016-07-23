using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Customer
    {

        #region Properties
        [Key]
        public int Id { get; set; }
        //sets the string length to max of 250
        [StringLength(250)]


        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }
        #endregion
    }
}
