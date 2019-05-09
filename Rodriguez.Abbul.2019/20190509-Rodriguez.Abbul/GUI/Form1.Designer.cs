namespace GUI
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.nudMemoria = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtSystemInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 42);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(23, 72);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(23, 98);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(72, 13);
            this.lblMemoria.TabIndex = 3;
            this.lblMemoria.Text = "Memoria (MB)";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(118, 65);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(138, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(118, 35);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(138, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // nudMemoria
            // 
            this.nudMemoria.Location = new System.Drawing.Point(118, 91);
            this.nudMemoria.Name = "nudMemoria";
            this.nudMemoria.Size = new System.Drawing.Size(138, 20);
            this.nudMemoria.TabIndex = 7;
            this.nudMemoria.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 25);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(182, 132);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(74, 25);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(76, 204);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(150, 31);
            this.btnSystemInfo.TabIndex = 10;
            this.btnSystemInfo.Text = "System Info";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.nudMemoria);
            this.groupBox1.Controls.Add(this.lblMemoria);
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(273, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Placa De Video";
            // 
            // rtxtSystemInfo
            // 
            this.rtxtSystemInfo.Location = new System.Drawing.Point(12, 255);
            this.rtxtSystemInfo.Name = "rtxtSystemInfo";
            this.rtxtSystemInfo.Size = new System.Drawing.Size(273, 142);
            this.rtxtSystemInfo.TabIndex = 12;
            this.rtxtSystemInfo.Text = "";
            this.rtxtSystemInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 409);
            this.Controls.Add(this.rtxtSystemInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSystemInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodriguez.Abbul.2D";
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown nudMemoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RichTextBox rtxtSystemInfo;
  }
}

