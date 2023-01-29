using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PropagendaDbContext : DbContext
    {
        public PropagendaDbContext(DbContextOptions<PropagendaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PropagendaDbContext).Assembly);

            modelBuilder.Entity<Service>()
                    .HasMany(t => t.Reservations)
                    .WithMany(t => t.Services)
                    .UsingEntity(j => j.ToTable("ServiceReservationService"));
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                //entry.Entity.Las
                /*if (entry.State == EntityState.Added)
                {
                    

                }*/

            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceReservation> ServiceReservations { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketReservation> TicketReservations { get; set; }


    }
}
