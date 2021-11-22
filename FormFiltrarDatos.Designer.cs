
namespace FormArduinoAplicaciones_2022_I
{
    partial class FormFiltrarDatos
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
            this.lstbTempBajas = new System.Windows.Forms.ListBox();
            this.lstbTempAltas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbTempBajas
            // 
            this.lstbTempBajas.FormattingEnabled = true;
            this.lstbTempBajas.ItemHeight = 25;
            this.lstbTempBajas.Location = new System.Drawing.Point(150, 238);
            this.lstbTempBajas.Name = "lstbTempBajas";
            this.lstbTempBajas.Size = new System.Drawing.Size(324, 629);
            this.lstbTempBajas.TabIndex = 0;
            // 
            // lstbTempAltas
            // 
            this.lstbTempAltas.FormattingEnabled = true;
            this.lstbTempAltas.ItemHeight = 25;
            this.lstbTempAltas.Location = new System.Drawing.Point(773, 238);
            this.lstbTempAltas.Name = "lstbTempAltas";
            this.lstbTempAltas.Size = new System.Drawing.Size(324, 629);
            this.lstbTempAltas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "T < 40 [°C]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "T > 60 [°C]";
            // 
            // FormFiltrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 1074);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbTempAltas);
            this.Controls.Add(this.lstbTempBajas);
            this.Name = "FormFiltrarDatos";
            this.Text = "FormFiltrarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbTempBajas;
        private System.Windows.Forms.ListBox lstbTempAltas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}