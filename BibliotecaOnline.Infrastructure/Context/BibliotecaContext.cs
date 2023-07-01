using BibliotecaOnline.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BibliotecaOnline.Infrastructure.Context
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=BOTELHO\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=true;TrustServerCertificate=true");
        }
    }
}
