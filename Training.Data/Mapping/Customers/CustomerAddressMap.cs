using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Training.Model.Customers;

namespace Training.Data.Mapping.Customers
{
    public class CustomerAddressMap : EntityTypeConfiguration<CustomerAddress>
    {
        public CustomerAddressMap()
        {
            ToTable("CustomerAddress");
            HasKey(p => p.Id).Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.AddressLine1).HasMaxLength(100);
            Property(p => p.AddressLine2).HasMaxLength(100);
            Property(p => p.AddressLine3).HasMaxLength(100);
            Property(p => p.Town).HasMaxLength(50);
            Property(p => p.Region).HasMaxLength(50);
            Property(p => p.Country).HasMaxLength(50);

            HasRequired(p => p.Customer)
                .WithMany(c => c.CustomerAddresses)
                .HasForeignKey(p => p.CustomerId);

        }
    }
}
