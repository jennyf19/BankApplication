namespace BankApplication
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BankModel : DbContext
    {   //instantiate the bankmodel - create it
        // Your context has been configured to use a 'bankModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BankApplication.bankModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'bankModel' 
        // connection string in the application configuration file.
        public BankModel()
            : base("name=bankModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}