using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity
{
    public class PropagendaIdentityDbContextFactory : IDesignTimeDbContextFactory<PropagendaIdentityDbContext>
    {
        public PropagendaIdentityDbContext CreateDbContext(string[] args)
        {
            /*IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();*/

            var builder = new DbContextOptionsBuilder<PropagendaIdentityDbContext>();
            var connectionString = "Server=LHA11301\\SQLROXY;Database=Propagenda2023;Trusted_Connection=True; MultipleActiveResultSets=true";

            builder.UseSqlServer(connectionString);

            return new PropagendaIdentityDbContext(builder.Options);
        }
    }
}
