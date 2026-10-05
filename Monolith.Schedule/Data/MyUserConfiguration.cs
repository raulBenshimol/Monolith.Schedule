using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monolith.Schedule.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monolith.Schedule
{
    internal class MyUserConfiguration : IEntityTypeConfiguration<MyUser>
    {
        public void Configure(EntityTypeBuilder<MyUser> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            //builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Passwor).HasMaxLength(100);


        }

   
    }
}
