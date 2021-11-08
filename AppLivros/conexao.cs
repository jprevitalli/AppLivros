using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLivros
{
    class conexao
    {
        static public string Conectar()
        {

            return @"Data Source=DESKTOP-4QOUJ24\SQLEXPRESS;Initial Catalog=bdlivro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
    }
}
