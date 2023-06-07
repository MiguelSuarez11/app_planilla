using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ModuloP
{
    public class cls_consultarP
    {
        private string str_mensaje;



        private DataTable dt;
        Datos.ModuloP.cls_ConsultarP obj_consultar = new Datos.ModuloP.cls_ConsultarP();
        public void fnt_Consultar(string id)
        {
            if (id == "")
            {
                str_mensaje = "Debe suministar el criterio de busqueda";
            }
            else
            {

                obj_consultar.fnt_Consultar(id);
                str_mensaje = obj_consultar.getmensaje();
                dt = obj_consultar.getDt();
            }
        }
        public string getmensaje() { return this.str_mensaje; }
        public DataTable getDt() { return this.dt; }
    }
}
