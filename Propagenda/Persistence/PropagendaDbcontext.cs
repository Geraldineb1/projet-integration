using Application.Persistence.Contracts;
using Domain;
using Domain.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PropagendaDbContext : IdentityDbContext<ApplicationUser>
    {
        public PropagendaDbContext(DbContextOptions<PropagendaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PropagendaDbContext).Assembly);

            /*modelBuilder.Entity<Ticket>(Entity =>
            {
                Entity.ToTable("Tickets");
                Entity.HasOne(t => t.TicketReservation).WithMany(tr => tr.Tickets).HasForeignKey("TicketReservationId").OnDelete(DeleteBehavior.ClientSetNull);
            });*/

            modelBuilder.Entity<ServiceServiceReservation>().HasKey(ssr => new {ssr.ServicesId, ssr.ServiceReservationsId});

            modelBuilder.Entity<ServiceServiceReservation>().HasOne<Service>(ssr => ssr.Service).WithMany(s => s.SSR).HasForeignKey(ssr => ssr.ServicesId);
            modelBuilder.Entity<ServiceServiceReservation>().HasOne<ServiceReservation>(ssr => ssr.ServiceReservation).WithMany(s => s.SSR).HasForeignKey(ssr => ssr.ServiceReservationsId);


        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceReservation> ServiceReservations { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketReservation> TicketReservations { get; set; }
        public DbSet<ServiceServiceReservation> ServiceServiceReservation { get; set; }

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

       


    }
}
