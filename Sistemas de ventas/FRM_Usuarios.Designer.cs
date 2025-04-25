namespace Sistemas_de_ventas
{
    partial class FRM_Usuarios
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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconfirmarclave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.bntlimpiarr = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.bntbuscar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 492);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo: ";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(34, 164);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(188, 20);
            this.txtcorreo.TabIndex = 4;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(34, 116);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(188, 20);
            this.txtnombrecompleto.TabIndex = 5;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(34, 66);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(188, 20);
            this.txtdocumento.TabIndex = 6;
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(34, 212);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(188, 20);
            this.txtclave.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // txtconfirmarclave
            // 
            this.txtconfirmarclave.Location = new System.Drawing.Point(34, 260);
            this.txtconfirmarclave.Name = "txtconfirmarclave";
            this.txtconfirmarclave.PasswordChar = '*';
            this.txtconfirmarclave.Size = new System.Drawing.Size(188, 20);
            this.txtconfirmarclave.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado";
            // 
            // cborol
            // 
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(34, 310);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(188, 21);
            this.cborol.TabIndex = 13;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(34, 359);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(188, 21);
            this.cboestado.TabIndex = 14;
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
            this.btnguardar.Location = new System.Drawing.Point(48, 399);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(162, 23);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.bntlimpiarr.Location = new System.Drawing.Point(48, 428);
            this.bntlimpiarr.Name = "bntlimpiarr";
            this.bntlimpiarr.Size = new System.Drawing.Size(162, 23);
            this.bntlimpiarr.TabIndex = 16;
            this.bntlimpiarr.Text = "Limpiar";
            this.bntlimpiarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiarr.UseVisualStyleBackColor = false;
            this.bntlimpiarr.Click += new System.EventHandler(this.bntlimpiarr_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(48, 457);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(162, 23);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalle Usuario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
<<<<<<< HEAD
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(290, 100);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
<<<<<<< HEAD
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
=======
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(928, 380);
            this.dgvdata.TabIndex = 19;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
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
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Numero Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 200;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstaValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 24);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label10.Size = new System.Drawing.Size(923, 62);
            this.label10.TabIndex = 20;
            this.label10.Text = "Lista de Usuarios";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(197, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 21;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(796, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(863, 48);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(125, 21);
            this.cbobusqueda.TabIndex = 24;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(994, 48);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(114, 20);
            this.txtbusqueda.TabIndex = 25;
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
            this.bntlimpiar.Location = new System.Drawing.Point(1164, 45);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(40, 23);
            this.bntlimpiar.TabIndex = 27;
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
            this.bntbuscar.Location = new System.Drawing.Point(1114, 45);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(44, 23);
            this.bntbuscar.TabIndex = 26;
            this.bntbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscar.UseVisualStyleBackColor = false;
            this.bntbuscar.Click += new System.EventHandler(this.bntbuscar_Click);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(166, 42);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 28;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.Teal;
=======
            this.BackColor = System.Drawing.Color.Black;
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
            this.ClientSize = new System.Drawing.Size(1241, 492);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.bntlimpiar);
            this.Controls.Add(this.bntbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.bntlimpiarr);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cborol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtconfirmarclave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
<<<<<<< HEAD
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
=======
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
            this.Name = "FRM_Usuarios";
            this.Text = "FRM_Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirmarclave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.ComboBox cboestado;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton bntlimpiarr;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton bntlimpiar;
        private FontAwesome.Sharp.IconButton bntbuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtindice;
    }
}