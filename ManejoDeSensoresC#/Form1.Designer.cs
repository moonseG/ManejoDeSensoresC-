namespace ManejoDeSensoresC_
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
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConeccion = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconectar.ForeColor = System.Drawing.Color.Blue;
            this.BtnDesconectar.Location = new System.Drawing.Point(304, 256);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(163, 62);
            this.BtnDesconectar.TabIndex = 0;
            this.BtnDesconectar.Text = "Desconectar";
            this.BtnDesconectar.UseVisualStyleBackColor = true;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnConectar.Location = new System.Drawing.Point(100, 256);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(135, 62);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "limite de Temperatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbConeccion
            // 
            this.lbConeccion.AutoSize = true;
            this.lbConeccion.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConeccion.Location = new System.Drawing.Point(96, 169);
            this.lbConeccion.Name = "lbConeccion";
            this.lbConeccion.Size = new System.Drawing.Size(139, 22);
            this.lbConeccion.TabIndex = 4;
            this.lbConeccion.Text = "Sin conexion";
            this.lbConeccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.Red;
            this.lbTemp.Location = new System.Drawing.Point(297, 135);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(185, 97);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "0.0";
            this.lbTemp.Click += new System.EventHandler(this.lbTemp_Click);
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLimTemp.ForeColor = System.Drawing.Color.Maroon;
            this.tbLimTemp.Location = new System.Drawing.Point(120, 109);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(99, 30);
            this.tbLimTemp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(552, 363);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbConeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnDesconectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConeccion;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbLimTemp;
    }
}

