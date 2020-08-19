using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LT_Lavagens.Modelos
{
    [Table("CadastroEmpresas")]
    public class CadastroEmpresa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string PessoaFisica { get; set; }
        public string PessoaJuridica { get; set; }
        public string Descricao { get; set; }
        public string Servicos { get; set; }
    }
}
