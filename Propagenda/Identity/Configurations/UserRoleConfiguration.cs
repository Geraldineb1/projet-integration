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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "8baaf0ce-bcf9-46b9-ac86-a16040b6c487"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "6987522e-758b-403b-88b7-0c362a353ba7"
                }
            );
        }
    }
}
