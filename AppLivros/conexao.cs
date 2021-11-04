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

            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdlivros;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
    }
}
