using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Data
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Moderator> Moderator { get; set; }
        public DbSet<Posjetilac> Posjetilac { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Korisnik>()
        //        .HasKey(k => k.Id);

        //    modelBuilder.Entity<Korisnik>()
        //        .HasOne<Posjetilac>(s => s.Posjetilac)
        //        .WithOne(ad => ad.Korisnik)
        //        .HasForeignKey<Posjetilac>(ad => ad.KorisnikID);
           
        //    modelBuilder.Entity<Korisnik>()
        //        .HasOne<Administrator>(s => s.Administrator)
        //        .WithOne(ad => ad.Korisnik)
        //        .HasForeignKey<Administrator>(ad => ad.KorisnikID);

        //    modelBuilder.Entity<Korisnik>()
        //        .HasOne<Moderator>(s => s.Moderator)
        //        .WithOne(ad => ad.Korisnik)
        //        .HasForeignKey<Moderator>(ad => ad.KorisnikID);
        //}
    }
}
