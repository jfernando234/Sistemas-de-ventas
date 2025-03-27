namespace Sistemas_de_ventas
{
    partial class frm_balance
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.lb10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadComprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GananciaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.CantidadComprada,
            this.CantidadVendida,
            this.BalanceInventario,
            this.CostoTotal,
            this.IngresoTotal,
            this.GananciaTotal});
            this.dgvdata.Location = new System.Drawing.Point(32, 79);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(786, 465);
            this.dgvdata.TabIndex = 130;
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(12, 9);
            this.lb10.Name = "lb10";
            this.lb10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lb10.Size = new System.Drawing.Size(834, 562);
            this.lb10.TabIndex = 131;
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 132;
            this.label12.Text = "Balance";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 140;
            // 
            // CantidadComprada
            // 
            this.CantidadComprada.HeaderText = "Cantidad Comprada";
            this.CantidadComprada.Name = "CantidadComprada";
            this.CantidadComprada.Width = 120;
            // 
            // CantidadVendida
            // 
            this.CantidadVendida.HeaderText = "Cantidad Vendida";
            this.CantidadVendida.Name = "CantidadVendida";
            this.CantidadVendida.Width = 120;
            // 
            // BalanceInventario
            // 
            this.BalanceInventario.HeaderText = "Balance Inventario";
            this.BalanceInventario.Name = "BalanceInventario";
            this.BalanceInventario.Width = 120;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.Width = 120;
            // 
            // IngresoTotal
            // 
            this.IngresoTotal.HeaderText = "Ingreso Total";
            this.IngresoTotal.Name = "IngresoTotal";
            this.IngresoTotal.Width = 120;
            // 
            // GananciaTotal
            // 
            this.GananciaTotal.HeaderText = "Ganancia Total";
            this.GananciaTotal.Name = "GananciaTotal";
            this.GananciaTotal.Visible = false;
            this.GananciaTotal.Width = 200;
            // 
            // frm_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 582);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.lb10);
            this.Name = "frm_balance";
            this.Text = "frm_balance";
            this.Load += new System.EventHandler(this.frm_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadComprada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GananciaTotal;
    }
}