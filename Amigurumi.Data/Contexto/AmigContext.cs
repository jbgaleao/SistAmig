using Amigurumi.Web.Models;
using System.Data.Entity;

namespace Amigurumi.Data.Contexto
{
    public class AmigContext : DbContext
    {
        public AmigContext() : base("AmigConn")
        {

        }

        public DbSet<Usuario> USUARIOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());
        }
    }
}
