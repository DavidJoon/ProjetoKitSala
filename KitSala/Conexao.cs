using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitSala
{
    class Conexao
    {
        static public string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\source\repos\KitSala\KitSala\bdkitsala.mdf;Integrated Security=True";
        }
    }
}
