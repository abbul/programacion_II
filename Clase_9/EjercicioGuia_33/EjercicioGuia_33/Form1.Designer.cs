namespace EjercicioGuia_33
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
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.txtAgregar = new System.Windows.Forms.TextBox();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.lblPagina = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtBuscar
      // 
      this.txtBuscar.Location = new System.Drawing.Point(179, 105);
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(156, 20);
      this.txtBuscar.TabIndex = 0;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(179, 149);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(156, 23);
      this.btnBuscar.TabIndex = 1;
      this.btnBuscar.Text = "Buscar Pagina";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtAgregar
      // 
      this.txtAgregar.Location = new System.Drawing.Point(474, 105);
      this.txtAgregar.Name = "txtAgregar";
      this.txtAgregar.Size = new System.Drawing.Size(156, 20);
      this.txtAgregar.TabIndex = 2;
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(474, 149);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(156, 23);
      this.btnAgregar.TabIndex = 3;
      this.btnAgregar.Text = "Agregar Pagina";
      this.btnAgregar.UseVisualStyleBackColor = true;
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Location = new System.Drawing.Point(366, 41);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(88, 13);
      this.lblTitulo.TabIndex = 4;
      this.lblTitulo.Text = "Pagina Buscada:";
      // 
      // lblPagina
      // 
      this.lblPagina.AutoSize = true;
      this.lblPagina.Location = new System.Drawing.Point(460, 41);
      this.lblPagina.Name = "lblPagina";
      this.lblPagina.Size = new System.Drawing.Size(19, 13);
      this.lblPagina.TabIndex = 5;
      this.lblPagina.Text = "__";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblPagina);
      this.Controls.Add(this.lblTitulo);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.txtAgregar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtBuscar);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.TextBox txtAgregar;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblPagina;
  }
}

