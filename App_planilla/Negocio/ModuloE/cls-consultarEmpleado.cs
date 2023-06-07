using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ModuloE
{
    public class cls_consultarEmpleado
    {
        private string str_mensaje;
        private string str_nombre;
        private string str_Apellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private double salario;
        Datos.ModuloE.cls_consultarEmpleado obj_consultar = new Datos.ModuloE.cls_consultarEmpleado();
        public void fnt_consultar(string id)
        {
            if (id == "")
            {
                str_mensaje = "Debe suministar el criterio de busqueda";
            }
            else
            {
                obj_consultar.fnt_consultar(id);
                str_nombre = obj_consultar.getNombre();
                str_Apellido = obj_consultar.getApellido();
                str_contacto = obj_consultar.getContacto();
                str_direccion = obj_consultar.getDireccion();
                str_correo = obj_consultar.getCorreo();
                salario = obj_consultar.getSalario();
                str_mensaje = obj_consultar.getmensaje();
            }
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
