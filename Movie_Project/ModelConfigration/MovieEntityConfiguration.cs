using Movie_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticDotNet.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StaticDotNet.EntityFrameworkCore.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Movie_Project.ModelConfigration
{
    public abstract class EntityTypeConfiguration<TEntity>
       where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
            where TEntity : class
        {
            configuration.Map(modelBuilder.Entity<TEntity>());
        }
    }
}

