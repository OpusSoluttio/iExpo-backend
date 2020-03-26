using Dominios.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra.Data.Contextos
{
    public class iExpoContext: DbContext
    {
        public DbSet<Sensores> Sensores { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Eventos> Eventos { get; set; }

        public DbSet<Alas> Alas { get; set; }
        public DbSet<Grupos> Grupos { get; set; }


        public iExpoContext()
        {

        }

        public iExpoContext(DbContextOptions<iExpoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Verifica se o contexto já não esta configurado, caso não eseja utiliza a string de conexão abaixo
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-7L7DFBU\\SQLEXPRESS;Initial Catalog=iExpo;Integrated Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuarios>().HasData(
                new Usuarios()
                {
                    Id = 1,
                    Email = "admin@iexpo.com",
                    Senha = "iexpo132"
                }
                );
            base.OnModelCreating(modelBuilder);


        }

    }
}
