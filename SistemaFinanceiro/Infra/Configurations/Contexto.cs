using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Entities;

namespace SistemaFinanceiro.Infra.Configurations;

public class Contexto : IdentityDbContext<ApplicationUser>
{
    public Contexto(DbContextOptions options): base(options)
    {
    }

    public DbSet<SistemaFinanceiroo> SistemaFinanceiro {get; set;}
    public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro {get; set;}
    public DbSet<Despesa> Despesa {get; set;}
    public DbSet<Categoria> Categoria {get; set;}
}