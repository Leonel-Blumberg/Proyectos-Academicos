using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Sql_Server_y_ADO.NET.Clases
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
    }
}
