using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Sql_Server_y_ADO.NET
{
    public class DatoIncompletoException(string mensaje) : Exception(mensaje) { }
    public class DBException(string mensaje) : Exception(mensaje) { }
}
