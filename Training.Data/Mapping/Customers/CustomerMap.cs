using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Training.Model.Customers;

namespace Training.Data.Mapping.Customers
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(p => p.Id).Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FirstName).HasMaxLength(100);
            Property(p => p.LastName).HasMaxLength(100);
            Property(p => p.Email).HasMaxLength(100);
        }
    }
}
