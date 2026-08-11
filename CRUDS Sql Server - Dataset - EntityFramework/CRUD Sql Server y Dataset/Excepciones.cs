using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Sql_Server_y_Dataset
{
    public class DatoIncompletoException(string mensaje) : Exception(mensaje) { }
}
