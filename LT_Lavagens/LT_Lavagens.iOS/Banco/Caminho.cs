using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using LT_Lavagens.Banco;
using Xamarin.Forms;
using System.IO;
using LT_Lavagens.iOS.Banco;

[assembly: Dependency(typeof(Caminho))]
namespace LT_Lavagens.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}