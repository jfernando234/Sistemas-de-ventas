namespace Sistemas_de_ventas
{
    partial class frm_Compras
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
            this.lb10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtipopago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcorrelativo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.bntbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntagregarproducto = new FontAwesome.Sharp.IconButton();
            this.txtpreciollevar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.bntbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.bntregistrar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioLlevar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(91, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(1208, 592);
            this.lb10.TabIndex = 21;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbtipopago);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(118, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 76);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion ";
            // 
            // cmbtipopago
            // 
            this.cmbtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipopago.FormattingEnabled = true;
            this.cmbtipopago.Location = new System.Drawing.Point(226, 42);
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(159, 21);
            this.cmbtipopago.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tipo de Pago:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(101, 42);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(119, 21);
            this.cbotipodocumento.TabIndex = 25;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(9, 42);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(86, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 25);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtcorrelativo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtnombreproveedor);
            this.groupBox2.Controls.Add(this.txtdocproveedor);
            this.groupBox2.Controls.Add(this.txtidproveedor);
            this.groupBox2.Controls.Add(this.bntbuscarproveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(513, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 76);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txtcorrelativo
            // 
            this.txtcorrelativo.Location = new System.Drawing.Point(9, 42);
            this.txtcorrelativo.Name = "txtcorrelativo";
            this.txtcorrelativo.Size = new System.Drawing.Size(124, 20);
            this.txtcorrelativo.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Numero Documento:";
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreproveedor.Location = new System.Drawing.Point(259, 41);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(238, 20);
            this.txtnombreproveedor.TabIndex = 27;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(139, 41);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.Size = new System.Drawing.Size(114, 20);
            this.txtdocproveedor.TabIndex = 26;
            this.txtdocproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocproveedor_KeyPress);
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(508, 14);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(29, 20);
            this.txtidproveedor.TabIndex = 28;
            this.txtidproveedor.Visible = false;
            // 
            // bntbuscarproveedor
            // 
            this.bntbuscarproveedor.BackColor = System.Drawing.Color.White;
            this.bntbuscarproveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntbuscarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntbuscarproveedor.ForeColor = System.Drawing.Color.White;
            this.bntbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.bntbuscarproveedor.IconColor = System.Drawing.Color.Black;
            this.bntbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntbuscarproveedor.IconSize = 16;
            this.bntbuscarproveedor.Location = new System.Drawing.Point(508, 40);
            this.bntbuscarproveedor.Name = "bntbuscarproveedor";
            this.bntbuscarproveedor.Size = new System.Drawing.Size(30, 21);
            this.bntbuscarproveedor.TabIndex = 27;
            this.bntbuscarproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscarproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscarproveedor.UseVisualStyleBackColor = false;
            this.bntbuscarproveedor.Click += new System.EventHandler(this.bntbuscarproveedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ruc:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.bntagregarproducto);
            this.groupBox3.Controls.Add(this.txtpreciollevar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtprecioventa);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtpreciocompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.bntbuscarproducto);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(118, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(939, 84);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto:";
            // 
            // bntagregarproducto
            // 
            this.bntagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bntagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.bntagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntagregarproducto.IconSize = 20;
            this.bntagregarproducto.Location = new System.Drawing.Point(733, 38);
            this.bntagregarproducto.Name = "bntagregarproducto";
            this.bntagregarproducto.Size = new System.Drawing.Size(25, 25);
            this.bntagregarproducto.TabIndex = 27;
            this.bntagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarproducto.UseVisualStyleBackColor = true;
            this.bntagregarproducto.Click += new System.EventHandler(this.bntagregarproducto_Click);
            // 
            // txtpreciollevar
            // 
            this.txtpreciollevar.Location = new System.Drawing.Point(655, 42);
            this.txtpreciollevar.Name = "txtpreciollevar";
            this.txtpreciollevar.Size = new System.Drawing.Size(72, 20);
            this.txtpreciollevar.TabIndex = 37;
            this.txtpreciollevar.TextChanged += new System.EventHandler(this.txtpreciollevar_TextChanged);
            this.txtpreciollevar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(652, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Precio Cambio";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(404, 42);
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(67, 20);
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
            this.label11.Location = new System.Drawing.Point(401, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cantidad:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(565, 42);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(83, 20);
            this.txtprecioventa.TabIndex = 34;
            this.txtprecioventa.TextChanged += new System.EventHandler(this.txtprecioventa_TextChanged);
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio Compra:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(482, 42);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(76, 20);
            this.txtpreciocompra.TabIndex = 32;
            this.txtpreciocompra.TextChanged += new System.EventHandler(this.txtpreciocompra_TextChanged);
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio Venta:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.PrecioCompra,
            this.PrecioVenta,
            this.PrecioLlevar,
            this.FechaRegistro,
            this.SubTotal,
            this.IdProducto,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(118, 221);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(939, 365);
            this.dgvdata.TabIndex = 26;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1165, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(1152, 508);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(107, 20);
            this.txttotalpagar.TabIndex = 26;
            this.txttotalpagar.Text = "00";
            // 
            // bntregistrar
            // 
            this.bntregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.bntregistrar.IconColor = System.Drawing.Color.ForestGreen;
            this.bntregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntregistrar.IconSize = 30;
            this.bntregistrar.Location = new System.Drawing.Point(1152, 534);
            this.bntregistrar.Name = "bntregistrar";
            this.bntregistrar.Size = new System.Drawing.Size(107, 45);
            this.bntregistrar.TabIndex = 37;
            this.bntregistrar.Text = "Registrar";
            this.bntregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntregistrar.UseVisualStyleBackColor = true;
            this.bntregistrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(1173, 312);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 29);
            this.iconButton1.TabIndex = 70;
            this.iconButton1.Text = "Importar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Visible = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 80;
            // 
            // PrecioLlevar
            // 
            this.PrecioLlevar.HeaderText = "Precio Cambio";
            this.PrecioLlevar.Name = "PrecioLlevar";
            this.PrecioLlevar.ReadOnly = true;
            this.PrecioLlevar.Width = 80;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Visible = false;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 80;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 30;
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 611);
            this.Controls.Add(this.bntregistrar);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.iconButton1);
            this.Name = "frm_Compras";
            this.Text = "frm_Compras";
            this.Load += new System.EventHandler(this.frm_Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidproveedor;
        private FontAwesome.Sharp.IconButton bntbuscarproveedor;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtproducto;
        private FontAwesome.Sharp.IconButton bntbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton bntagregarproducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalpagar;
        private FontAwesome.Sharp.IconButton bntregistrar;
        private System.Windows.Forms.ComboBox cmbtipopago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcorrelativo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpreciollevar;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioLlevar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}