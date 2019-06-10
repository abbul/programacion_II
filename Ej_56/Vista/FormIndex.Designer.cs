namespace Vista
{
  partial class FormIndex
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTitulo,
            this.tsslCantidad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTitulo
            // 
            this.tsslTitulo.Name = "tsslTitulo";
            this.tsslTitulo.Size = new System.Drawing.Size(65, 17);
            this.tsslTitulo.Text = "Caracteres:";
            // 
            // tsslCantidad
            // 
            this.tsslCantidad.Name = "tsslCantidad";
            this.tsslCantidad.Size = new System.Drawing.Size(13, 17);
            this.tsslCantidad.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(671, 288);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(43, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(107, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(277, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Location = new System.Drawing.Point(504, 6);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(117, 23);
            this.btnGuardarComo.TabIndex = 5;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 362);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tsslTitulo;
    private System.Windows.Forms.ToolStripStatusLabel tsslCantidad;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button btnAbrir;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnGuardarComo;
    private System.Windows.Forms.OpenFileDialog openFile;
    private System.Windows.Forms.SaveFileDialog saveFile;
  }
}

