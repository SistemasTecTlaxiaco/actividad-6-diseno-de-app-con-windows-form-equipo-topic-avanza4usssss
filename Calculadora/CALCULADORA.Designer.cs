namespace Calculadoraa
{
    partial class CALCULADORA
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
            this.btborrar = new System.Windows.Forms.Button();
            this.btretroceso = new System.Windows.Forms.Button();
            this.btporcentaje = new System.Windows.Forms.Button();
            this.btpotencia = new System.Windows.Forms.Button();
            this.btfraccion = new System.Windows.Forms.Button();
            this.btraiz = new System.Windows.Forms.Button();
            this.btsuma = new System.Windows.Forms.Button();
            this.btresta = new System.Windows.Forms.Button();
            this.btmultiplicacion = new System.Windows.Forms.Button();
            this.btdivision = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btpunto = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btsen = new System.Windows.Forms.Button();
            this.btcos = new System.Windows.Forms.Button();
            this.bttan = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btMenosUno = new System.Windows.Forms.Button();
            this.btFactorial = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btborrar
            // 
            this.btborrar.Location = new System.Drawing.Point(251, 100);
            this.btborrar.Margin = new System.Windows.Forms.Padding(2);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(61, 41);
            this.btborrar.TabIndex = 1;
            this.btborrar.Text = "CE";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // btretroceso
            // 
            this.btretroceso.Location = new System.Drawing.Point(360, 100);
            this.btretroceso.Margin = new System.Windows.Forms.Padding(2);
            this.btretroceso.Name = "btretroceso";
            this.btretroceso.Size = new System.Drawing.Size(61, 41);
            this.btretroceso.TabIndex = 2;
            this.btretroceso.Text = "<---";
            this.btretroceso.UseVisualStyleBackColor = true;
            this.btretroceso.Click += new System.EventHandler(this.btretroceso_Click);
            // 
            // btporcentaje
            // 
            this.btporcentaje.Location = new System.Drawing.Point(274, 163);
            this.btporcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.btporcentaje.Name = "btporcentaje";
            this.btporcentaje.Size = new System.Drawing.Size(68, 41);
            this.btporcentaje.TabIndex = 3;
            this.btporcentaje.Text = "%";
            this.btporcentaje.UseVisualStyleBackColor = true;
            this.btporcentaje.Click += new System.EventHandler(this.btporcentaje_Click);
            // 
            // btpotencia
            // 
            this.btpotencia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btpotencia.Location = new System.Drawing.Point(151, 101);
            this.btpotencia.Margin = new System.Windows.Forms.Padding(2);
            this.btpotencia.Name = "btpotencia";
            this.btpotencia.Size = new System.Drawing.Size(61, 41);
            this.btpotencia.TabIndex = 4;
            this.btpotencia.Text = "X^2";
            this.btpotencia.UseVisualStyleBackColor = false;
            this.btpotencia.Click += new System.EventHandler(this.btpotencia_Click);
            // 
            // btfraccion
            // 
            this.btfraccion.Location = new System.Drawing.Point(40, 385);
            this.btfraccion.Margin = new System.Windows.Forms.Padding(2);
            this.btfraccion.Name = "btfraccion";
            this.btfraccion.Size = new System.Drawing.Size(61, 41);
            this.btfraccion.TabIndex = 5;
            this.btfraccion.Text = "1 / x";
            this.btfraccion.UseVisualStyleBackColor = true;
            this.btfraccion.Click += new System.EventHandler(this.btfraccion_Click);
            // 
            // btraiz
            // 
            this.btraiz.Location = new System.Drawing.Point(199, 163);
            this.btraiz.Margin = new System.Windows.Forms.Padding(2);
            this.btraiz.Name = "btraiz";
            this.btraiz.Size = new System.Drawing.Size(68, 41);
            this.btraiz.TabIndex = 6;
            this.btraiz.Text = "√";
            this.btraiz.UseVisualStyleBackColor = true;
            this.btraiz.Click += new System.EventHandler(this.btraiz_Click);
            // 
            // btsuma
            // 
            this.btsuma.Location = new System.Drawing.Point(353, 268);
            this.btsuma.Margin = new System.Windows.Forms.Padding(2);
            this.btsuma.Name = "btsuma";
            this.btsuma.Size = new System.Drawing.Size(68, 41);
            this.btsuma.TabIndex = 7;
            this.btsuma.Text = "+";
            this.btsuma.UseVisualStyleBackColor = true;
            this.btsuma.Click += new System.EventHandler(this.btsuma_Click);
            // 
            // btresta
            // 
            this.btresta.Location = new System.Drawing.Point(353, 163);
            this.btresta.Margin = new System.Windows.Forms.Padding(2);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(68, 41);
            this.btresta.TabIndex = 8;
            this.btresta.Text = "-";
            this.btresta.UseVisualStyleBackColor = true;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // btmultiplicacion
            // 
            this.btmultiplicacion.Location = new System.Drawing.Point(353, 211);
            this.btmultiplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.btmultiplicacion.Name = "btmultiplicacion";
            this.btmultiplicacion.Size = new System.Drawing.Size(68, 41);
            this.btmultiplicacion.TabIndex = 9;
            this.btmultiplicacion.Text = "*";
            this.btmultiplicacion.UseVisualStyleBackColor = true;
            this.btmultiplicacion.Click += new System.EventHandler(this.btmultiplicacion_Click);
            // 
            // btdivision
            // 
            this.btdivision.Location = new System.Drawing.Point(353, 322);
            this.btdivision.Margin = new System.Windows.Forms.Padding(2);
            this.btdivision.Name = "btdivision";
            this.btdivision.Size = new System.Drawing.Size(68, 41);
            this.btdivision.TabIndex = 10;
            this.btdivision.Text = "/";
            this.btdivision.UseVisualStyleBackColor = true;
            this.btdivision.Click += new System.EventHandler(this.btdivision_Click);
            // 
            // btigual
            // 
            this.btigual.Location = new System.Drawing.Point(353, 385);
            this.btigual.Margin = new System.Windows.Forms.Padding(2);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(68, 41);
            this.btigual.TabIndex = 11;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(117, 211);
            this.bt7.Margin = new System.Windows.Forms.Padding(2);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(70, 41);
            this.bt7.TabIndex = 12;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(199, 211);
            this.bt8.Margin = new System.Windows.Forms.Padding(2);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(68, 41);
            this.bt8.TabIndex = 13;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(274, 211);
            this.bt9.Margin = new System.Windows.Forms.Padding(2);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(68, 41);
            this.bt9.TabIndex = 14;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(117, 268);
            this.bt4.Margin = new System.Windows.Forms.Padding(2);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(70, 41);
            this.bt4.TabIndex = 15;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(117, 322);
            this.bt1.Margin = new System.Windows.Forms.Padding(2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(70, 41);
            this.bt1.TabIndex = 16;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(199, 268);
            this.bt5.Margin = new System.Windows.Forms.Padding(2);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(68, 41);
            this.bt5.TabIndex = 17;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(274, 268);
            this.bt6.Margin = new System.Windows.Forms.Padding(2);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(68, 41);
            this.bt6.TabIndex = 18;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(199, 322);
            this.bt2.Margin = new System.Windows.Forms.Padding(2);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(68, 41);
            this.bt2.TabIndex = 19;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(274, 322);
            this.bt3.Margin = new System.Windows.Forms.Padding(2);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(68, 41);
            this.bt3.TabIndex = 20;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(199, 385);
            this.bt0.Margin = new System.Windows.Forms.Padding(2);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(136, 41);
            this.bt0.TabIndex = 21;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btpunto
            // 
            this.btpunto.Location = new System.Drawing.Point(117, 385);
            this.btpunto.Margin = new System.Windows.Forms.Padding(2);
            this.btpunto.Name = "btpunto";
            this.btpunto.Size = new System.Drawing.Size(70, 41);
            this.btpunto.TabIndex = 22;
            this.btpunto.Text = ".";
            this.btpunto.UseVisualStyleBackColor = true;
            this.btpunto.Click += new System.EventHandler(this.btpunto_Click);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Resultado.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Resultado.Location = new System.Drawing.Point(40, 20);
            this.Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(381, 72);
            this.Resultado.TabIndex = 23;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btsen
            // 
            this.btsen.Location = new System.Drawing.Point(40, 162);
            this.btsen.Name = "btsen";
            this.btsen.Size = new System.Drawing.Size(61, 42);
            this.btsen.TabIndex = 25;
            this.btsen.Text = "sen";
            this.btsen.UseVisualStyleBackColor = true;
            this.btsen.Click += new System.EventHandler(this.btsen_Click);
            // 
            // btcos
            // 
            this.btcos.Location = new System.Drawing.Point(40, 210);
            this.btcos.Name = "btcos";
            this.btcos.Size = new System.Drawing.Size(61, 42);
            this.btcos.TabIndex = 26;
            this.btcos.Text = "cos";
            this.btcos.UseVisualStyleBackColor = true;
            this.btcos.Click += new System.EventHandler(this.btcos_Click);
            // 
            // bttan
            // 
            this.bttan.Location = new System.Drawing.Point(40, 267);
            this.bttan.Name = "bttan";
            this.bttan.Size = new System.Drawing.Size(61, 42);
            this.bttan.TabIndex = 27;
            this.bttan.Text = "tan";
            this.bttan.UseVisualStyleBackColor = true;
            this.bttan.Click += new System.EventHandler(this.bttan_Click);
            // 
            // btlog
            // 
            this.btlog.Location = new System.Drawing.Point(40, 322);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(61, 42);
            this.btlog.TabIndex = 28;
            this.btlog.Text = "log";
            this.btlog.UseVisualStyleBackColor = true;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btMenosUno
            // 
            this.btMenosUno.Location = new System.Drawing.Point(40, 100);
            this.btMenosUno.Name = "btMenosUno";
            this.btMenosUno.Size = new System.Drawing.Size(61, 42);
            this.btMenosUno.TabIndex = 29;
            this.btMenosUno.Text = "X^-1";
            this.btMenosUno.UseVisualStyleBackColor = true;
            this.btMenosUno.Click += new System.EventHandler(this.btMenosUno_Click);
            // 
            // btFactorial
            // 
            this.btFactorial.Location = new System.Drawing.Point(117, 162);
            this.btFactorial.Name = "btFactorial";
            this.btFactorial.Size = new System.Drawing.Size(70, 42);
            this.btFactorial.TabIndex = 30;
            this.btFactorial.Text = "!";
            this.btFactorial.UseVisualStyleBackColor = true;
            this.btFactorial.Click += new System.EventHandler(this.btFactorial_Click);
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.Controls.Add(this.btFactorial);
            this.Controls.Add(this.btMenosUno);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.bttan);
            this.Controls.Add(this.btcos);
            this.Controls.Add(this.btsen);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btpunto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btdivision);
            this.Controls.Add(this.btmultiplicacion);
            this.Controls.Add(this.btresta);
            this.Controls.Add(this.btsuma);
            this.Controls.Add(this.btraiz);
            this.Controls.Add(this.btfraccion);
            this.Controls.Add(this.btpotencia);
            this.Controls.Add(this.btporcentaje);
            this.Controls.Add(this.btretroceso);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CALCULADORA";
            this.Text = "Calculadora Cientifica";
            this.Load += new System.EventHandler(this.CALCULADORA_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btborrar;
        private System.Windows.Forms.Button btretroceso;
        private System.Windows.Forms.Button btporcentaje;
        private System.Windows.Forms.Button btpotencia;
        private System.Windows.Forms.Button btfraccion;
        private System.Windows.Forms.Button btraiz;
        private System.Windows.Forms.Button btsuma;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button btmultiplicacion;
        private System.Windows.Forms.Button btdivision;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btpunto;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btsen;
        private System.Windows.Forms.Button btcos;
        private System.Windows.Forms.Button bttan;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btMenosUno;
        private System.Windows.Forms.Button btFactorial;
    }
}

