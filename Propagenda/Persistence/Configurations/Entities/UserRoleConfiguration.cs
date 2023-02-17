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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "279fc88b-0a5e-4bec-b074-eee865a0c9ae"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "047a1feb-b527-43af-8194-f1e3c92b7607"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "ed742fb6-87ff-40a9-a30b-717211f5d456"
                }
            );
        }
    }
}
