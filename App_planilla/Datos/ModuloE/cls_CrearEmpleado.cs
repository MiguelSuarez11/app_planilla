using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ModuloE
{
    public class cls_CrearEmpleado
    {

        cls_conexion objconect = new cls_conexion();
        private string str_mensaje;
        public void fnt_Crear(string id , string str_nombre , string str_apellido , string contacto , string direccion , string correo , double salario )
        {
            try 
            {
                SqlCommand con = new SqlCommand("SP_Registrar_empleado", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@PKId", id);
                con.Parameters.AddWithValue("@Nombres", str_nombre);
                con.Parameters.AddWithValue("@Apellidos", str_apellido);
                con.Parameters.AddWithValue("@Contacto", contacto);
                con.Parameters.AddWithValue("@Direccion", direccion);
                con.Parameters.AddWithValue("@Correo", correo);
                con.Parameters.AddWithValue("@Salario", salario);
                objconect.connection.Open();
                con.ExecuteNonQuery();
                objconect.connection.Close();
                str_mensaje = "La persona" + str_nombre + " " + str_apellido + "ha sido registrada con exito";
            
            }
            catch (Exception){ str_mensaje = "Error al registar datos"; }
          
    }
        public string getmensaje() { return this.str_mensaje; }
    }
}
