// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Album.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
#nullable disable

namespace Album.Data.Models
{
    public partial class ChinookContext : DbContext
    {
        public ChinookContext()
        {
        }

        public ChinookContext(DbContextOptions<ChinookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistAlbumTracks> ArtistAlbumTracks { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<Track> Track { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            modelBuilder.Entity<ArtistAlbumTracks>().ToView(nameof(ArtistAlbumTracks)).HasNoKey();

            //modelBuilder.ApplyConfiguration(new Configurations.AlbumConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ArtistConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.ArtistAlbumTracksConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.GenreConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.InvoiceConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.InvoiceLineConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.MediaTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.PlaylistConfiguration());
            //modelBuilder.ApplyConfiguration(new Configurations.TrackConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
