namespace Clases
{
    partial class frmDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajoDoc = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.rbSexo3Doc = new System.Windows.Forms.RadioButton();
            this.rbSexo2Doc = new System.Windows.Forms.RadioButton();
            this.btNuevo = new System.Windows.Forms.Button();
            this.rbSexoDoc = new System.Windows.Forms.RadioButton();
            this.btCargarDoc = new System.Windows.Forms.Button();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDniDoc = new System.Windows.Forms.TextBox();
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeFechNacDoc = new System.Windows.Forms.DateTimePicker();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(72, 456);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(77, 25);
            this.lblLegajo.TabIndex = 51;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtLegajoDoc
            // 
            this.txtLegajoDoc.BackColor = System.Drawing.Color.Honeydew;
            this.txtLegajoDoc.Location = new System.Drawing.Point(80, 496);
            this.txtLegajoDoc.Name = "txtLegajoDoc";
            this.txtLegajoDoc.Size = new System.Drawing.Size(216, 20);
            this.txtLegajoDoc.TabIndex = 50;
            // 
            // btBorrar
            // 
            this.btBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBorrar.BackColor = System.Drawing.Color.Honeydew;
            this.btBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(744, 512);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(144, 64);
            this.btBorrar.TabIndex = 49;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // rbSexo3Doc
            // 
            this.rbSexo3Doc.AutoSize = true;
            this.rbSexo3Doc.Location = new System.Drawing.Point(192, 288);
            this.rbSexo3Doc.Name = "rbSexo3Doc";
            this.rbSexo3Doc.Size = new System.Drawing.Size(45, 17);
            this.rbSexo3Doc.TabIndex = 41;
            this.rbSexo3Doc.TabStop = true;
            this.rbSexo3Doc.Text = "Otro";
            this.rbSexo3Doc.UseVisualStyleBackColor = true;
            // 
            // rbSexo2Doc
            // 
            this.rbSexo2Doc.AutoSize = true;
            this.rbSexo2Doc.Location = new System.Drawing.Point(192, 256);
            this.rbSexo2Doc.Name = "rbSexo2Doc";
            this.rbSexo2Doc.Size = new System.Drawing.Size(71, 17);
            this.rbSexo2Doc.TabIndex = 40;
            this.rbSexo2Doc.TabStop = true;
            this.rbSexo2Doc.Text = "Femenino";
            this.rbSexo2Doc.UseVisualStyleBackColor = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNuevo.BackColor = System.Drawing.Color.Honeydew;
            this.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(560, 512);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(144, 64);
            this.btNuevo.TabIndex = 48;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // rbSexoDoc
            // 
            this.rbSexoDoc.AutoSize = true;
            this.rbSexoDoc.Location = new System.Drawing.Point(192, 224);
            this.rbSexoDoc.Name = "rbSexoDoc";
            this.rbSexoDoc.Size = new System.Drawing.Size(73, 17);
            this.rbSexoDoc.TabIndex = 39;
            this.rbSexoDoc.TabStop = true;
            this.rbSexoDoc.Text = "Masculino";
            this.rbSexoDoc.UseVisualStyleBackColor = true;
            // 
            // btCargarDoc
            // 
            this.btCargarDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCargarDoc.BackColor = System.Drawing.Color.Honeydew;
            this.btCargarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCargarDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarDoc.Location = new System.Drawing.Point(371, 512);
            this.btCargarDoc.Name = "btCargarDoc";
            this.btCargarDoc.Size = new System.Drawing.Size(144, 64);
            this.btCargarDoc.TabIndex = 47;
            this.btCargarDoc.Text = "Guardar";
            this.btCargarDoc.UseVisualStyleBackColor = false;
            this.btCargarDoc.Click += new System.EventHandler(this.btCargarDoc_Click);
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.BackColor = System.Drawing.Color.Transparent;
            this.lblFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechNac.Location = new System.Drawing.Point(72, 344);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(212, 25);
            this.lblFechNac.TabIndex = 46;
            this.lblFechNac.Text = "Fecha de nacimiento";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(72, 152);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(44, 25);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sexo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(72, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDniDoc
            // 
            this.txtDniDoc.BackColor = System.Drawing.Color.Honeydew;
            this.txtDniDoc.Location = new System.Drawing.Point(192, 152);
            this.txtDniDoc.Name = "txtDniDoc";
            this.txtDniDoc.Size = new System.Drawing.Size(104, 20);
            this.txtDniDoc.TabIndex = 42;
            // 
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDoc.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvDni,
            this.dgvSexo,
            this.dgvEdad,
            this.dgvLegajo});
            this.dataGridViewDoc.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewDoc.Location = new System.Drawing.Point(352, 80);
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.Size = new System.Drawing.Size(544, 384);
            this.dataGridViewDoc.TabIndex = 38;
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
            // dgvLegajo
            // 
            this.dgvLegajo.HeaderText = "Legajo";
            this.dgvLegajo.Name = "dgvLegajo";
            // 
            // dateTimeFechNacDoc
            // 
            this.dateTimeFechNacDoc.CalendarForeColor = System.Drawing.Color.Honeydew;
            this.dateTimeFechNacDoc.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dateTimeFechNacDoc.CalendarTitleBackColor = System.Drawing.Color.Honeydew;
            this.dateTimeFechNacDoc.CalendarTrailingForeColor = System.Drawing.Color.Honeydew;
            this.dateTimeFechNacDoc.Location = new System.Drawing.Point(80, 384);
            this.dateTimeFechNacDoc.MaxDate = new System.DateTime(2022, 1, 1, 23, 59, 59, 0);
            this.dateTimeFechNacDoc.Name = "dateTimeFechNacDoc";
            this.dateTimeFechNacDoc.Size = new System.Drawing.Size(216, 20);
            this.dateTimeFechNacDoc.TabIndex = 37;
            this.dateTimeFechNacDoc.Value = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.BackColor = System.Drawing.Color.Honeydew;
            this.txtNombreDoc.Location = new System.Drawing.Point(192, 80);
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(104, 20);
            this.txtNombreDoc.TabIndex = 36;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Honeydew;
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(880, 24);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(24, 24);
            this.btBack.TabIndex = 52;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(920, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtLegajoDoc);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.rbSexo3Doc);
            this.Controls.Add(this.rbSexo2Doc);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.rbSexoDoc);
            this.Controls.Add(this.btCargarDoc);
            this.Controls.Add(this.lblFechNac);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDniDoc);
            this.Controls.Add(this.dataGridViewDoc);
            this.Controls.Add(this.dateTimeFechNacDoc);
            this.Controls.Add(this.txtNombreDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajoDoc;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.RadioButton rbSexo3Doc;
        private System.Windows.Forms.RadioButton rbSexo2Doc;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.RadioButton rbSexoDoc;
        private System.Windows.Forms.Button btCargarDoc;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDniDoc;
        public System.Windows.Forms.DataGridView dataGridViewDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLegajo;
        public System.Windows.Forms.DateTimePicker dateTimeFechNacDoc;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button1;
    }
}