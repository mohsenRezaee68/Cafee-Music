using CommentManagement.Domain.ContactAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicManagement.Domain.MusicAgg;

namespace CommentManagement.Infrastructure.EFCore.Mapping
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Etelaat).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Matn).HasMaxLength(10000).IsRequired();
           
        }
    }
}
