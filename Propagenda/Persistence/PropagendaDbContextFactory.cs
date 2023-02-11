using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PropagendaDbContextFactory : IDesignTimeDbContextFactory<PropagendaDbContext>
    {
        public PropagendaDbContext CreateDbContext(string[] args)
        {
            /*IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();*/

            var builder = new DbContextOptionsBuilder<PropagendaDbContext>();
            var connectionString = "Server=LHA11301\\SQLROXY;Database=Propagenda2023;Trusted_Connection=True; MultipleActiveResultSets=true";

            builder.UseSqlServer(connectionString);

            return new PropagendaDbContext(builder.Options);
        }
    }
}
