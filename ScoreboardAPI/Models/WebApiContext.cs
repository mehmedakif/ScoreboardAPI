namespace ScoreboardAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebApiContext : DbContext
    {
        public WebApiContext()
            : base("name=Model13")
        {
        }

        public virtual DbSet<user> user { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
