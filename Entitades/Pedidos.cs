using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace desafioTecnicoAvanadeApi.Entitades
{
    public class Pedidos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        public DateTime DataPedido { get; set; }
        public Clientes ClientePedido { get; set; } = default!;

        public List<Pedidos> ListProdutos { get; set; } = [];

    }
}