using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using LT_Lavagens.Modelos;
using Xamarin.Forms;

namespace LT_Lavagens.Banco
{
    class DataBase
    {
        private SQLiteConnection _conexao;

        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<CadastroEmpresa>();
            _conexao.CreateTable<CadastroPessoa>();
        }

        public List<CadastroPessoa> Consulta()
        {
            return _conexao.Table<CadastroPessoa>().ToList();
        }
        public List<CadastroPessoa> Pesquisa(string palavra)
        {
            return _conexao.Table<CadastroPessoa>().Where(a => a.Nome.Contains(palavra)).ToList();
        }

        public CadastroPessoa ObteVagaPorId(int id)
        {
            return _conexao.Table<CadastroPessoa>().Where(a => a.id == id).FirstOrDefault();
        }

        public void Cadastra(CadastroPessoa cadastroPessoa)
        {
            _conexao.Insert(cadastroPessoa);
        }

        public void Atualizacao(CadastroPessoa cadastroPessoa)
        {
            _conexao.Update(cadastroPessoa);
        }

        public void Exclusao(CadastroPessoa cadastroPessoa)
        {
            _conexao.Delete(cadastroPessoa);
        }
        public List<CadastroEmpresa> Consultar()
        {
            return _conexao.Table<CadastroEmpresa>().ToList();
        }
        public List<CadastroEmpresa> Pesquisar(string palavra)
        {
            return _conexao.Table<CadastroEmpresa>().Where(a => a.NomeEmpresa.Contains(palavra)).ToList();
        }

        public CadastroEmpresa ObterVagaPorId(int id)
        {
            return _conexao.Table<CadastroEmpresa>().Where(a => a.Id == id).FirstOrDefault();
        }

        public void Cadastro(CadastroEmpresa cadastro_Empresa)
        {
            _conexao.Insert(cadastro_Empresa);
        }

        public void Atualizacao(CadastroEmpresa cadastro_Empresa)
        {
            _conexao.Update(cadastro_Empresa);
        }

        public void Exclusao(CadastroEmpresa cadastro_Empresa)
        {
            _conexao.Delete(cadastro_Empresa);
        }
    }
}
