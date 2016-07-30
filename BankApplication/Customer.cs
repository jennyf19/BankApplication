using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //[Index...] makes the EmailAddress unique. Unique behind the scenes is constructing a tree...
        //[Index] is like the index at the back of a book
        //[Index("name", order (1st index), IsUnique = true)]
        //[Index("IX_EmailAddress", 1, IsUnique = true)]
        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public int SSN { get; set; }

        #endregion
    }
}
