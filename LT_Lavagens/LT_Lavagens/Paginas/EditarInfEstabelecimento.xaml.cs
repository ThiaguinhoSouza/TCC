using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LT_Lavagens.Banco;
using LT_Lavagens.Modelos;

namespace LT_Lavagens.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarInfEstabelecimento : ContentPage
    {
        private CadastroEmpresa cadastroEmpresa { get; set; }
        public EditarInfEstabelecimento(CadastroEmpresa cadastroEmpresa)
        {
            InitializeComponent();

            this.cadastroEmpresa = cadastroEmpresa;

            Servicos.Text = cadastroEmpresa.Servicos;
            Descricao.Text = cadastroEmpresa.Descricao;
        }
        public void SalvaAction(object sender, EventArgs args)
        {
            cadastroEmpresa.Servicos = Servicos.Text;
            cadastroEmpresa.Descricao = Descricao.Text;

            DataBase database = new DataBase();
            database.Atualizacao(cadastroEmpresa);

            App.Current.MainPage = new NavigationPage(new CadastraServicos());
        }
    }
}