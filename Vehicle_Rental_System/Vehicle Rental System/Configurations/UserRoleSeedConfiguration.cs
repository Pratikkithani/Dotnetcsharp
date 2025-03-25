using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Vehicle_Rental_System.Configurations
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                    UserId = "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f"
                });

        }
    }
}
