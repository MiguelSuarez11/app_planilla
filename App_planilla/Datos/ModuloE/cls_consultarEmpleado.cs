using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ModuloE
{
    public class cls_consultarEmpleado
    {
        SqlCommand con; SqlDataReader Lectura;
        private string str_mensaje;
        cls_conexion objconect = new cls_conexion();
        private string str_nombre;
        private string str_Apellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private double salario;

        public void fnt_consultar(string id)
        {
            try 
            {
                con = new SqlCommand("SP_Consultar_Empleado", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@PKId", id);
                objconect.connection.Open();
                //con.ExecuteNonQuery();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    str_nombre = Convert.ToString(Lectura[0]);
                    str_Apellido = Convert.ToString(Lectura[1]);
                    str_contacto = Convert.ToString(Lectura[2]);
                    str_direccion = Convert.ToString(Lectura[3]);
                    str_correo = Convert.ToString(Lectura[4]);
                    salario = Convert.ToDouble(Lectura[5]);
                    objconect.connection.Close();
                    str_mensaje = "";
                }
                }
            catch (Exception){ str_mensaje = "No se encontraron registron"; }

           
            }
        public string getNombre() { return this.str_nombre; }
        public string getApellido() {  return this.str_Apellido; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() {  return this.str_direccion; }
        public string getCorreo() { return this.str_correo; }
        public double getSalario() { return this.salario; }
        public string getmensaje() { return this.str_mensaje; }
    } 
    }

