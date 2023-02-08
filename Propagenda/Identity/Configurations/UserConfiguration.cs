
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                 new ApplicationUser
                 {
                     Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Admin",
                     UserName = "admin@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestAdmin!"),
                     EmailConfirmed = true
                 },
                 new ApplicationUser
                 {
                     Id = "8baaf0ce-bcf9-46b9-ac86-a16040b6c487",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "User",
                     UserName = "user@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestEmployee!"),
                     EmailConfirmed = true
                 },
                 new ApplicationUser
                 {
                     Id = "6987522e-758b-403b-88b7-0c362a353ba7",
                     Email = "clien@localhost.com",
                     NormalizedEmail = "CLIENT@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Client",
                     UserName = "client@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "CLIENT@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestClient!"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}
