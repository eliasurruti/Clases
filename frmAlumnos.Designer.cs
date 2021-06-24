namespace Clases
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.label2 = new System.Windows.Forms.Label();
            this.cbCarrerasAlu = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajoAlu = new System.Windows.Forms.TextBox();
            this.btBorrarAlu = new System.Windows.Forms.Button();
            this.rbSexo3Alu = new System.Windows.Forms.RadioButton();
            this.rbSexo2Alu = new System.Windows.Forms.RadioButton();
            this.btNuevoAlu = new System.Windows.Forms.Button();
            this.rbSexoAlu = new System.Windows.Forms.RadioButton();
            this.btCargarAlu = new System.Windows.Forms.Button();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDniAlu = new System.Windows.Forms.TextBox();
            this.dataGridViewAlu = new System.Windows.Forms.DataGridView();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeFechNacAlu = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreAlu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Carrera";
            // 
            // cbCarrerasAlu
            // 
            this.cbCarrerasAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.cbCarrerasAlu.FormattingEnabled = true;
            this.cbCarrerasAlu.Items.AddRange(new object[] {
            "Administración de Recursos Humanos",
            "Administración y Gestión Pública",
            "Desarrollo de Sofware",
            "Enfermería",
            "Gestión Ambiental",
            "Gestión y Administración de las Organizaciones",
            "Gestión y Mantenimiento Industrial",
            "Óptica y Contactología",
            "Prótesis Dental",
            "Seguridad e Higiene en el Trabajo"});
            this.cbCarrerasAlu.Location = new System.Drawing.Point(51, 536);
            this.cbCarrerasAlu.Name = "cbCarrerasAlu";
            this.cbCarrerasAlu.Size = new System.Drawing.Size(216, 21);
            this.cbCarrerasAlu.TabIndex = 70;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(43, 400);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(77, 25);
            this.lblLegajo.TabIndex = 69;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtLegajoAlu
            // 
            this.txtLegajoAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLegajoAlu.Location = new System.Drawing.Point(51, 440);
            this.txtLegajoAlu.Name = "txtLegajoAlu";
            this.txtLegajoAlu.Size = new System.Drawing.Size(216, 20);
            this.txtLegajoAlu.TabIndex = 68;
            // 
            // btBorrarAlu
            // 
            this.btBorrarAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBorrarAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.btBorrarAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBorrarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarAlu.Location = new System.Drawing.Point(736, 505);
            this.btBorrarAlu.Name = "btBorrarAlu";
            this.btBorrarAlu.Size = new System.Drawing.Size(144, 64);
            this.btBorrarAlu.TabIndex = 67;
            this.btBorrarAlu.Text = "Borrar";
            this.btBorrarAlu.UseVisualStyleBackColor = false;
            this.btBorrarAlu.Click += new System.EventHandler(this.btBorrarAlu_Click);
            // 
            // rbSexo3Alu
            // 
            this.rbSexo3Alu.AutoSize = true;
            this.rbSexo3Alu.BackColor = System.Drawing.Color.Transparent;
            this.rbSexo3Alu.Location = new System.Drawing.Point(163, 232);
            this.rbSexo3Alu.Name = "rbSexo3Alu";
            this.rbSexo3Alu.Size = new System.Drawing.Size(45, 17);
            this.rbSexo3Alu.TabIndex = 60;
            this.rbSexo3Alu.TabStop = true;
            this.rbSexo3Alu.Text = "Otro";
            this.rbSexo3Alu.UseVisualStyleBackColor = false;
            // 
            // rbSexo2Alu
            // 
            this.rbSexo2Alu.AutoSize = true;
            this.rbSexo2Alu.BackColor = System.Drawing.Color.Transparent;
            this.rbSexo2Alu.Location = new System.Drawing.Point(163, 200);
            this.rbSexo2Alu.Name = "rbSexo2Alu";
            this.rbSexo2Alu.Size = new System.Drawing.Size(71, 17);
            this.rbSexo2Alu.TabIndex = 59;
            this.rbSexo2Alu.TabStop = true;
            this.rbSexo2Alu.Text = "Femenino";
            this.rbSexo2Alu.UseVisualStyleBackColor = false;
            // 
            // btNuevoAlu
            // 
            this.btNuevoAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNuevoAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.btNuevoAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoAlu.Location = new System.Drawing.Point(536, 505);
            this.btNuevoAlu.Name = "btNuevoAlu";
            this.btNuevoAlu.Size = new System.Drawing.Size(144, 64);
            this.btNuevoAlu.TabIndex = 66;
            this.btNuevoAlu.Text = "Nuevo";
            this.btNuevoAlu.UseVisualStyleBackColor = false;
            this.btNuevoAlu.Click += new System.EventHandler(this.btNuevoAlu_Click);
            // 
            // rbSexoAlu
            // 
            this.rbSexoAlu.AutoSize = true;
            this.rbSexoAlu.BackColor = System.Drawing.Color.Transparent;
            this.rbSexoAlu.Location = new System.Drawing.Point(163, 168);
            this.rbSexoAlu.Name = "rbSexoAlu";
            this.rbSexoAlu.Size = new System.Drawing.Size(73, 17);
            this.rbSexoAlu.TabIndex = 58;
            this.rbSexoAlu.TabStop = true;
            this.rbSexoAlu.Text = "Masculino";
            this.rbSexoAlu.UseVisualStyleBackColor = false;
            // 
            // btCargarAlu
            // 
            this.btCargarAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCargarAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.btCargarAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCargarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarAlu.Location = new System.Drawing.Point(335, 504);
            this.btCargarAlu.Name = "btCargarAlu";
            this.btCargarAlu.Size = new System.Drawing.Size(144, 64);
            this.btCargarAlu.TabIndex = 65;
            this.btCargarAlu.Text = "Guardar";
            this.btCargarAlu.UseVisualStyleBackColor = false;
            this.btCargarAlu.Click += new System.EventHandler(this.btCargarAlu_Click);
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechNac.Location = new System.Drawing.Point(43, 288);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(212, 25);
            this.lblFechNac.TabIndex = 64;
            this.lblFechNac.Text = "Fecha de nacimiento";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(40, 120);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(44, 25);
            this.lblDni.TabIndex = 63;
            this.lblDni.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sexo";
            // 
            // txtDniAlu
            // 
            this.txtDniAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDniAlu.Location = new System.Drawing.Point(160, 120);
            this.txtDniAlu.Name = "txtDniAlu";
            this.txtDniAlu.Size = new System.Drawing.Size(104, 20);
            this.txtDniAlu.TabIndex = 61;
            // 
            // dataGridViewAlu
            // 
            this.dataGridViewAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAlu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvDni,
            this.dgvSexo,
            this.dgvEdad,
            this.dgvCarrera,
            this.dgvLegajo});
            this.dataGridViewAlu.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewAlu.Location = new System.Drawing.Point(288, 73);
            this.dataGridViewAlu.Name = "dataGridViewAlu";
            this.dataGridViewAlu.Size = new System.Drawing.Size(648, 384);
            this.dataGridViewAlu.TabIndex = 57;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvDni
            // 
            this.dgvDni.HeaderText = "Dni";
            this.dgvDni.Name = "dgvDni";
            // 
            // dgvSexo
            // 
            this.dgvSexo.HeaderText = "Sexo";
            this.dgvSexo.Name = "dgvSexo";
            // 
            // dgvEdad
            // 
            this.dgvEdad.HeaderText = "Edad";
            this.dgvEdad.Name = "dgvEdad";
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.HeaderText = "Carrera";
            this.dgvCarrera.Name = "dgvCarrera";
            // 
            // dgvLegajo
            // 
            this.dgvLegajo.HeaderText = "Legajo";
            this.dgvLegajo.Name = "dgvLegajo";
            // 
            // dateTimeFechNacAlu
            // 
            this.dateTimeFechNacAlu.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dateTimeFechNacAlu.Location = new System.Drawing.Point(51, 328);
            this.dateTimeFechNacAlu.MaxDate = new System.DateTime(2022, 1, 1, 23, 59, 59, 0);
            this.dateTimeFechNacAlu.Name = "dateTimeFechNacAlu";
            this.dateTimeFechNacAlu.Size = new System.Drawing.Size(216, 20);
            this.dateTimeFechNacAlu.TabIndex = 56;
            this.dateTimeFechNacAlu.Value = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 73;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreAlu
            // 
            this.txtNombreAlu.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombreAlu.Location = new System.Drawing.Point(160, 72);
            this.txtNombreAlu.Name = "txtNombreAlu";
            this.txtNombreAlu.Size = new System.Drawing.Size(104, 20);
            this.txtNombreAlu.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(920, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 75;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Honeydew;
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(880, 16);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(24, 24);
            this.btBack.TabIndex = 74;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreAlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCarrerasAlu);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtLegajoAlu);
            this.Controls.Add(this.btBorrarAlu);
            this.Controls.Add(this.rbSexo3Alu);
            this.Controls.Add(this.rbSexo2Alu);
            this.Controls.Add(this.btNuevoAlu);
            this.Controls.Add(this.rbSexoAlu);
            this.Controls.Add(this.btCargarAlu);
            this.Controls.Add(this.lblFechNac);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDniAlu);
            this.Controls.Add(this.dataGridViewAlu);
            this.Controls.Add(this.dateTimeFechNacAlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCarrerasAlu;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajoAlu;
        private System.Windows.Forms.Button btBorrarAlu;
        private System.Windows.Forms.RadioButton rbSexo3Alu;
        private System.Windows.Forms.RadioButton rbSexo2Alu;
        private System.Windows.Forms.Button btNuevoAlu;
        private System.Windows.Forms.RadioButton rbSexoAlu;
        private System.Windows.Forms.Button btCargarAlu;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDniAlu;
        public System.Windows.Forms.DataGridView dataGridViewAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLegajo;
        public System.Windows.Forms.DateTimePicker dateTimeFechNacAlu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreAlu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBack;
    }
}