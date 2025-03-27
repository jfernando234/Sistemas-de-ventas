namespace Sistemas_de_ventas
{
    partial class frm_DetalleSerCotizacion
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
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.bntbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndesarga = new FontAwesome.Sharp.IconButton();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.dgvtotal = new System.Windows.Forms.DataGridView();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(107, 39);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(124, 20);
            this.txtnombrecliente.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nombre / Razon Social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 29;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(6, 39);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(92, 20);
            this.txtPlaca.TabIndex = 30;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 425;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(246, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tipo Documento: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdescripcion);
            this.groupBox2.Location = new System.Drawing.Point(326, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 73);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Adicional:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(7, 39);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(321, 20);
            this.txtdescripcion.TabIndex = 33;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(128, 77);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(112, 20);
            this.txtfecha.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Fecha:";
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
            this.bntlimpiar.Location = new System.Drawing.Point(1219, 77);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(41, 22);
            this.bntlimpiar.TabIndex = 102;
            this.bntlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiar.UseVisualStyleBackColor = false;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
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
            this.bntbuscar.Location = new System.Drawing.Point(1168, 77);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(45, 22);
            this.bntbuscar.TabIndex = 101;
            this.bntbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscar.UseVisualStyleBackColor = false;
            this.bntbuscar.Click += new System.EventHandler(this.bntbuscar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(993, 79);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(169, 20);
            this.txtbusqueda.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(950, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Placa:";
            // 
            // btndesarga
            // 
            this.btndesarga.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btndesarga.IconColor = System.Drawing.Color.Black;
            this.btndesarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndesarga.Location = new System.Drawing.Point(556, 508);
            this.btndesarga.Name = "btndesarga";
            this.btndesarga.Size = new System.Drawing.Size(113, 30);
            this.btndesarga.TabIndex = 106;
            this.btndesarga.Text = "Descargar PDF";
            this.btndesarga.UseVisualStyleBackColor = true;
            this.btndesarga.Click += new System.EventHandler(this.btndesarga_Click);
            // 
            // txtmontototal
            // 
            this.txtmontototal.Location = new System.Drawing.Point(149, 505);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.ReadOnly = true;
            this.txtmontototal.Size = new System.Drawing.Size(60, 20);
            this.txtmontototal.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(80, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 114;
            this.label10.Text = "Monto total:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(598, 52);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 111;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(630, 52);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 110;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Location = new System.Drawing.Point(344, 77);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.ReadOnly = true;
            this.txttipodocumento.Size = new System.Drawing.Size(113, 20);
            this.txttipodocumento.TabIndex = 96;
            // 
            // dgvtotal
            // 
            this.dgvtotal.AllowUserToAddRows = false;
            this.dgvtotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdCotizacion,
            this.Placa,
            this.NombreCliente,
            this.DetalleDescripcion,
            this.MontoTotal,
            this.TipoDocumento,
            this.FechaRegistro});
            this.dgvtotal.Location = new System.Drawing.Point(734, 105);
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            this.dgvtotal.Size = new System.Drawing.Size(526, 376);
            this.dgvtotal.TabIndex = 108;
            this.dgvtotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtotal_CellContentClick);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.PrecioVenta});
            this.dgvdata.Location = new System.Drawing.Point(83, 184);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(577, 297);
            this.dgvdata.TabIndex = 105;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(711, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(565, 518);
            this.label11.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Detalle Cotizacion Servicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(85, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 73);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Placa:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 518);
            this.label1.TabIndex = 97;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 50;
            // 
            // IdCotizacion
            // 
            this.IdCotizacion.HeaderText = "IdCotizacion";
            this.IdCotizacion.Name = "IdCotizacion";
            this.IdCotizacion.ReadOnly = true;
            this.IdCotizacion.Visible = false;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 85;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Visible = false;
            this.NombreCliente.Width = 145;
            // 
            // DetalleDescripcion
            // 
            this.DetalleDescripcion.HeaderText = "Detalle";
            this.DetalleDescripcion.Name = "DetalleDescripcion";
            this.DetalleDescripcion.ReadOnly = true;
            this.DetalleDescripcion.Width = 145;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Visible = false;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // frm_DetalleSerCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.bntbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndesarga);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttipodocumento);
            this.Controls.Add(this.dgvtotal);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "frm_DetalleSerCotizacion";
            this.Text = "frm_DetalleSerCotizacion";
            this.Load += new System.EventHandler(this.frm_DetalleSerCotizacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton bntlimpiar;
        private FontAwesome.Sharp.IconButton bntbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btndesarga;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.DataGridView dgvtotal;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}