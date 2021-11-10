namespace EvaluacionFinal_RV202840_VE202846
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.lblISSS = new System.Windows.Forms.Label();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblRenta = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblfechanac = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 171);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(620, 220);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(187, 28);
            this.btnGenerarPlanilla.TabIndex = 18;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(417, 220);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(197, 28);
            this.btnAbrirPlanilla.TabIndex = 17;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(214, 220);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(197, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Proximo empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 220);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(197, 28);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo Empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.lblISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.lblContrato);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Location = new System.Drawing.Point(433, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Laborales:";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(238, 125);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(106, 20);
            this.nudISSS.TabIndex = 12;
            this.nudISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudISSS_KeyPress);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(201, 128);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(31, 13);
            this.lblISSS.TabIndex = 11;
            this.lblISSS.Text = "ISSS";
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(85, 125);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(106, 20);
            this.nudRenta.TabIndex = 10;
            this.nudRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudRenta_KeyPress);
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(115, 83);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoini.TabIndex = 9;
            this.txtSueldoini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoini_KeyPress);
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(115, 30);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaContrato.TabIndex = 6;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(10, 36);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(82, 13);
            this.lblContrato.TabIndex = 8;
            this.lblContrato.Text = "Fecha contrato:";
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(22, 127);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(58, 13);
            this.lblRenta.TabIndex = 6;
            this.lblRenta.Text = "Tasa renta";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(22, 87);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(67, 13);
            this.lblSueldo.TabIndex = 7;
            this.lblSueldo.Text = "Sueldo Base";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblfechanac);
            this.groupBox1.Controls.Add(this.LblApellidos);
            this.groupBox1.Controls.Add(this.LblNombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 175);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales de empleados";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(134, 121);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(97, 76);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(195, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(97, 40);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(195, 20);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblfechanac
            // 
            this.lblfechanac.AutoSize = true;
            this.lblfechanac.Location = new System.Drawing.Point(27, 127);
            this.lblfechanac.Name = "lblfechanac";
            this.lblfechanac.Size = new System.Drawing.Size(104, 13);
            this.lblfechanac.TabIndex = 2;
            this.lblfechanac.Text = "Fecha nacimimiento:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(27, 83);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(49, 13);
            this.LblApellidos.TabIndex = 1;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(27, 36);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(52, 13);
            this.LblNombres.TabIndex = 0;
            this.LblNombres.Text = "Nombres:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblfechanac;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
    }
}

