using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LT_Lavagens.Modelos;
using LT_Lavagens.Banco;

namespace LT_Lavagens.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastra_Empresa : ContentPage
    {
        public Cadastra_Empresa()
        {
            InitializeComponent();
        }

        public void ProximaPagina(object sender, EventArgs args)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.NomeEmpresa = Nome.Text;
            cadastroEmpresa.Rua = Rua.Text;
            cadastroEmpresa.Bairro = Bairro.Text;
            cadastroEmpresa.Cep = Cep.Text;
            cadastroEmpresa.Cidade = Cidade.Text;

            DataBase dataBase = new DataBase();
            dataBase.Cadastro(cadastroEmpresa);

            App.Current.MainPage = new NavigationPage(new Cadastra_Usuario());
        }

    }
}