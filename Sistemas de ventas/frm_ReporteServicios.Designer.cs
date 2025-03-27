namespace Sistemas_de_ventas
{
    partial class frm_ReporteServicios
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
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.exportarexcel = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscarresultado = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // bntlimpiar
            // 
            this.bntlimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.bntlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.bntlimpiar.ForeColor = System.Drawing.Color.White;
            this.bntlimpiar.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.bntlimpiar.IconColor = System.Drawing.Color.Black;
            this.bntlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntlimpiar.IconSize = 17;
            this.bntlimpiar.Location = new System.Drawing.Point(1325, 132);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(40, 22);
            this.bntlimpiar.TabIndex = 135;
            this.bntlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiar.UseVisualStyleBackColor = false;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(1091, 133);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(182, 20);
            this.txtbusqueda.TabIndex = 134;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(1279, 132);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(40, 22);
            this.btnbuscar.TabIndex = 133;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(868, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Buscar por: ";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(938, 132);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(132, 21);
            this.cbobusqueda.TabIndex = 131;
            // 
            // exportarexcel
            // 
            this.exportarexcel.BackColor = System.Drawing.Color.ForestGreen;
            this.exportarexcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportarexcel.ForeColor = System.Drawing.Color.White;
            this.exportarexcel.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.exportarexcel.IconColor = System.Drawing.Color.White;
            this.exportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportarexcel.IconSize = 16;
            this.exportarexcel.Location = new System.Drawing.Point(23, 128);
            this.exportarexcel.Name = "exportarexcel";
            this.exportarexcel.Size = new System.Drawing.Size(120, 29);
            this.exportarexcel.TabIndex = 130;
            this.exportarexcel.Text = "Exportar Excel";
            this.exportarexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportarexcel.UseVisualStyleBackColor = false;
            this.exportarexcel.Click += new System.EventHandler(this.exportarexcel_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.Ruc,
            this.Placa,
            this.NombreCliente,
            this.Descripcion,
            this.SubTotal});
            this.dgvdata.Location = new System.Drawing.Point(23, 163);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(1342, 465);
            this.dgvdata.TabIndex = 129;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Width = 120;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Width = 120;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.Width = 130;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // Ruc
            // 
            this.Ruc.HeaderText = "Ruc";
            this.Ruc.Name = "Ruc";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1370, 533);
            this.label4.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1367, 91);
            this.label1.TabIndex = 122;
            // 
            // btnbuscarresultado
            // 
            this.btnbuscarresultado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscarresultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarresultado.ForeColor = System.Drawing.Color.White;
            this.btnbuscarresultado.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnbuscarresultado.IconColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarresultado.IconSize = 16;
            this.btnbuscarresultado.Location = new System.Drawing.Point(444, 49);
            this.btnbuscarresultado.Name = "btnbuscarresultado";
            this.btnbuscarresultado.Size = new System.Drawing.Size(45, 22);
            this.btnbuscarresultado.TabIndex = 127;
            this.btnbuscarresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarresultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarresultado.UseVisualStyleBackColor = false;
            this.btnbuscarresultado.Click += new System.EventHandler(this.btnbuscarresultado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 126;
            this.label7.Text = "Fecha Fin:";
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(330, 51);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(95, 20);
            this.txtfechafin.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 123;
            this.label2.Text = "Reporte Servicios";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(117, 51);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(95, 20);
            this.txtfechainicio.TabIndex = 121;
            // 
            // frm_ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 654);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.exportarexcel);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnbuscarresultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frm_ReporteServicios";
            this.Text = "frm_ReporteServicios";
            this.Load += new System.EventHandler(this.frm_ReporteServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton bntlimpiar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private FontAwesome.Sharp.IconButton exportarexcel;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnbuscarresultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}