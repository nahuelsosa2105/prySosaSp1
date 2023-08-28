namespace prySosaSp1
{
    partial class FrmPrincipal
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
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnLeer = new System.Windows.Forms.Button();
            this.TxtDatos = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(29, 229);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(133, 45);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear Archivo";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(190, 229);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(133, 45);
            this.BtnLeer.TabIndex = 1;
            this.BtnLeer.Text = "Leer Archivo";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // TxtDatos
            // 
            this.TxtDatos.Location = new System.Drawing.Point(21, 21);
            this.TxtDatos.Multiline = true;
            this.TxtDatos.Name = "TxtDatos";
            this.TxtDatos.Size = new System.Drawing.Size(302, 99);
            this.TxtDatos.TabIndex = 2;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(190, 140);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(133, 45);
            this.BtnGrabar.TabIndex = 3;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.TxtDatos);
            this.Controls.Add(this.BtnLeer);
            this.Controls.Add(this.BtnCrear);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.TextBox TxtDatos;
        private System.Windows.Forms.Button BtnGrabar;
    }
}

