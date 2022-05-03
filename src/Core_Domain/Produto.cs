using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core_Domain
{
    public class Produto
    {
        [Column("PRD_Id")]
        public int Id { get; set; }

        [Column("PRD_DataCadastro")]
        public DateTime DataCadastro { get; set; }
        [Column("PRD_Nome")]
        public string Nome { get; set; }
        [Column("PRD_Valor")]
        public decimal Valor { get; set; }
        [Column("PRD_Quantidade")]
        public int Quantidade { get; set; }
        [Column("PRD_Status")]
        public int Status { get; set; }
    }
}
