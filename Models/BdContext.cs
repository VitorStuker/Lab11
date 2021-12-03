using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models;

public class BdContext : DbContext
{
    public BdContext()
    {   
    }
    public BdContext (DbContextOptions<BdContext> options)
        : base(options)
    {
    }
    public DbSet<Autor> Autors { get; set; } = null!;
    public DbSet<Livro> Livros { get; set; } = null!;
    public DbSet<Emprestimo> Emprestimos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>()
            .Property(c => c.primeiroNome)
            .IsRequired()
            .HasMaxLength(45);
        modelBuilder.Entity<Autor>()
            .Property(c => c.ultimoNome)
            .IsRequired()
            .HasMaxLength(45);

        modelBuilder.Entity<Livro>()
            .Property(c => c.titulo)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Emprestimo>()
            .Property(e => e.dataRetirada)
            .IsRequired()
            .HasMaxLength(50);
    }
}