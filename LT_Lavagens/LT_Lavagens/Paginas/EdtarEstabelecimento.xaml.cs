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
    public partial class EdtarEstabelecimento : ContentPage
    {
        List<CadastroEmpresa> Lista { get; set; }
        public EdtarEstabelecimento()
        {
            InitializeComponent();

            ConsultarVagas();
        }
        private void ConsultarVagas()
        {
            DataBase dataBase = new DataBase();
            Lista = dataBase.Consultar();
            Edita.ItemsSource = Lista;

            //lblCount.Text = Lista.Count.ToString();
        }

        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            CadastroEmpresa cadastroEmpresa = tapGest.CommandParameter as CadastroEmpresa;

            Navigation.PushAsync(new EditarInfEstabelecimento(cadastroEmpresa));
        }

        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            CadastroEmpresa cadastroEmpresa = tapGest.CommandParameter as CadastroEmpresa;

            DataBase dataBase = new DataBase();
            dataBase.Exclusao(cadastroEmpresa);
            ConsultarVagas();
        }
    }
}