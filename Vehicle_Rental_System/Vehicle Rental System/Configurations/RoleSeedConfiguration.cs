using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Vehicle_Rental_System.Configurations
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                },
                 new IdentityRole
                 {
                     Id = "b6cd6215 - b32b - 4bf4 - 4431 - 9f76e595b36f",
                     Name = "User",
                     NormalizedName = "USER"
                 }
                );
        }
    }
}
