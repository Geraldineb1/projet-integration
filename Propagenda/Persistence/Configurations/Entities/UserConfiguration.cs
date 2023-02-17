
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                 new ApplicationUser
                 {
                     Id = "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Admin",
                     UserName = "admin@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestAdmin2023!"),
                     EmailConfirmed = true
                 },
                 new ApplicationUser
                 {
                     Id = "047a1feb-b527-43af-8194-f1e3c92b7607",
                     Email = "employee@localhost.com",
                     NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Employee",
                     UserName = "employee@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "EMPLOYEE@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestEmployee2023!"),
                     EmailConfirmed = true
                 },
                 new ApplicationUser
                 {
                     Id = "ed742fb6-87ff-40a9-a30b-717211f5d456",
                     Email = "clien@localhost.com",
                     NormalizedEmail = "CLIENT@LOCALHOST.COM",
                     FirstName = "System",
                     LastName = "Client",
                     UserName = "client@localhost.com",
                     Address = "rue de la paix 25",
                     NormalizedUserName = "CLIENT@LOCALHOST.COM",
                     PasswordHash = hasher.HashPassword(null, "TestClient2023!"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}
