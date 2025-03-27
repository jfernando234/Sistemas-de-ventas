namespace Sistemas_de_ventas
{
    partial class frm_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntbuscar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.bntlimpiarr = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtunidadmedida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // bntbuscar
            // 
            this.bntbuscar.BackColor = System.Drawing.Color.White;
            this.bntbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntbuscar.ForeColor = System.Drawing.Color.White;
            this.bntbuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.bntbuscar.IconColor = System.Drawing.Color.Black;
            this.bntbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntbuscar.IconSize = 16;
            this.bntbuscar.Location = new System.Drawing.Point(1085, 28);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(44, 23);
            this.bntbuscar.TabIndex = 54;
            this.bntbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscar.UseVisualStyleBackColor = false;
            this.bntbuscar.Click += new System.EventHandler(this.bntbuscar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.Stock,
            this.Ubicacion,
            this.PrecioVenta,
            this.PrecioCompra,
            this.Unidadmedida,
            this.IdCategoria,
            this.Categoria});
            this.dgvdata.Location = new System.Drawing.Point(259, 89);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(927, 501);
            this.dgvdata.TabIndex = 48;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // bntlimpiar
            // 
            this.bntlimpiar.BackColor = System.Drawing.Color.White;
            this.bntlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.bntlimpiar.ForeColor = System.Drawing.Color.White;
            this.bntlimpiar.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.bntlimpiar.IconColor = System.Drawing.Color.Black;
            this.bntlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntlimpiar.IconSize = 17;
            this.bntlimpiar.Location = new System.Drawing.Point(1135, 28);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(40, 23);
            this.bntlimpiar.TabIndex = 55;
            this.bntlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiar.UseVisualStyleBackColor = false;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(965, 31);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(114, 20);
            this.txtbusqueda.TabIndex = 53;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(834, 30);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(125, 21);
            this.cbobusqueda.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(767, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Buscar por:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(189, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 50;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 9);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label10.Size = new System.Drawing.Size(923, 73);
            this.label10.TabIndex = 49;
            this.label10.Text = "Lista de Productos:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(158, 39);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 56;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Detalle Productos:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 20;
            this.btneliminar.Location = new System.Drawing.Point(40, 533);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(162, 23);
            this.btneliminar.TabIndex = 46;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bntlimpiarr
            // 
            this.bntlimpiarr.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntlimpiarr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntlimpiarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlimpiarr.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.bntlimpiarr.ForeColor = System.Drawing.Color.White;
            this.bntlimpiarr.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.bntlimpiarr.IconColor = System.Drawing.Color.White;
            this.bntlimpiarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntlimpiarr.IconSize = 17;
            this.bntlimpiarr.Location = new System.Drawing.Point(40, 504);
            this.bntlimpiarr.Name = "bntlimpiarr";
            this.bntlimpiarr.Size = new System.Drawing.Size(162, 23);
            this.bntlimpiarr.TabIndex = 45;
            this.bntlimpiarr.Text = "Limpiar";
            this.bntlimpiarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiarr.UseVisualStyleBackColor = false;
            this.bntlimpiarr.Click += new System.EventHandler(this.bntlimpiarr_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(40, 475);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(162, 23);
            this.btnguardar.TabIndex = 44;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cbocategoria
            // 
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(26, 445);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(188, 21);
            this.cbocategoria.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Categoria:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(26, 62);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(188, 20);
            this.txtcodigo.TabIndex = 35;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(26, 107);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(188, 108);
            this.txtdescripcion.TabIndex = 33;
            // 
            // lbtxt
            // 
            this.lbtxt.AutoSize = true;
            this.lbtxt.BackColor = System.Drawing.Color.White;
            this.lbtxt.Location = new System.Drawing.Point(23, 91);
            this.lbtxt.Name = "lbtxt";
            this.lbtxt.Size = new System.Drawing.Size(66, 13);
            this.lbtxt.TabIndex = 32;
            this.lbtxt.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 602);
            this.label1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Unidad de medida";
            // 
            // txtunidadmedida
            // 
            this.txtunidadmedida.Location = new System.Drawing.Point(26, 403);
            this.txtunidadmedida.Name = "txtunidadmedida";
            this.txtunidadmedida.Size = new System.Drawing.Size(188, 20);
            this.txtunidadmedida.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Ubicacion:";
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(26, 361);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(188, 20);
            this.txtubicacion.TabIndex = 60;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(26, 277);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(188, 20);
            this.txtprecioventa.TabIndex = 61;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(23, 261);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(70, 13);
            this.lab.TabIndex = 62;
            this.lab.Text = "Precio venta:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(26, 235);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(188, 20);
            this.txtstock.TabIndex = 64;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Stock";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(274, 46);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(86, 29);
            this.iconButton2.TabIndex = 66;
            this.iconButton2.Text = "Exportar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Precio Compra:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(26, 322);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(188, 20);
            this.txtpreciocompra.TabIndex = 67;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
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
            this.iconButton1.Location = new System.Drawing.Point(390, 46);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 29);
            this.iconButton1.TabIndex = 69;
            this.iconButton1.Text = "Importar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 70;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 70;
            // 
            // Unidadmedida
            // 
            this.Unidadmedida.HeaderText = "Unidad medida";
            this.Unidadmedida.Name = "Unidadmedida";
            this.Unidadmedida.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 602);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtunidadmedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntbuscar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.bntlimpiarr);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Producto";
            this.Text = "frm_Producto";
            this.Load += new System.EventHandler(this.frm_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton bntbuscar;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton bntlimpiar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton bntlimpiarr;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtunidadmedida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}