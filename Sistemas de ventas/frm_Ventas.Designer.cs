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
            this.label10 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtkilometraje = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbtipopago = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.bntagregarproducto = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.bntbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvdataser = new System.Windows.Forms.DataGridView();
            this.Ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminars = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataser)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrearventa
            // 
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btncrearventa.IconColor = System.Drawing.Color.ForestGreen;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.Location = new System.Drawing.Point(42, 244);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Size = new System.Drawing.Size(107, 45);
            this.btncrearventa.TabIndex = 47;
            this.btncrearventa.Text = "Registrar";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncrearventa.UseVisualStyleBackColor = true;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(82, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Vuelto:";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(25, 166);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(147, 20);
            this.txtcambio.TabIndex = 43;
            this.txtcambio.Text = "00";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(90, 414);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(548, 207);
            this.dgvdata.TabIndex = 44;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(106, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 76);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de venta:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(131, 40);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(147, 21);
            this.cbotipodocumento.TabIndex = 25;
            this.cbotipodocumento.SelectedIndexChanged += new System.EventHandler(this.cbotipodocumento_SelectedIndexChanged);
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(9, 41);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(116, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 24);
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
            this.label1.Location = new System.Drawing.Point(101, 28);
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
            this.lb10.Location = new System.Drawing.Point(80, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(934, 306);
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
            this.groupBox2.Location = new System.Drawing.Point(400, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 76);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(6, 41);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(273, 20);
            this.txtnombrecliente.TabIndex = 27;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(285, 40);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(129, 20);
            this.txtruc.TabIndex = 4;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(420, 17);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(36, 20);
            this.txtidcliente.TabIndex = 28;
            this.txtidcliente.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(282, 24);
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
            this.bntbuscarcliente.Location = new System.Drawing.Point(420, 40);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Pago con:";
            // 
            // txtpagocon
            // 
            this.txtpagocon.Location = new System.Drawing.Point(25, 114);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(147, 20);
            this.txtpagocon.TabIndex = 48;
            this.txtpagocon.Text = "00";
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(66, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(25, 218);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(147, 20);
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
            this.groupBox4.Location = new System.Drawing.Point(106, 159);
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
            this.cmbtipopago.Location = new System.Drawing.Point(25, 57);
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(147, 21);
            this.cmbtipopago.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(54, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Metodo de Pago";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmbtipopago);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtcambio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txttotalpagar);
            this.panel1.Controls.Add(this.txtpagocon);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btncrearventa);
            this.panel1.Location = new System.Drawing.Point(1020, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 303);
            this.panel1.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 52;
            // 
            // bntagregarproducto
            // 
            this.bntagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bntagregarproducto.IconColor = System.Drawing.Color.ForestGreen;
            this.bntagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntagregarproducto.IconSize = 20;
            this.bntagregarproducto.Location = new System.Drawing.Point(520, 43);
            this.bntagregarproducto.Name = "bntagregarproducto";
            this.bntagregarproducto.Size = new System.Drawing.Size(25, 23);
            this.bntagregarproducto.TabIndex = 45;
            this.bntagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntagregarproducto.UseVisualStyleBackColor = true;
            this.bntagregarproducto.Click += new System.EventHandler(this.bntagregarproducto_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(667, 365);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(59, 42);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "Servicio";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.bntagregarproducto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.bntbuscarproducto);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(90, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 72);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUCTO";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(461, 45);
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(53, 20);
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
            this.label11.Location = new System.Drawing.Point(462, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cantidad:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(401, 44);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(53, 20);
            this.txtstock.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(342, 44);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(53, 20);
            this.txtprecio.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descripcion:";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(143, 43);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(193, 20);
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
            this.bntbuscarproducto.Location = new System.Drawing.Point(101, 41);
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
            this.txtidproducto.Location = new System.Drawing.Point(309, 17);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(24, 20);
            this.txtidproducto.TabIndex = 29;
            this.txtidproducto.Visible = false;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 42);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(86, 20);
            this.txtcodproducto.TabIndex = 27;
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
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(80, 322);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label18.Size = new System.Drawing.Size(567, 312);
            this.label18.TabIndex = 55;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(653, 322);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label19.Size = new System.Drawing.Size(568, 312);
            this.label19.TabIndex = 56;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvdataser
            // 
            this.dgvdataser.AllowUserToAddRows = false;
            this.dgvdataser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ids,
            this.Descripcions,
            this.Cantidads,
            this.Precios,
            this.SubTotals,
            this.btneliminars});
            this.dgvdataser.Location = new System.Drawing.Point(667, 415);
            this.dgvdataser.Name = "dgvdataser";
            this.dgvdataser.ReadOnly = true;
            this.dgvdataser.Size = new System.Drawing.Size(546, 206);
            this.dgvdataser.TabIndex = 57;
            this.dgvdataser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataser_CellContentClick);
            // 
            // Ids
            // 
            this.Ids.HeaderText = "Id";
            this.Ids.Name = "Ids";
            this.Ids.ReadOnly = true;
            this.Ids.Visible = false;
            // 
            // Descripcions
            // 
            this.Descripcions.HeaderText = "Descripcion";
            this.Descripcions.Name = "Descripcions";
            this.Descripcions.ReadOnly = true;
            this.Descripcions.Width = 300;
            // 
            // Cantidads
            // 
            this.Cantidads.HeaderText = "Cantidad";
            this.Cantidads.Name = "Cantidads";
            this.Cantidads.ReadOnly = true;
            this.Cantidads.Visible = false;
            // 
            // Precios
            // 
            this.Precios.HeaderText = "Precio";
            this.Precios.Name = "Precios";
            this.Precios.ReadOnly = true;
            this.Precios.Width = 80;
            // 
            // SubTotals
            // 
            this.SubTotals.HeaderText = "Sub Total";
            this.SubTotals.Name = "SubTotals";
            this.SubTotals.ReadOnly = true;
            this.SubTotals.Width = 80;
            // 
            // btneliminars
            // 
            this.btneliminars.HeaderText = "";
            this.btneliminars.Name = "btneliminars";
            this.btneliminars.ReadOnly = true;
            this.btneliminars.Width = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(662, 337);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 25);
            this.label20.TabIndex = 58;
            this.label20.Text = "Servicios";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 220;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
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
            this.btneliminar.Width = 43;
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 655);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.dgvdataser);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Name = "frm_Ventas";
            this.Text = "frm_Ventas";
            this.Load += new System.EventHandler(this.frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncrearventa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.DataGridView dgvdata;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtkilometraje;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbtipopago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconButton bntagregarproducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtproducto;
        private FontAwesome.Sharp.IconButton bntbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvdataser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precios;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotals;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}