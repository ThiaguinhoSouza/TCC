using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LT_Lavagens.Modelos;

namespace LT_Lavagens.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheLavaJato : ContentPage
    {
        public DetalheLavaJato(CadastroEmpresa cadastroEmpresa)
        {
            InitializeComponent();
            BindingContext = cadastroEmpresa;
        }
    }
}