using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired() .HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar (50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar (15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar (50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar (50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    Id=1,
                    UserName = "admin",
                    Email = "admin@etcaret.io",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Test",
                    Password = "123456*",
                    Surname = "User",
                    UserGuid = new Guid("6d3b6f8e-df50-4d35-87e4-9d6e4ec1174a"),
                    CreateDate = new DateTime(2025, 6, 19, 13, 49, 44, 170, DateTimeKind.Local).AddTicks(6257),


                }
                );
        }
    }
}
