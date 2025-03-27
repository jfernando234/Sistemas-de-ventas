namespace Sistemas_de_ventas
{
    partial class frm_Negocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtguardar = new FontAwesome.Sharp.IconButton();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntsubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Detalle Negocio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 431);
            this.label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtguardar);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bntsubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Location = new System.Drawing.Point(28, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 272);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtguardar
            // 
            this.txtguardar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.txtguardar.IconColor = System.Drawing.Color.Black;
            this.txtguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtguardar.IconSize = 21;
            this.txtguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtguardar.Location = new System.Drawing.Point(206, 191);
            this.txtguardar.Name = "txtguardar";
            this.txtguardar.Size = new System.Drawing.Size(295, 23);
            this.txtguardar.TabIndex = 9;
            this.txtguardar.Text = "Guardar cambios";
            this.txtguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtguardar.UseVisualStyleBackColor = true;
            this.txtguardar.Click += new System.EventHandler(this.txtguardar_Click);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(206, 105);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(295, 20);
            this.txtruc.TabIndex = 8;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(206, 154);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(295, 20);
            this.txtdireccion.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(206, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(295, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RUC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre negocio";
            // 
            // bntsubir
            // 
            this.bntsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.bntsubir.IconColor = System.Drawing.Color.Black;
            this.bntsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntsubir.IconSize = 21;
            this.bntsubir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntsubir.Location = new System.Drawing.Point(25, 191);
            this.bntsubir.Name = "bntsubir";
            this.bntsubir.Size = new System.Drawing.Size(156, 23);
            this.bntsubir.TabIndex = 2;
            this.bntsubir.Text = "Subir";
            this.bntsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntsubir.UseVisualStyleBackColor = true;
            this.bntsubir.Click += new System.EventHandler(this.bntsubir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo:";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(25, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(156, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frm_Negocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frm_Negocio";
            this.Text = "frm_Negocio";
            this.Load += new System.EventHandler(this.frm_Negocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton bntsubir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton txtguardar;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}