using System;
using System.Collections.Generic;
using System.Text;

namespace LT_Lavagens.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
