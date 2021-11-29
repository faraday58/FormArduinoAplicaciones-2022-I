
namespace FormArduinoAplicaciones_2022_I
{
    partial class FormPruebaLED
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
            this.ptbFoco = new System.Windows.Forms.PictureBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFoco
            // 
            this.ptbFoco.Image = global::FormArduinoAplicaciones_2022_I.Properties.Resources.foco;
            this.ptbFoco.Location = new System.Drawing.Point(189, 67);
            this.ptbFoco.Name = "ptbFoco";
            this.ptbFoco.Size = new System.Drawing.Size(396, 371);
            this.ptbFoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFoco.TabIndex = 0;
            this.ptbFoco.TabStop = false;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(264, 509);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(210, 70);
            this.btnOnOff.TabIndex = 1;
            this.btnOnOff.Text = "On/Off";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // FormPruebaLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(752, 627);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.ptbFoco);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "FormPruebaLED";
            this.Text = "FormPruebaLED";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoco;
        private System.Windows.Forms.Button btnOnOff;
    }
}