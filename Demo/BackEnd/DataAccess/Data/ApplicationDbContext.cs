using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().Property(x => x.Preco).HasPrecision(10, 2);
            modelBuilder.Entity<Compra>().Property(x => x.Valor).HasPrecision(10, 2);

            var listaLivros = new Livro[]
            {
                new Livro{ Id= 1, Titulo= "Harry Potter e a pedra filosofal", Autor= "J. K. Rowling", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) },
                new Livro{ Id= 2, Titulo= "O nevoeiro", Autor= "Stephen King", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) },
                new Livro{ Id= 3, Titulo= "Layla", Autor= "Colleen Hover", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) },
                new Livro{ Id= 4, Titulo= "Verity", Autor= "Collen Hover", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) },
                new Livro{ Id= 5, Titulo= "O vôo dos anjos", Autor= "Michael Conelly", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) },
                new Livro{ Id= 6, Titulo= "Contagio criminoso", Autor= "Patricia Cornwell", Capa= "", Preco= 32.75m,  Lançamento= new DateTime(2000, 3, 14) }
            };

            modelBuilder.Entity<Livro>().HasData(listaLivros);
        }
    }
}
