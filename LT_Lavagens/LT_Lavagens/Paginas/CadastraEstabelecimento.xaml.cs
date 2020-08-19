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
    public partial class CadastraEstabelecimento : ContentPage
    {
        public CadastraEstabelecimento()
        {
            InitializeComponent();
        }

        public void SalvaAction (object sender, EventArgs args)
        {
            CadastroEmpresa cadastroEmpresa = new CadastroEmpresa();
            cadastroEmpresa.Descricao = Descricao.Text;
            cadastroEmpresa.Servicos = Servicos.Text;

            DataBase dataBase = new DataBase();
            dataBase.Cadastro(cadastroEmpresa);

            App.Current.MainPage = new NavigationPage(new CadastraServicos());
        }
    }
}