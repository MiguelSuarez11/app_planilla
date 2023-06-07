using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ModuloE
{
    public class cls_actualizarE
    {
        private string str_mensaje;
        private string str_nombre;
        private string str_Apellido;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private double salario;
        Datos.ModuloE.cls_actulizarE obj_actualizar = new Datos.ModuloE.cls_actulizarE();

        public void fnt_actualizar(string id ,string nom , string ap , string cont , string dir , string corr , double sal) 
        {
            if (nom == "" || ap == "" || cont == "" || dir == "" || corr == "" || sal <= 0)
            {
                str_mensaje = "Debe llenar todos los campos";

            }
            else 
            {
                obj_actualizar.fnt_actualizarE(id, nom, ap, cont, dir, corr, sal);
                str_mensaje = obj_actualizar.getmensaje();
            }
        
        }
        public string getmensaje() { return this.str_mensaje; }
    }
}
