namespace Sistemas_de_ventas
{
    partial class frm_DetalleCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.bntbuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttipopago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.btndesarga = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 583);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(537, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Documento:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(648, 60);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(169, 20);
            this.txtbusqueda.TabIndex = 5;
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
            this.bntlimpiar.Location = new System.Drawing.Point(874, 58);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(41, 22);
            this.bntlimpiar.TabIndex = 29;
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
            this.bntbuscar.Location = new System.Drawing.Point(823, 58);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(45, 22);
            this.bntbuscar.TabIndex = 28;
            this.bntbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscar.UseVisualStyleBackColor = false;
            this.bntbuscar.Click += new System.EventHandler(this.bntbuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtusuario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txttipodocumento);
            this.groupBox2.Controls.Add(this.txtfecha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(361, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 76);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Compra";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(375, 41);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(173, 20);
            this.txtusuario.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Usuario:";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Location = new System.Drawing.Point(179, 41);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.ReadOnly = true;
            this.txttipodocumento.Size = new System.Drawing.Size(176, 20);
            this.txttipodocumento.TabIndex = 27;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(9, 41);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(146, 20);
            this.txtfecha.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Documento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txttipopago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtnumerodocumento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnombreproveedor);
            this.groupBox1.Controls.Add(this.txtdocproveedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(361, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 76);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Proveedor";
            // 
            // txttipopago
            // 
            this.txttipopago.Location = new System.Drawing.Point(348, 41);
            this.txttipopago.Name = "txttipopago";
            this.txttipopago.ReadOnly = true;
            this.txttipopago.Size = new System.Drawing.Size(159, 20);
            this.txttipopago.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tipo de pago";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(499, 18);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.ReadOnly = true;
            this.txtnumerodocumento.Size = new System.Drawing.Size(49, 20);
            this.txtnumerodocumento.TabIndex = 30;
            this.txtnumerodocumento.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 29;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(179, 41);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.ReadOnly = true;
            this.txtnombreproveedor.Size = new System.Drawing.Size(159, 20);
            this.txtnombreproveedor.TabIndex = 27;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(9, 41);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.ReadOnly = true;
            this.txtdocproveedor.Size = new System.Drawing.Size(146, 20);
            this.txtdocproveedor.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Razon Social:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Documento Proveedor:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvdata.Location = new System.Drawing.Point(361, 250);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(554, 297);
            this.dgvdata.TabIndex = 33;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(358, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.Location = new System.Drawing.Point(431, 559);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(100, 20);
            this.txtmontototal.TabIndex = 36;
            // 
            // btndesarga
            // 
            this.btndesarga.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btndesarga.IconColor = System.Drawing.Color.Black;
            this.btndesarga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndesarga.Location = new System.Drawing.Point(802, 553);
            this.btndesarga.Name = "btndesarga";
            this.btndesarga.Size = new System.Drawing.Size(113, 30);
            this.btndesarga.TabIndex = 37;
            this.btndesarga.Text = "Descargar PDF";
            this.btndesarga.UseVisualStyleBackColor = true;
            this.btndesarga.Click += new System.EventHandler(this.btndesarga_Click);
            // 
            // frm_DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 630);
            this.Controls.Add(this.btndesarga);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.bntbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DetalleCompra";
            this.Text = "frm_DetalleCompra";
            this.Load += new System.EventHandler(this.frm_DetalleCompra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton bntlimpiar;
        private FontAwesome.Sharp.IconButton bntbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmontototal;
        private FontAwesome.Sharp.IconButton btndesarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox txttipopago;
        private System.Windows.Forms.Label label11;
    }
}