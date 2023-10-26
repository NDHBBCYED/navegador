namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.WEB = new System.Windows.Forms.WebBrowser();
            this.ARAS = new System.Windows.Forms.Button();
            this.ADELANTE = new System.Windows.Forms.Button();
            this.PARAR = new System.Windows.Forms.Button();
            this.ACTUALIZAR = new System.Windows.Forms.Button();
            this.INICIO = new System.Windows.Forms.Button();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.DIRECCION = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DIRECCION);
            this.panel1.Controls.Add(this.BUSCAR);
            this.panel1.Controls.Add(this.INICIO);
            this.panel1.Controls.Add(this.ACTUALIZAR);
            this.panel1.Controls.Add(this.PARAR);
            this.panel1.Controls.Add(this.ADELANTE);
            this.panel1.Controls.Add(this.ARAS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 79);
            this.panel1.TabIndex = 0;
            // 
            // WEB
            // 
            this.WEB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WEB.Location = new System.Drawing.Point(0, 79);
            this.WEB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB.Name = "WEB";
            this.WEB.Size = new System.Drawing.Size(692, 371);
            this.WEB.TabIndex = 1;
            this.WEB.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WEB_DocumentCompleted);
            // 
            // ARAS
            // 
            this.ARAS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ARAS.BackgroundImage")));
            this.ARAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ARAS.Location = new System.Drawing.Point(12, 12);
            this.ARAS.Name = "ARAS";
            this.ARAS.Size = new System.Drawing.Size(60, 57);
            this.ARAS.TabIndex = 0;
            this.ARAS.UseVisualStyleBackColor = true;
            this.ARAS.Click += new System.EventHandler(this.ARAS_Click);
            // 
            // ADELANTE
            // 
            this.ADELANTE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ADELANTE.BackgroundImage")));
            this.ADELANTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADELANTE.Location = new System.Drawing.Point(78, 12);
            this.ADELANTE.Name = "ADELANTE";
            this.ADELANTE.Size = new System.Drawing.Size(60, 57);
            this.ADELANTE.TabIndex = 1;
            this.ADELANTE.UseVisualStyleBackColor = true;
            this.ADELANTE.Click += new System.EventHandler(this.ADELANTE_Click);
            // 
            // PARAR
            // 
            this.PARAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PARAR.BackgroundImage")));
            this.PARAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PARAR.Location = new System.Drawing.Point(144, 12);
            this.PARAR.Name = "PARAR";
            this.PARAR.Size = new System.Drawing.Size(60, 57);
            this.PARAR.TabIndex = 2;
            this.PARAR.UseVisualStyleBackColor = true;
            this.PARAR.Click += new System.EventHandler(this.PARAR_Click);
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ACTUALIZAR.BackgroundImage")));
            this.ACTUALIZAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ACTUALIZAR.Location = new System.Drawing.Point(219, 12);
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Size = new System.Drawing.Size(60, 57);
            this.ACTUALIZAR.TabIndex = 3;
            this.ACTUALIZAR.UseVisualStyleBackColor = true;
            this.ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // INICIO
            // 
            this.INICIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("INICIO.BackgroundImage")));
            this.INICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.INICIO.Location = new System.Drawing.Point(302, 12);
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(60, 57);
            this.INICIO.TabIndex = 4;
            this.INICIO.UseVisualStyleBackColor = true;
            this.INICIO.Click += new System.EventHandler(this.INICIO_Click);
            // 
            // BUSCAR
            // 
            this.BUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BUSCAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUSCAR.BackgroundImage")));
            this.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUSCAR.Location = new System.Drawing.Point(621, 12);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(60, 57);
            this.BUSCAR.TabIndex = 5;
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // DIRECCION
            // 
            this.DIRECCION.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DIRECCION.Location = new System.Drawing.Point(373, 26);
            this.DIRECCION.Multiline = true;
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.Size = new System.Drawing.Size(238, 30);
            this.DIRECCION.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.WEB);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador web";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser WEB;
        private System.Windows.Forms.Button ACTUALIZAR;
        private System.Windows.Forms.Button PARAR;
        private System.Windows.Forms.Button ADELANTE;
        private System.Windows.Forms.Button ARAS;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.Button INICIO;
        private System.Windows.Forms.TextBox DIRECCION;
    }
}

