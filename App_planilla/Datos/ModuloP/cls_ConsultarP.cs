using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos.ModuloP
{
    public class cls_ConsultarP

    {
        DataTable dt;
        private string str_mensaje;
        cls_conexion obj_conexion = new cls_conexion();
        public void fnt_Consultar(string id)
        {
            try {
                obj_conexion.connection.Open();
                SqlCommand comando = new SqlCommand("SP_ConsultarPlanillaE", obj_conexion.connection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);
                dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(comando);
                Data.Fill(dt);
                obj_conexion.connection.Close();
            }
            catch (Exception ) { str_mensaje = "No se encontraron registros"; }
    }
        public string getmensaje() { return this.str_mensaje; }
        public DataTable getDt() { return this.dt; }
    }
}
