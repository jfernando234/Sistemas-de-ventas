namespace Sistemas_de_ventas
{
    partial class frm_Cotizacion
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
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.bntbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.bntagregarproducto = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(320, 18);
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
            this.bntbuscarcliente.Location = new System.Drawing.Point(313, 40);
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
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre / Razon Social:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(203, 41);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(104, 20);
            this.txtplaca.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Placa:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(7, 41);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(185, 20);
            this.txtnombrecliente.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Producto:";
            // 
            // bntbuscarproducto
            // 
            this.bntbuscarproducto.BackColor = System.Drawing.Color.White;
            this.bntbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntbuscarproducto.ForeColor = System.Drawing.Color.White;
            this.bntbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.bntbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.bntbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntbuscarproducto.IconSize = 16;
            this.bntbuscarproducto.Location = new System.Drawing.Point(132, 42);
            this.bntbuscarproducto.Name = "bntbuscarproducto";
            this.bntbuscarproducto.Size = new System.Drawing.Size(36, 21);
            this.bntbuscarproducto.TabIndex = 29;
            this.bntbuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscarproducto.UseVisualStyleBackColor = false;
            this.bntbuscarproducto.Click += new System.EventHandler(this.bntbuscarproducto_Click);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(102, 19);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(24, 20);
            this.txtidproducto.TabIndex = 29;
            this.txtidproducto.Visible = false;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(10, 42);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(116, 20);
            this.txtcodproducto.TabIndex = 27;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Codigo Producto:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtdescripcion);
            this.groupBox4.Location = new System.Drawing.Point(244, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 76);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Adicional";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(7, 40);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(294, 20);
            this.txtdescripcion.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(949, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(936, 500);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(107, 20);
            this.txttotalpagar.TabIndex = 65;
            this.txttotalpagar.Text = "00";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(174, 43);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(222, 20);
            this.txtproducto.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.txtidcliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtplaca);
            this.groupBox2.Controls.Add(this.bntbuscarcliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(556, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 76);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // btncrearventa
            // 
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.ForestGreen;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.Location = new System.Drawing.Point(936, 532);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Size = new System.Drawing.Size(107, 45);
            this.btncrearventa.TabIndex = 62;
            this.btncrearventa.Text = "Registrar";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncrearventa.UseVisualStyleBackColor = true;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // bntagregarproducto
            // 
            this.bntagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bntagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.bntagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntagregarproducto.Location = new System.Drawing.Point(936, 209);
            this.bntagregarproducto.Name = "bntagregarproducto";
            this.bntagregarproducto.Size = new System.Drawing.Size(99, 72);
            this.bntagregarproducto.TabIndex = 60;
            this.bntagregarproducto.Text = "Agregar";
            this.bntagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarproducto.UseVisualStyleBackColor = true;
            this.bntagregarproducto.Click += new System.EventHandler(this.bntagregarproducto_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(244, 287);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(683, 290);
            this.dgvdata.TabIndex = 59;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.bntbuscarproducto);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(244, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 72);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(494, 44);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(86, 20);
            this.txtstock.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Stock:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(586, 44);
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(92, 20);
            this.txtcantidad.TabIndex = 26;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(402, 44);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(86, 20);
            this.txtprecio.TabIndex = 32;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Registrar Cotizacion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(244, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 76);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de venta:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(132, 42);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(147, 21);
            this.cbotipodocumento.TabIndex = 25;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(10, 42);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(116, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(217, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(843, 594);
            this.lb10.TabIndex = 52;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.bntagregarproducto);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb10);
            this.Name = "frm_Cotizacion";
            this.Load += new System.EventHandler(this.frm_Cotizacion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtidcliente;
        private FontAwesome.Sharp.IconButton bntbuscarcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton bntbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private FontAwesome.Sharp.IconButton bntagregarproducto;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label10;
    }
}