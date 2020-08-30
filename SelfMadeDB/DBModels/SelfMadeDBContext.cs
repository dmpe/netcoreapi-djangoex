using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace SelfMadeDB.Controllers {
    public class SelfMadeDBContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseNpgsql(Environment.GetEnvironmentVariable("DATABASE_URL_MAUVE_URL"))
            .UseSnakeCaseNamingConvention();
    }
}