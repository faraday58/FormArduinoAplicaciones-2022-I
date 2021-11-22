
namespace FormArduinoAplicaciones_2022_I
{
    partial class FormTemperatura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvTemperatura = new System.Windows.Forms.DataGridView();
            this.chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTemperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerTemp = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTemperatura
            // 
            this.dgvTemperatura.AllowUserToAddRows = false;
            this.dgvTemperatura.AllowUserToDeleteRows = false;
            this.dgvTemperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemperatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTiempo,
            this.ColTemperatura});
            this.dgvTemperatura.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTemperatura.Location = new System.Drawing.Point(53, 221);
            this.dgvTemperatura.Name = "dgvTemperatura";
            this.dgvTemperatura.ReadOnly = true;
            this.dgvTemperatura.RowHeadersWidth = 82;
            this.dgvTemperatura.RowTemplate.Height = 33;
            this.dgvTemperatura.Size = new System.Drawing.Size(490, 683);
            this.dgvTemperatura.TabIndex = 0;
            // 
            // chartTemperatura
            // 
            chartArea6.AxisX.Title = "Tiempo [s]";
            chartArea6.AxisY.Title = "Temperatura [°C]";
            chartArea6.Name = "ChartArea1";
            this.chartTemperatura.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTemperatura.Legends.Add(legend6);
            this.chartTemperatura.Location = new System.Drawing.Point(710, 221);
            this.chartTemperatura.Name = "chartTemperatura";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "seTemperatura";
            this.chartTemperatura.Series.Add(series6);
            this.chartTemperatura.Size = new System.Drawing.Size(1339, 683);
            this.chartTemperatura.TabIndex = 1;
            this.chartTemperatura.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2170, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.simularToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem1,
            this.detenerToolStripMenuItem1});
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.simularToolStripMenuItem.Text = "Simular";
            // 
            // iniciarToolStripMenuItem1
            // 
            this.iniciarToolStripMenuItem1.Name = "iniciarToolStripMenuItem1";
            this.iniciarToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.iniciarToolStripMenuItem1.Text = "Iniciar";
            this.iniciarToolStripMenuItem1.Click += new System.EventHandler(this.iniciarToolStripMenuItem1_Click);
            // 
            // detenerToolStripMenuItem1
            // 
            this.detenerToolStripMenuItem1.Name = "detenerToolStripMenuItem1";
            this.detenerToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.detenerToolStripMenuItem1.Text = "Detener";
            this.detenerToolStripMenuItem1.Click += new System.EventHandler(this.detenerToolStripMenuItem1_Click);
            // 
            // ColTiempo
            // 
            this.ColTiempo.HeaderText = "Tiempo";
            this.ColTiempo.MinimumWidth = 10;
            this.ColTiempo.Name = "ColTiempo";
            this.ColTiempo.ReadOnly = true;
            // 
            // ColTemperatura
            // 
            this.ColTemperatura.HeaderText = "Temperatura";
            this.ColTemperatura.MinimumWidth = 10;
            this.ColTemperatura.Name = "ColTemperatura";
            this.ColTemperatura.ReadOnly = true;
            this.ColTemperatura.Width = 150;
            // 
            // timerTemp
            // 
            this.timerTemp.Interval = 500;
            this.timerTemp.Tick += new System.EventHandler(this.timerTemp_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarDatosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 42);
            // 
            // filtrarDatosToolStripMenuItem
            // 
            this.filtrarDatosToolStripMenuItem.Name = "filtrarDatosToolStripMenuItem";
            this.filtrarDatosToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.filtrarDatosToolStripMenuItem.Text = "Filtrar Datos";
            this.filtrarDatosToolStripMenuItem.Click += new System.EventHandler(this.filtrarDatosToolStripMenuItem_Click);
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2170, 1022);
            this.Controls.Add(this.chartTemperatura);
            this.Controls.Add(this.dgvTemperatura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTemperatura";
            this.Text = "FormTemperatura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTemperatura;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem1;
        private System.Windows.Forms.Timer timerTemp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtrarDatosToolStripMenuItem;
    }
}