// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    // ****************************************************************************************************
    // This is not a commercial licence, therefore only a few tables/views/stored procedures are generated.
    // ****************************************************************************************************

    // Country
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country", "dbo");
            builder.HasKey(x => x.Ctyid).HasName("PK_Country").IsClustered();

            builder.Property(x => x.Ctyid).HasColumnName(@"ctyid").HasColumnType("char(2)").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).ValueGeneratedNever();
            builder.Property(x => x.Ctyname).HasColumnName(@"ctyname").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Ctyregid).HasColumnName(@"ctyregid").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Regio).WithMany(b => b.Countries).HasForeignKey(c => c.Ctyregid).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Country_Country");

            // builder.HasIndex(x => x.Ctyname).HasDatabaseName("IX_Country").IsUnique();
        }
    }

}
// </auto-generated>
