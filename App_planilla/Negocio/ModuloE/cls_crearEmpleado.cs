using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ModuloE
{
    public class cls_crearEmpleado
    {
        private string str_mensaje;
        Datos.ModuloE.cls_CrearEmpleado objCrear = new Datos.ModuloE.cls_CrearEmpleado();
        public void fnt_Crear(string id, string str_nombre, string str_apellido, string contacto, string direccion, string correo, double salario)
        {
            if (id == "" || str_nombre == "" || str_apellido == "" || contacto == "" || direccion == "" || correo == "" || salario <= 0)
            {
                str_mensaje = "Debe ingresar la informacion solicitada de manera correcta";
            }    
            else
            {
                objCrear.fnt_Crear(id, str_nombre, str_apellido, contacto, direccion, correo, salario);
                str_mensaje = objCrear.getmensaje();
            }
        }
        public string getmensaje() { return this.str_mensaje; }
    }
}
