using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }

        protected override void OnModelCreating(ModelBuilder movieBuilder)
        {
            movieBuilder.Entity<Customer>(ConfigureCustomer);
            movieBuilder.Entity<Room>(ConfigureRoom);
            movieBuilder.Entity<RoomType>(ConfigureRoomType);
            movieBuilder.Entity<RoomService>(ConfigureRoomService);
        }


        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CName).HasMaxLength(50);
            builder.Property(c=>c.Address).HasMaxLength(256);
            builder.Property(c => c.Phone).HasMaxLength(20);
            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.Email).HasMaxLength(40);
            
        }

        private void ConfigureRoom(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room");
            builder.HasKey(r => r.Id);
        }

        private void ConfigureRoomType(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RoomType");
            builder.HasKey(rt => rt.Id);
            builder.Property(rt => rt.RTDesc).HasMaxLength(50);
            builder.Property(rt => rt.Rent).HasColumnType("decimal(10, 2)");
        }

        private void ConfigureRoomService(EntityTypeBuilder<RoomService> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(rs => rs.Id);
            builder.Property(rs => rs.SDesc).HasMaxLength(50);
            builder.Property(rs => rs.Amount).HasColumnType("decimal(10, 2)");
            builder.Property(c => c.Advance).HasColumnType("decimal(10, 2)");
        }


    }
}
