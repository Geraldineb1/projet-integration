using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations.Entities
{
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        public void Configure(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasData(
                new ServiceType
                {
                    Id = 1, 
                    Label = "Concert",
                    Image = "urlpardefaut"

                },
                new ServiceType
                {
                    Id = 2,
                    Label = "Securité",
                    Image = "urlpardefaut"

                },
                new ServiceType
                {
                    Id = 3,
                    Label = "Technique",
                    Image = "urlpardefaut"

                }
            );
        }
    }
}
