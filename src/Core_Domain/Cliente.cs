using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core_Domain
{
    public class Cliente
    {
        [Column("CLI_Id")]
        public int Id { get; set; }

        [Column("CLI_DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("CLI_Nome")]
        public string Nome { get; set; }

        [Column("CLI_Email")]
        public string Email { get; set; }

        [Column("CLI_Status")]
        public int Status { get; set; }

        [Column("CLI_Logradouro")]
        public string Logradouro { get; set; }

        [Column("CLI_Numero")]
        public int Numero { get; set; }

        [Column("CLI_Bairro")]
        public string Bairro { get; set; }

        [Column("CLI_Cidade")]
        public string Cidade { get; set; }

        [Column("CLI_Uf")]
        public string Uf { get; set; }

        [Column("CLI_Complemento")]
        public string Complemento { get; set; }
    }
}
