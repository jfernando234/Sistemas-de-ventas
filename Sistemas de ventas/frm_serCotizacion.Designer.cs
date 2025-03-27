namespace Sistemas_de_ventas
{
    partial class frm_serCotizacion
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
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.bntbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntagregarservicio = new FontAwesome.Sharp.IconButton();
            this.lb10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(942, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(929, 432);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(109, 20);
            this.txttotalpagar.TabIndex = 80;
            this.txttotalpagar.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtplaca);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtidcliente);
            this.groupBox2.Controls.Add(this.bntbuscarcliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(221, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 76);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(181, 43);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(104, 20);
            this.txtplaca.TabIndex = 26;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(6, 42);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(169, 20);
            this.txtnombrecliente.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Placa:";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(298, 15);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(29, 20);
            this.txtidcliente.TabIndex = 28;
            this.txtidcliente.Visible = false;
            // 
            // bntbuscarcliente
            // 
            this.bntbuscarcliente.BackColor = System.Drawing.Color.White;
            this.bntbuscarcliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.bntbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.bntbuscarcliente.IconColor = System.Drawing.Color.Black;
            this.bntbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntbuscarcliente.IconSize = 16;
            this.bntbuscarcliente.Location = new System.Drawing.Point(291, 41);
            this.bntbuscarcliente.Name = "bntbuscarcliente";
            this.bntbuscarcliente.Size = new System.Drawing.Size(36, 21);
            this.bntbuscarcliente.TabIndex = 27;
            this.bntbuscarcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscarcliente.UseVisualStyleBackColor = false;
            this.bntbuscarcliente.Click += new System.EventHandler(this.bntbuscarcliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre / Razon Social:";
            // 
            // btncrearventa
            // 
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.ForestGreen;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.Location = new System.Drawing.Point(929, 458);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Size = new System.Drawing.Size(109, 45);
            this.btncrearventa.TabIndex = 77;
            this.btncrearventa.Text = "Registrar";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncrearventa.UseVisualStyleBackColor = true;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(222, 213);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(691, 290);
            this.dgvdata.TabIndex = 74;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Servicio";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 495;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtdescripcion);
            this.groupBox4.Location = new System.Drawing.Point(564, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 76);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Adicional";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(6, 42);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(337, 20);
            this.txtdescripcion.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtservicio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(221, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 72);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Servicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(330, 41);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(86, 20);
            this.txtprecio.TabIndex = 32;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Servicio:";
            // 
            // txtservicio
            // 
            this.txtservicio.Location = new System.Drawing.Point(9, 41);
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.Size = new System.Drawing.Size(315, 20);
            this.txtservicio.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Registrar Servicios:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(649, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 72);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de venta:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(131, 42);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(127, 21);
            this.cbotipodocumento.TabIndex = 25;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(9, 42);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(116, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // bntagregarservicio
            // 
            this.bntagregarservicio.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bntagregarservicio.IconColor = System.Drawing.Color.ForestGreen;
            this.bntagregarservicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntagregarservicio.Location = new System.Drawing.Point(929, 135);
            this.bntagregarservicio.Name = "bntagregarservicio";
            this.bntagregarservicio.Size = new System.Drawing.Size(101, 76);
            this.bntagregarservicio.TabIndex = 75;
            this.bntagregarservicio.Text = "Agregar";
            this.bntagregarservicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarservicio.UseVisualStyleBackColor = true;
            this.bntagregarservicio.Click += new System.EventHandler(this.bntagregarservicio_Click);
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(194, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(853, 532);
            this.lb10.TabIndex = 67;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_serCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 611);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntagregarservicio);
            this.Controls.Add(this.lb10);
            this.Name = "frm_serCotizacion";
            this.Text = "frm_serCotizacion";
            this.Load += new System.EventHandler(this.frm_serCotizacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidcliente;
        private FontAwesome.Sharp.IconButton bntbuscarcliente;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton bntagregarservicio;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescripcion;
    }
}