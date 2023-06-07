namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_planillas = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_empleados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_identficacionP = new System.Windows.Forms.TextBox();
            this.btn_consultarP = new System.Windows.Forms.Button();
            this.btn_nuevaP = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.dtg_planilla = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnl_empleados.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_planilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_reportes);
            this.panel1.Controls.Add(this.btn_planillas);
            this.panel1.Controls.Add(this.btn_empleados);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.pnl_empleados);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 449);
            this.panel1.TabIndex = 0;
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(14, 208);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(82, 33);
            this.btn_reportes.TabIndex = 3;
            this.btn_reportes.Text = "&Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            // 
            // btn_planillas
            // 
            this.btn_planillas.Location = new System.Drawing.Point(14, 159);
            this.btn_planillas.Name = "btn_planillas";
            this.btn_planillas.Size = new System.Drawing.Size(82, 33);
            this.btn_planillas.TabIndex = 3;
            this.btn_planillas.Text = "&Planillas";
            this.btn_planillas.UseVisualStyleBackColor = true;
            // 
            // btn_empleados
            // 
            this.btn_empleados.Location = new System.Drawing.Point(14, 112);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(82, 33);
            this.btn_empleados.TabIndex = 3;
            this.btn_empleados.Text = "&Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(14, 64);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(82, 33);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "&Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_empleados
            // 
            this.pnl_empleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_empleados.Controls.Add(this.label1);
            this.pnl_empleados.Controls.Add(this.btn_actualizar);
            this.pnl_empleados.Controls.Add(this.btn_consultar);
            this.pnl_empleados.Controls.Add(this.btn_guardar);
            this.pnl_empleados.Controls.Add(this.btn_nuevo);
            this.pnl_empleados.Controls.Add(this.txt_salario);
            this.pnl_empleados.Controls.Add(this.label7);
            this.pnl_empleados.Controls.Add(this.txt_correo);
            this.pnl_empleados.Controls.Add(this.label9);
            this.pnl_empleados.Controls.Add(this.txt_direccion);
            this.pnl_empleados.Controls.Add(this.label6);
            this.pnl_empleados.Controls.Add(this.txt_contacto);
            this.pnl_empleados.Controls.Add(this.label5);
            this.pnl_empleados.Controls.Add(this.txt_apellidos);
            this.pnl_empleados.Controls.Add(this.label4);
            this.pnl_empleados.Controls.Add(this.txt_nombres);
            this.pnl_empleados.Controls.Add(this.label3);
            this.pnl_empleados.Controls.Add(this.txt_identificacion);
            this.pnl_empleados.Controls.Add(this.label2);
            this.pnl_empleados.Location = new System.Drawing.Point(14, 50);
            this.pnl_empleados.Name = "pnl_empleados";
            this.pnl_empleados.Size = new System.Drawing.Size(10, 10);
            this.pnl_empleados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo - Registro de empleados";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(376, 300);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(82, 33);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(288, 300);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(82, 33);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(200, 300);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(82, 33);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(112, 300);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(82, 33);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_salario
            // 
            this.txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.Location = new System.Drawing.Point(195, 246);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(175, 29);
            this.txt_salario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salario:";
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(195, 211);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(175, 29);
            this.txt_correo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(195, 176);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(175, 29);
            this.txt_direccion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Direccion:";
            // 
            // txt_contacto
            // 
            this.txt_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contacto.Location = new System.Drawing.Point(195, 141);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(175, 29);
            this.txt_contacto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contacto:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(195, 106);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(175, 29);
            this.txt_apellidos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apeliidos:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(195, 71);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(175, 29);
            this.txt_nombres.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres:";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(195, 36);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(175, 29);
            this.txt_identificacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificacion:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 44);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(528, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sistema de generacion de planillas de seguridad social";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtg_planilla);
            this.panel3.Controls.Add(this.btn_generar);
            this.panel3.Controls.Add(this.btn_nuevaP);
            this.panel3.Controls.Add(this.btn_consultarP);
            this.panel3.Controls.Add(this.txt_identficacionP);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(120, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 391);
            this.panel3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Identificacion:";
            // 
            // txt_identficacionP
            // 
            this.txt_identficacionP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identficacionP.Location = new System.Drawing.Point(140, 20);
            this.txt_identficacionP.Name = "txt_identficacionP";
            this.txt_identficacionP.Size = new System.Drawing.Size(154, 29);
            this.txt_identficacionP.TabIndex = 1;
            // 
            // btn_consultarP
            // 
            this.btn_consultarP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarP.Location = new System.Drawing.Point(326, 20);
            this.btn_consultarP.Name = "btn_consultarP";
            this.btn_consultarP.Size = new System.Drawing.Size(86, 31);
            this.btn_consultarP.TabIndex = 2;
            this.btn_consultarP.Text = "Consultar";
            this.btn_consultarP.UseVisualStyleBackColor = true;
            this.btn_consultarP.Click += new System.EventHandler(this.btn_consultarP_Click);
            // 
            // btn_nuevaP
            // 
            this.btn_nuevaP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevaP.Location = new System.Drawing.Point(418, 20);
            this.btn_nuevaP.Name = "btn_nuevaP";
            this.btn_nuevaP.Size = new System.Drawing.Size(86, 31);
            this.btn_nuevaP.TabIndex = 3;
            this.btn_nuevaP.Text = "Nuevo";
            this.btn_nuevaP.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(510, 18);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(86, 31);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // dtg_planilla
            // 
            this.dtg_planilla.AllowUserToAddRows = false;
            this.dtg_planilla.AllowUserToDeleteRows = false;
            this.dtg_planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_planilla.Location = new System.Drawing.Point(16, 82);
            this.dtg_planilla.Name = "dtg_planilla";
            this.dtg_planilla.ReadOnly = true;
            this.dtg_planilla.Size = new System.Drawing.Size(578, 196);
            this.dtg_planilla.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnl_empleados.ResumeLayout(false);
            this.pnl_empleados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_planilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_planillas;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_empleados;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtg_planilla;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_nuevaP;
        private System.Windows.Forms.Button btn_consultarP;
        private System.Windows.Forms.TextBox txt_identficacionP;
        private System.Windows.Forms.Label label10;
    }
}

