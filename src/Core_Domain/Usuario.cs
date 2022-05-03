using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core_Domain.Interface
{
    public class Usuario
    {
        [Column("USUA_Id")]
        public int Id { get; set; }

        [Column("USUA_Nome")]
        public string Nome { get; set; }

        [Column("USUA_Email")]
        public string Email { get; set; }

        [Column("USUA_Senha")]
        public string Senha { get; set; }

        [Column("USUA_Status")]
        public int Status { get; set; }

        public static string SHA256(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                //UnicodeEncoding UE = new UnicodeEncoding();
                //byte[] HashValue, MessageBytes = UE.GetBytes(valor);
                //SHA256Managed SHhash = new SHA256Managed();
                //string strHex = "";

                //HashValue = SHhash.ComputeHash(MessageBytes);
                //foreach (byte b in HashValue)
                //{
                //    strHex += String.Format("{0:x2}", b);
                //}
                return valor;
            }
            else
                return string.Empty;
        }
    }
}
