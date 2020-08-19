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
    public partial class CadastraServicos : ContentPage
    {
        List<CadastroEmpresa> Lista { get; set; }
        public CadastraServicos()
        {
            InitializeComponent();

            DataBase dataBase = new DataBase();
            Lista = dataBase.Consultar();
            ListaServicos.ItemsSource = Lista;

            //lblCount.Text = Lista.Count.ToString();
        }
        public void Adcionar(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.CadastraEstabelecimento());
        }

        public void Edtar(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.EdtarEstabelecimento());
        }

        public void Inicio(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.Inicio());
        }
    }
}