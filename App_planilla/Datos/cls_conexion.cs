using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_conexion
    {
       
        
            public SqlConnection connection = new SqlConnection("Data Source=MABAPRRATFSD005\\MIGUEL;Initial Catalog=dbs_seguridad;Integrated Security=True");
        }
    }

