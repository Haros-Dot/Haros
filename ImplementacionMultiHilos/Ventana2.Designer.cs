
namespace ImplementacionMultiHilos
{
    partial class Ventana2
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
            this.lbtextoresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtextoresultado
            // 
            this.lbtextoresultado.AutoSize = true;
            this.lbtextoresultado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtextoresultado.Location = new System.Drawing.Point(54, 73);
            this.lbtextoresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtextoresultado.Name = "lbtextoresultado";
            this.lbtextoresultado.Size = new System.Drawing.Size(115, 25);
            this.lbtextoresultado.TabIndex = 0;
            this.lbtextoresultado.Text = "Inserte Texto";
            this.lbtextoresultado.Click += new System.EventHandler(this.Lb_TextoAqui_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 224);
            this.Controls.Add(this.lbtextoresultado);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ventana2";
            this.Text = "Ventana Copia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtextoresultado;
    }
}