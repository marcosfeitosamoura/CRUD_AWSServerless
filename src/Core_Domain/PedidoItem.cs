using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core_Domain
{
    public class PedidoItem
    {
        [Column("PEDI_Id")]
        public int Id { get; set; }
        [Column("PEDI_PED_Id")]
        public int PedidoId { get; set; }
        [Column("PEDI_PRD_Id")]
        public int ProdutoId { get; set; }
        [Column("PEDI_Quantidade")]
        public int Quantidade { get; set; }
        [Column("PEDI_Valor_Unitario")]
        public decimal ValorUnitario { get; set; }
        [Column("PEDI_Valor_Total")]
        public decimal ValorTotal { get; set; }

        [NotMapped]
        public Pedido Pedido { get; set; }
        
        [NotMapped]
        public Produto Produto { get; set; }
    }
}
