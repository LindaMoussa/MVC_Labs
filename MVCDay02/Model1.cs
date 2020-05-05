namespace MVCDay02
{
    using Day2.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
    
        public Model1()
            : base("name=Model1")
        {
        }

        
        public virtual DbSet<User> Users { get; set; }
    }

   
}