using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LT_Lavagens.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void Cadastra(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.Cadastra_Empresa());
        }

        public void Entra(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.Login());
        }
    }
}