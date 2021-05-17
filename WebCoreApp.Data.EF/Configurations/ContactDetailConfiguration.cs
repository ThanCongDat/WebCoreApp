using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCoreApp.Data.EF.Extensions;
using WebCoreApp.Data.Entities;

namespace WebCoreApp.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}