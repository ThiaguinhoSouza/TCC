using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LT_Lavagens.Modelos
{
    [Table("Pessoas")]
    public class CadastroPessoa
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int CPF { get; set; }
    }
}
