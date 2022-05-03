using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core_Domain
{
    public class Pedido
    {
        [Column("PED_ID")]
        public int Id { get; set; }
        
        [Column("PED_DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("PED_CLI_Id")]
        public int ClienteId { get; set; }

        [Column("PED_Quantidade")]
        public int QuantidadeItens { get; set; }
        [Column("PED_Valor")]
        public decimal ValorTotal { get; set; }
        [Column("PED_Status")]
        public int Status { get; set; }

        [NotMapped]
        public List<PedidoItem> PedidoItems { get; set; }
    }
}
