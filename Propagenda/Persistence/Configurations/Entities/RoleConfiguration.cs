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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                    Name = "Client",
                    NormalizedName = "CLIENT"
                }
                ,
                new IdentityRole
                {
                    Id = "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                    Name = "Provider",
                    NormalizedName = "PROVIDER"
                }
            );
        }
    }
}
