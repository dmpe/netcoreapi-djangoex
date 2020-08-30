using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace SelfMadeDB.Controllers {
    public class SelfMadeDBContext : DbContext {
        public SelfMadeDBContext()
        {
        }

        public SelfMadeDBContext(DbContextOptions<SelfMadeDBContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            // .UseNpgsql(Configuration.GetConnectionString("DBProd"))
            .UseNpgsql(Environment.GetEnvironmentVariable("DATABASE_URL_MAUVE_URL"))
            .UseSnakeCaseNamingConvention();
    }
}