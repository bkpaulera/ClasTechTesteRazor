using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasTech.Teste.Business.Entities
{
    public class pedidoItem
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        
    }
}
