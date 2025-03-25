using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    { 
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData(

                new User
                {
                    Id = "b6cd6262 - b32b - 4bf4 - 8e79 - 9f76e595b36f",
                    UserName = "adminlogin@gmail.com",
                    NormalizedUserName = "ADMINLOGIN@GMAIL.COM",
                    Email = "adminlogin@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Admin@123456"),

                });

            //b6cd6215 - b32b - 4bf4 - 8e79 - 9f76e595b36f
        }
    }
}
