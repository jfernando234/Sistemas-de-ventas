namespace Sistemas_de_ventas
{
    partial class frm_Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bntbuscar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bntlimpiarr = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lbtxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
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
            this.iconButton2.Location = new System.Drawing.Point(274, 44);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(86, 29);
            this.iconButton2.TabIndex = 97;
            this.iconButton2.Text = "Exportar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(26, 171);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(188, 20);
            this.txttelefono.TabIndex = 96;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Telefono:";
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
            this.bntbuscar.Location = new System.Drawing.Point(1085, 26);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(44, 23);
            this.bntbuscar.TabIndex = 86;
            this.bntbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntbuscar.UseVisualStyleBackColor = false;
            this.bntbuscar.Click += new System.EventHandler(this.bntbuscar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Ruc,
            this.RazonSocial,
            this.Correo,
            this.Telefono});
            this.dgvdata.Location = new System.Drawing.Point(259, 87);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(927, 314);
            this.dgvdata.TabIndex = 80;
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
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ruc
            // 
            this.Ruc.HeaderText = "Ruc";
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            this.Ruc.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 280;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 130;
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
            this.bntlimpiar.Location = new System.Drawing.Point(1135, 26);
            this.bntlimpiar.Name = "bntlimpiar";
            this.bntlimpiar.Size = new System.Drawing.Size(40, 23);
            this.bntlimpiar.TabIndex = 87;
            this.bntlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntlimpiar.UseVisualStyleBackColor = false;
            this.bntlimpiar.Click += new System.EventHandler(this.bntlimpiar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(965, 29);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(114, 20);
            this.txtbusqueda.TabIndex = 85;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(834, 28);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(125, 21);
            this.cbobusqueda.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(767, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Buscar por:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(189, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 82;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 7);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label10.Size = new System.Drawing.Size(923, 73);
            this.label10.TabIndex = 81;
            this.label10.Text = "Lista de Proveedores:";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(158, 37);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 20);
            this.txtindice.TabIndex = 88;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Detalle Proveedores:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.bntlimpiarr.Location = new System.Drawing.Point(35, 332);
            this.bntlimpiarr.Name = "bntlimpiarr";
            this.bntlimpiarr.Size = new System.Drawing.Size(162, 23);
            this.bntlimpiarr.TabIndex = 77;
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
            this.btnguardar.Location = new System.Drawing.Point(35, 303);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(162, 23);
            this.btnguardar.TabIndex = 76;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(35, 361);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(162, 23);
            this.btneliminar.TabIndex = 78;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(26, 60);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(188, 20);
            this.txtruc.TabIndex = 73;
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(26, 99);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(188, 20);
            this.txtrazonsocial.TabIndex = 72;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(26, 135);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(188, 20);
            this.txtcorreo.TabIndex = 71;
            // 
            // lbtxt
            // 
            this.lbtxt.AutoSize = true;
            this.lbtxt.BackColor = System.Drawing.Color.White;
            this.lbtxt.Location = new System.Drawing.Point(23, 119);
            this.lbtxt.Name = "lbtxt";
            this.lbtxt.Size = new System.Drawing.Size(41, 13);
            this.lbtxt.TabIndex = 70;
            this.lbtxt.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "RUC:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 428);
            this.label1.TabIndex = 67;
            // 
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 428);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.bntlimpiarr);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lbtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Proveedores";
            this.Text = "frm_Proveedores";
            this.Load += new System.EventHandler(this.frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
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
        private FontAwesome.Sharp.IconButton bntlimpiarr;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lbtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}