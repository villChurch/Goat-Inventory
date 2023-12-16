using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GoatInventory.Models;

public partial class GoatInventoryContext : DbContext
{
    public GoatInventoryContext()
    {
    }

    public GoatInventoryContext(DbContextOptions<GoatInventoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Goat> Goats { get; set; }

    public virtual DbSet<HealthEvent> HealthEvents { get; set; }

    public virtual DbSet<Kidding> Kiddings { get; set; }

    public virtual DbSet<Pedigree> Pedigrees { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Goat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("goats_pkey");

            entity.ToTable("goats", "goatinventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alive).HasDefaultValueSql("true");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Sold).HasDefaultValueSql("false");
        });

        modelBuilder.Entity<HealthEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("HealthEvents_pkey");

            entity.ToTable("HealthEvents", "goatinventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventDate).HasColumnName("eventDate");
            entity.Property(e => e.EventText).HasColumnName("eventText");
            entity.Property(e => e.GoatId).HasColumnName("goatId");
        });

        modelBuilder.Entity<Kidding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Kidding_pkey");

            entity.ToTable("Kidding", "goatinventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.GoatId).HasColumnName("goatId");
            entity.Property(e => e.does).HasDefaultValue(0);
            entity.Property(e => e.bucks).HasDefaultValue(0);
        });

        modelBuilder.Entity<Pedigree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pedigree_pkey");

            entity.ToTable("Pedigree", "goatinventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dd).HasColumnName("DD");
            entity.Property(e => e.Ds).HasColumnName("DS");
            entity.Property(e => e.GoatId).HasColumnName("goatId");
            entity.Property(e => e.Sd).HasColumnName("SD");
            entity.Property(e => e.Ss).HasColumnName("SS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
