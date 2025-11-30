using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafioTecnicoAvanadeApi.Entitades
{
    public class Produtos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        public string Descricao { get; set; } = default!;

        public float Preco { get; set; } = default!;

        public int Estoque { get; set; } = default!;
    }
}