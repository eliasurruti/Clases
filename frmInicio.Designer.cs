namespace Clases
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btDocentes = new System.Windows.Forms.Button();
            this.btAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDocentes
            // 
            this.btDocentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDocentes.BackgroundImage")));
            this.btDocentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDocentes.FlatAppearance.BorderSize = 0;
            this.btDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDocentes.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocentes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDocentes.Location = new System.Drawing.Point(-8, -8);
            this.btDocentes.Name = "btDocentes";
            this.btDocentes.Size = new System.Drawing.Size(456, 624);
            this.btDocentes.TabIndex = 0;
            this.btDocentes.Text = "Docentes";
            this.btDocentes.UseVisualStyleBackColor = true;
            this.btDocentes.Click += new System.EventHandler(this.btDocentes_Click);
            // 
            // btAlumnos
            // 
            this.btAlumnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlumnos.BackgroundImage")));
            this.btAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAlumnos.FlatAppearance.BorderSize = 0;
            this.btAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlumnos.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlumnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAlumnos.Location = new System.Drawing.Point(440, -8);
            this.btAlumnos.Name = "btAlumnos";
            this.btAlumnos.Size = new System.Drawing.Size(472, 616);
            this.btAlumnos.TabIndex = 1;
            this.btAlumnos.Text = "Alumnos";
            this.btAlumnos.UseVisualStyleBackColor = true;
            this.btAlumnos.Click += new System.EventHandler(this.btAlumnos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 598);
            this.Controls.Add(this.btAlumnos);
            this.Controls.Add(this.btDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDocentes;
        private System.Windows.Forms.Button btAlumnos;
    }
}

