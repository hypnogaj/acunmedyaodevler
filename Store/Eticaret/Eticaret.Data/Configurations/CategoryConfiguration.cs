using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(50);
            builder.HasData(
                new Category
                {
                    Name ="Elektronik",
                    Id = 1,
                    IsActive = true,
                    IsTopMenu = true,
                    ParentId = 0,
                    OrderNo = 1,
                    CreateDate = new DateTime(2025, 6, 19, 13, 49, 44, 170, DateTimeKind.Local).AddTicks(6257),

                },
                new Category
                {
                    Name = "Bilgisayar",
                    Id = 2,
                    IsActive = true,
                    IsTopMenu = true,
                    ParentId = 0,
                    OrderNo = 2,   // virgül koyarak kategorileri arttırabilyosun gerilim bilim kurgu vs
                    CreateDate = new DateTime(2025, 6, 19, 13, 49, 44, 170, DateTimeKind.Local).AddTicks(6257),

                },
                 new Category
                 {
                     Name = "Ev Dekorasyon",
                     Id = 3,
                     IsActive = true,
                     IsTopMenu = true,
                     ParentId = 0,
                     OrderNo = 3,   // virgül koyarak kategorileri arttırabilyosun gerilim bilim kurgu vs
                     CreateDate = new DateTime(2025, 6, 19, 13, 49, 44, 170, DateTimeKind.Local).AddTicks(6257),

                 }
                );
        }
    }
}
