
namespace ImplementacionMultiHilos
{
    partial class Ventana1
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
            this.btncargartex = new System.Windows.Forms.Button();
            this.barracarga = new System.Windows.Forms.ProgressBar();
            this.btnenviartex = new System.Windows.Forms.Button();
            this.textBoxpantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncargartex
            // 
            this.btncargartex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargartex.Location = new System.Drawing.Point(13, 109);
            this.btncargartex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncargartex.Name = "btncargartex";
            this.btncargartex.Size = new System.Drawing.Size(192, 46);
            this.btncargartex.TabIndex = 1;
            this.btncargartex.Text = "Cargar Texo";
            this.btncargartex.UseVisualStyleBackColor = true;
            this.btncargartex.Click += new System.EventHandler(this.Btn_AbrirForm_Click);
            // 
            // barracarga
            // 
            this.barracarga.Location = new System.Drawing.Point(13, 258);
            this.barracarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barracarga.Name = "barracarga";
            this.barracarga.Size = new System.Drawing.Size(192, 35);
            this.barracarga.TabIndex = 3;
            // 
            // btnenviartex
            // 
            this.btnenviartex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviartex.Location = new System.Drawing.Point(13, 178);
            this.btnenviartex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnenviartex.Name = "btnenviartex";
            this.btnenviartex.Size = new System.Drawing.Size(192, 46);
            this.btnenviartex.TabIndex = 4;
            this.btnenviartex.Text = "Enviar Texto";
            this.btnenviartex.UseVisualStyleBackColor = true;
            this.btnenviartex.Click += new System.EventHandler(this.Btn_PasarTexto_Click);
            // 
            // textBoxpantalla
            // 
            this.textBoxpantalla.Location = new System.Drawing.Point(55, 42);
            this.textBoxpantalla.Name = "textBoxpantalla";
            this.textBoxpantalla.Size = new System.Drawing.Size(100, 26);
            this.textBoxpantalla.TabIndex = 5;
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 317);
            this.Controls.Add(this.textBoxpantalla);
            this.Controls.Add(this.btnenviartex);
            this.Controls.Add(this.barracarga);
            this.Controls.Add(this.btncargartex);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ventana1";
            this.Text = "Ventana Original";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncargartex;
        private System.Windows.Forms.ProgressBar barracarga;
        private System.Windows.Forms.Button btnenviartex;
        private System.Windows.Forms.TextBox textBoxpantalla;
    }
}

