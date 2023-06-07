using System;

using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        Negocio.ModuloE.cls_crearEmpleado obj_llamar =  new Negocio.ModuloE.cls_crearEmpleado();
       
        public Form1()
        {
            InitializeComponent();
            fnt_ocultarPaneles();
        }
        private void fnt_ocultarPaneles() 
        {
            pnl_empleados.Visible = false;
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            fnt_ocultarPaneles();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            fnt_ocultarPaneles();
            pnl_empleados.Size = new System.Drawing.Size(642, 391);
            pnl_empleados.Location = new System.Drawing.Point(120,46);
            pnl_empleados.Visible = true;
        }
        private void fnt_limpiarContoles()
        {
            txt_apellidos.Clear();
            txt_contacto.Clear();
            txt_direccion.Clear();
            txt_identificacion.Clear();
            txt_nombres.Clear();
            txt_salario.Clear();
            txt_identificacion.Focus();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            fnt_limpiarContoles();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            obj_llamar.fnt_Crear(txt_identificacion.Text, txt_nombres.Text, txt_apellidos.Text, txt_contacto.Text, txt_direccion.Text, txt_correo.Text,
                Convert.ToDouble(txt_salario.Text));
            MessageBox.Show(obj_llamar.getmensaje(), "", MessageBoxButtons.OK);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Negocio.ModuloE.cls_consultarEmpleado obj_consultar = new Negocio.ModuloE.cls_consultarEmpleado();
            obj_consultar.fnt_consultar(txt_identificacion.Text);
            txt_nombres.Text = obj_consultar.getNombre();
            txt_apellidos.Text = obj_consultar.getApellido();
            txt_contacto.Text= obj_consultar.getContacto();
            txt_direccion.Text = obj_consultar.getDireccion();
            txt_correo.Text = obj_consultar.getCorreo();
            txt_salario.Text = Convert.ToString(obj_consultar.getSalario());
            if (obj_consultar.getmensaje() != "")
            {
                MessageBox.Show(obj_consultar.getmensaje() , "" , MessageBoxButtons.OK);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Negocio.ModuloE.cls_actualizarE actualizar = new Negocio.ModuloE.cls_actualizarE();
            actualizar.fnt_actualizar(txt_identificacion.Text , txt_nombres.Text , txt_apellidos.Text , txt_contacto.Text ,txt_direccion.Text, txt_correo.Text ,Convert.ToDouble( txt_salario.Text));
            MessageBox.Show(actualizar.getmensaje(), "", MessageBoxButtons.OK);
        }

        private void btn_consultarP_Click(object sender, EventArgs e)
        {
            Negocio.ModuloP.cls_consultarP obj_consultar = new Negocio.ModuloP.cls_consultarP();
            obj_consultar.fnt_Consultar(txt_identficacionP.Text);
            dtg_planilla.DataSource = obj_consultar.getDt();
            if (obj_consultar.getmensaje() != "")
            {
                MessageBox.Show(obj_consultar.getmensaje(), "", MessageBoxButtons.OK);
            }
        }
    }
}
