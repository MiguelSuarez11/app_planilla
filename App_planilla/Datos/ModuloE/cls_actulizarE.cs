using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ModuloE
{
    public class cls_actulizarE
    {
        cls_conexion objconect = new cls_conexion();
        private string str_nombre;
        private string str_Apellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private double salario;
        private string str_mensaje;
        public void fnt_actualizarE(string id, string str_nombre, string str_apellido, string contacto, string direccion, string correo, double salario) 
        {
            try
            {
                SqlCommand con = new SqlCommand("SP_Actualizar_empleado", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@PKId", id);
                con.Parameters.AddWithValue("@Nombres", str_nombre);
                con.Parameters.AddWithValue("@Apellidos", str_apellido);
                con.Parameters.AddWithValue("@Contacto", contacto);
                con.Parameters.AddWithValue("@Direccion",direccion);
                con.Parameters.AddWithValue("@Correo", correo);
                con.Parameters.AddWithValue("@Salario", salario);
                objconect.connection.Open();
                con.ExecuteNonQuery();
                objconect.connection.Close();
                str_mensaje = "La persona" + str_nombre + " " + str_apellido + "ha sido actualizada con exito";
            }
            catch (Exception) { str_mensaje = "No se encontraron registron"; }
        }

        public string getNombre() { return this.str_nombre; }
        public string getApellido() { return this.str_Apellido; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }
        public string getCorreo() { return this.str_correo; }
        public double getSalario() { return this.salario; }
        public string getmensaje() { return this.str_mensaje; }
    }
}
