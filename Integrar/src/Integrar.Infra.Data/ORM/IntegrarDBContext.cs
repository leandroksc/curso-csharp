using Integrar.Domain.Entities;
using Integrar.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Integrar.Infra.Data.ORM
{
    public class IntegrarDBContext : DbContext
    {
        public IntegrarDBContext(DbContextOptions<IntegrarDBContext> options) : base(options)
        {

        }

        public DbSet<Mural> Mural { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
    }
}
