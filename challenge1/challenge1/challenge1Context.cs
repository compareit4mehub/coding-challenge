namespace challenge1
{
    using Models;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Linq;

    public class challenge1Context : DbContext
    {
        // Your context has been configured to use a 'challenge1Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'challenge1.challenge1Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'challenge1Context' 
        // connection string in the application configuration file.
        public challenge1Context()
            : base("name=" + ConfigurationManager.AppSettings["DatabaseName"])
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<challenge1Context>());
        }

        public DbSet<Coinholder> Coinholders { get; set; }

    }
}