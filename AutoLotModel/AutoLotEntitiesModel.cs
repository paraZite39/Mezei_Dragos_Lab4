namespace AutoLotModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutoLotEntitiesModel : DbContext
    {
        public AutoLotEntitiesModel()
            : base("name=AutoLotEntitiesModel")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Contract_value)
                .HasPrecision(6, 2);
        }
    }
}
