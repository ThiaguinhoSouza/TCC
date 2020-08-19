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
    public partial class Cadastra_Usuario : ContentPage
    {
        public Cadastra_Usuario()
        {
            InitializeComponent();
        }
        public void Salvar(object sender, EventArgs args)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Nome = Nome.Text;
            cadastroPessoa.Email = Email.Text;
            cadastroPessoa.Telefone = Fone.Text;

            DataBase dataBase = new DataBase();
            dataBase.Cadastra(cadastroPessoa);

            App.Current.MainPage = new NavigationPage(new CadastraServicos());
        }
    }
}