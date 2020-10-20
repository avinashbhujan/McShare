namespace McShares.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class McShareModel : DbContext
    {
        // Your context has been configured to use a 'McShareModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'McShares.Models.McShareModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'McShareModel' 
        // connection string in the application configuration file.
        public McShareModel()
            : base("name=McShareEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<RequestDoc> RequestDoc { get; set; }
        public DbSet<Doc_Data> Doc_Data { get; set; }
        public DbSet<DataItem_Customer> DataItem_Customers { get; set; }
        public DbSet<Mailing_Address> Mailing_Addresses { get; set; }
        public DbSet<Contact_Details> Contact_Details { get; set; }
        public DbSet<Shares_Details> Shares_Details { get; set; }
        public DbSet<Error> Errors { get; set; }
    }

}