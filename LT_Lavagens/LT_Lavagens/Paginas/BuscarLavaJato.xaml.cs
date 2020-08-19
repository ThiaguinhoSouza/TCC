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
    public partial class BuscarLavaJato : ContentPage
    {
        List<CadastroEmpresa> Lista { get; set; }
        public BuscarLavaJato()
        {
            InitializeComponent();

            DataBase dataBase = new DataBase();
            Lista = dataBase.Consultar();
            ListaLavaJato.ItemsSource = Lista;

            //lblCount.Text = Lista.Count.ToString();
        }

        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            CadastroEmpresa empresa = tapGest.CommandParameter as CadastroEmpresa;

            Navigation.PushAsync(new DetalheLavaJato(empresa));
        }
    }
}