namespace triangles
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
            this.tittle = new System.Windows.Forms.Label();
            this.tblado1 = new System.Windows.Forms.TextBox();
            this.tblado2 = new System.Windows.Forms.TextBox();
            this.tblado3 = new System.Windows.Forms.TextBox();
            this.lbllado1 = new System.Windows.Forms.Label();
            this.lbllado2 = new System.Windows.Forms.Label();
            this.lbllado3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Location = new System.Drawing.Point(164, 54);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(223, 17);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Ingrese la medida para cada lado:";
            // 
            // tblado1
            // 
            this.tblado1.Location = new System.Drawing.Point(167, 132);
            this.tblado1.Name = "tblado1";
            this.tblado1.Size = new System.Drawing.Size(100, 22);
            this.tblado1.TabIndex = 1;
            // 
            // tblado2
            // 
            this.tblado2.Location = new System.Drawing.Point(364, 132);
            this.tblado2.Name = "tblado2";
            this.tblado2.Size = new System.Drawing.Size(100, 22);
            this.tblado2.TabIndex = 2;
            // 
            // tblado3
            // 
            this.tblado3.Location = new System.Drawing.Point(591, 132);
            this.tblado3.Name = "tblado3";
            this.tblado3.Size = new System.Drawing.Size(100, 22);
            this.tblado3.TabIndex = 3;
            // 
            // lbllado1
            // 
            this.lbllado1.AutoSize = true;
            this.lbllado1.Location = new System.Drawing.Point(167, 109);
            this.lbllado1.Name = "lbllado1";
            this.lbllado1.Size = new System.Drawing.Size(56, 17);
            this.lbllado1.TabIndex = 4;
            this.lbllado1.Text = "Lado 1:";
            // 
            // lbllado2
            // 
            this.lbllado2.AutoSize = true;
            this.lbllado2.Location = new System.Drawing.Point(364, 109);
            this.lbllado2.Name = "lbllado2";
            this.lbllado2.Size = new System.Drawing.Size(56, 17);
            this.lbllado2.TabIndex = 5;
            this.lbllado2.Text = "Lado 2:";
            // 
            // lbllado3
            // 
            this.lbllado3.AutoSize = true;
            this.lbllado3.Location = new System.Drawing.Point(591, 109);
            this.lbllado3.Name = "lbllado3";
            this.lbllado3.Size = new System.Drawing.Size(56, 17);
            this.lbllado3.TabIndex = 6;
            this.lbllado3.Text = "Lado 3:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(364, 218);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(341, 328);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 17);
            this.lblresult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbllado3);
            this.Controls.Add(this.lbllado2);
            this.Controls.Add(this.lbllado1);
            this.Controls.Add(this.tblado3);
            this.Controls.Add(this.tblado2);
            this.Controls.Add(this.tblado1);
            this.Controls.Add(this.tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.TextBox tblado1;
        private System.Windows.Forms.TextBox tblado2;
        private System.Windows.Forms.TextBox tblado3;
        private System.Windows.Forms.Label lbllado1;
        private System.Windows.Forms.Label lbllado2;
        private System.Windows.Forms.Label lbllado3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresult;
    }
}

