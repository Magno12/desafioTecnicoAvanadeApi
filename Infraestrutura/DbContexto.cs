using desafioTecnicoAvanadeApi.Entitades;
using Microsoft.EntityFrameworkCore;

namespace desafioTecnicoAvanadeApi.Infrastrutura
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }

        public DbSet<Clientes> TabelaClientes { get; set; }
        public DbSet<Produtos> TabelaProdutos { get; set; }
        public DbSet<Pedidos> TabelaPedidos { get; set; }
    }
}