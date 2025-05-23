﻿using Microsoft.EntityFrameworkCore;

namespace VagasApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vaga>? Vagas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
