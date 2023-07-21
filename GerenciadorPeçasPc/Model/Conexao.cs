using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPeçasPc.Model
{
    internal class Conexao
    {
       public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matheus.fleonardi\source\repos\GerenciadorPeçasPc\GerenciadorPeçasPc\Model\pecaspcbd.mdf;Integrated Security=True";
        }
    }
}
