namespace Sistemas_de_ventas
{
    partial class frm_Ventas
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
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.bntagregarproducto = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bntbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.bntbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtkilometraje = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbtipopago = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncrearventa
            // 
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.ForestGreen;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.Location = new System.Drawing.Point(910, 532);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Size = new System.Drawing.Size(107, 45);
            this.btncrearventa.TabIndex = 47;
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
            this.bntagregarproducto.Location = new System.Drawing.Point(910, 209);
            this.bntagregarproducto.Name = "bntagregarproducto";
            this.bntagregarproducto.Size = new System.Drawing.Size(99, 72);
            this.bntagregarproducto.TabIndex = 45;
            this.bntagregarproducto.Text = "Agregar";
            this.bntagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarproducto.UseVisualStyleBackColor = true;
            this.bntagregarproducto.Click += new System.EventHandler(this.bntagregarproducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(923, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(910, 502);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(107, 20);
            this.txtcambio.TabIndex = 43;
            this.txtcambio.Text = "00";
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
            this.dgvdata.Location = new System.Drawing.Point(218, 287);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(683, 290);
            this.dgvdata.TabIndex = 44;
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
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(585, 44);
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
            this.label11.Location = new System.Drawing.Point(582, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cantidad:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(490, 43);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(86, 20);
            this.txtstock.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(395, 43);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(86, 20);
            this.txtprecio.TabIndex = 32;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 76);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de venta:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(131, 42);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(147, 21);
            this.cbotipodocumento.TabIndex = 25;
            this.cbotipodocumento.SelectedIndexChanged += new System.EventHandler(this.cbotipodocumento_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Registrar Venta";
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(191, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(843, 594);
            this.lb10.TabIndex = 38;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.txtruc);
            this.groupBox2.Controls.Add(this.txtidcliente);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.bntbuscarcliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(508, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 76);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(6, 41);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(185, 20);
            this.txtnombrecliente.TabIndex = 27;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(197, 41);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(148, 20);
            this.txtruc.TabIndex = 4;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(358, 18);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(29, 20);
            this.txtidcliente.TabIndex = 28;
            this.txtidcliente.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(197, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ruc:";
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
            this.bntbuscarcliente.Location = new System.Drawing.Point(351, 40);
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
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(166, 41);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(104, 20);
            this.txtplaca.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Placa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Producto:";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(173, 43);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(216, 20);
            this.txtproducto.TabIndex = 26;
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
            this.bntbuscarproducto.Location = new System.Drawing.Point(131, 42);
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
            this.txtidproducto.Location = new System.Drawing.Point(101, 19);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(24, 20);
            this.txtidproducto.TabIndex = 29;
            this.txtidproducto.Visible = false;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 42);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(116, 20);
            this.txtcodproducto.TabIndex = 27;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Codigo Producto:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.bntbuscarproducto);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(218, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 72);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(923, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Pago con:";
            // 
            // txtpagocon
            // 
            this.txtpagocon.Location = new System.Drawing.Point(910, 449);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(107, 20);
            this.txtpagocon.TabIndex = 48;
            this.txtpagocon.Text = "00";
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(923, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(910, 368);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(107, 20);
            this.txttotalpagar.TabIndex = 50;
            this.txttotalpagar.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.txtkilometraje);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtplaca);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(218, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 76);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Vehiculo";
            // 
            // txtkilometraje
            // 
            this.txtkilometraje.Location = new System.Drawing.Point(9, 41);
            this.txtkilometraje.Name = "txtkilometraje";
            this.txtkilometraje.Size = new System.Drawing.Size(138, 20);
            this.txtkilometraje.TabIndex = 26;
            this.txtkilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkilometraje_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kilometraje:";
            // 
            // cmbtipopago
            // 
            this.cmbtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipopago.FormattingEnabled = true;
            this.cmbtipopago.Location = new System.Drawing.Point(529, 87);
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(147, 21);
            this.cmbtipopago.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(526, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tipo de Pago";
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 614);
            this.Controls.Add(this.cmbtipopago);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.btncrearventa);
            this.Controls.Add(this.bntagregarproducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb10);
            this.Name = "frm_Ventas";
            this.Text = "frm_Ventas";
            this.Load += new System.EventHandler(this.frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncrearventa;
        private FontAwesome.Sharp.IconButton bntagregarproducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtidcliente;
        private FontAwesome.Sharp.IconButton bntbuscarcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtproducto;
        private FontAwesome.Sharp.IconButton bntbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtkilometraje;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.ComboBox cmbtipopago;
        private System.Windows.Forms.Label label14;
    }
}