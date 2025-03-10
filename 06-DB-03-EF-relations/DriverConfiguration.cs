using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DB_03_EF_relations
{
    class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Drivers");
            builder.HasKey(d => d.Id);

            //builder.HasOne(d => d.Car) //pro lazy loading
            //   .WithMany()
            //   .HasForeignKey(d => d.CarId);
            builder.HasOne(d => d.Car)
                .WithOne(c => c.Driver) // Explicitně definujeme 1:1 vztah
                .HasForeignKey<Driver>(d => d.CarId);
        }
    }
}
