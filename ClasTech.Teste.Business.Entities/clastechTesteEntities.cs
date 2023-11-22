
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ClasTech.Teste.Business.Entities
{
    public partial class clastechTesteEntities : DbContext
    {
        public clastechTesteEntities()
            : base("name=clastechTesteEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<pedido> pedido { get; set; }

        public virtual DbSet<pedido> pedidoItem { get; set; }
    }
}
