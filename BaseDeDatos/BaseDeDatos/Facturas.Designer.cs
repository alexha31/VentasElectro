
namespace BaseDeDatos
{
    partial class Facturas
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
            this.TabPages = new System.Windows.Forms.TabControl();
            this.TabVisualizar = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MultiLineText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboVisualizar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Textbox_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.Tiempo = new System.Windows.Forms.DateTimePicker();
            this.TxtNombreDeCliente = new System.Windows.Forms.TextBox();
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvNewFac = new System.Windows.Forms.DataGridView();
            this.ProductoCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabPages.SuspendLayout();
            this.TabVisualizar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.TabNueva.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFac)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPages
            // 
            this.TabPages.Controls.Add(this.TabVisualizar);
            this.TabPages.Controls.Add(this.TabNueva);
            this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPages.Location = new System.Drawing.Point(0, 0);
            this.TabPages.Margin = new System.Windows.Forms.Padding(4);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(1112, 566);
            this.TabPages.TabIndex = 0;
            this.TabPages.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabPages_Selecting);
            // 
            // TabVisualizar
            // 
            this.TabVisualizar.Controls.Add(this.groupBox4);
            this.TabVisualizar.Controls.Add(this.groupBox3);
            this.TabVisualizar.Controls.Add(this.groupBox1);
            this.TabVisualizar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabVisualizar.Location = new System.Drawing.Point(4, 29);
            this.TabVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.TabVisualizar.Name = "TabVisualizar";
            this.TabVisualizar.Padding = new System.Windows.Forms.Padding(4);
            this.TabVisualizar.Size = new System.Drawing.Size(1104, 533);
            this.TabVisualizar.TabIndex = 0;
            this.TabVisualizar.Text = "Visualizar";
            this.TabVisualizar.UseVisualStyleBackColor = true;
            this.TabVisualizar.Click += new System.EventHandler(this.TabVisualizar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MultiLineText);
            this.groupBox4.Location = new System.Drawing.Point(564, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 174);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles de la factura:";
            // 
            // MultiLineText
            // 
            this.MultiLineText.BackColor = System.Drawing.Color.Gainsboro;
            this.MultiLineText.Location = new System.Drawing.Point(7, 28);
            this.MultiLineText.Margin = new System.Windows.Forms.Padding(4);
            this.MultiLineText.Multiline = true;
            this.MultiLineText.Name = "MultiLineText";
            this.MultiLineText.ReadOnly = true;
            this.MultiLineText.Size = new System.Drawing.Size(525, 137);
            this.MultiLineText.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboVisualizar);
            this.groupBox3.Location = new System.Drawing.Point(21, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecione el Codigo de la factura:";
            // 
            // comboVisualizar
            // 
            this.comboVisualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.comboVisualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVisualizar.DropDownWidth = 100;
            this.comboVisualizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVisualizar.FormattingEnabled = true;
            this.comboVisualizar.Location = new System.Drawing.Point(22, 42);
            this.comboVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.comboVisualizar.MaxDropDownItems = 4;
            this.comboVisualizar.Name = "comboVisualizar";
            this.comboVisualizar.Size = new System.Drawing.Size(174, 27);
            this.comboVisualizar.TabIndex = 3;
            this.comboVisualizar.SelectedIndexChanged += new System.EventHandler(this.comboVisualizar_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Textbox_total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvVisualizar);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1082, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del producto:";
            // 
            // Textbox_total
            // 
            this.Textbox_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_total.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_total.Location = new System.Drawing.Point(885, 278);
            this.Textbox_total.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_total.Name = "Textbox_total";
            this.Textbox_total.ReadOnly = true;
            this.Textbox_total.Size = new System.Drawing.Size(189, 24);
            this.Textbox_total.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.AllowUserToAddRows = false;
            this.dgvVisualizar.AllowUserToDeleteRows = false;
            this.dgvVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisualizar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVisualizar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisualizar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(8, 31);
            this.dgvVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.ReadOnly = true;
            this.dgvVisualizar.RowHeadersWidth = 51;
            this.dgvVisualizar.Size = new System.Drawing.Size(1066, 239);
            this.dgvVisualizar.TabIndex = 0;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.Tiempo);
            this.TabNueva.Controls.Add(this.TxtNombreDeCliente);
            this.TabNueva.Controls.Add(this.TxtFactura);
            this.TabNueva.Controls.Add(this.groupBox2);
            this.TabNueva.Controls.Add(this.label5);
            this.TabNueva.Controls.Add(this.label4);
            this.TabNueva.Controls.Add(this.label3);
            this.TabNueva.Font = new System.Drawing.Font("Corbel Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Margin = new System.Windows.Forms.Padding(4);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(4);
            this.TabNueva.Size = new System.Drawing.Size(1112, 535);
            this.TabNueva.TabIndex = 1;
            this.TabNueva.Text = "Nueva";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // Tiempo
            // 
            this.Tiempo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.Location = new System.Drawing.Point(218, 125);
            this.Tiempo.Margin = new System.Windows.Forms.Padding(4);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(399, 24);
            this.Tiempo.TabIndex = 6;
            // 
            // TxtNombreDeCliente
            // 
            this.TxtNombreDeCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNombreDeCliente.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreDeCliente.Location = new System.Drawing.Point(218, 70);
            this.TxtNombreDeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreDeCliente.Name = "TxtNombreDeCliente";
            this.TxtNombreDeCliente.Size = new System.Drawing.Size(399, 24);
            this.TxtNombreDeCliente.TabIndex = 5;
            this.TxtNombreDeCliente.Validated += new System.EventHandler(this.TxtNombreDeCliente_Validated);
            // 
            // TxtFactura
            // 
            this.TxtFactura.BackColor = System.Drawing.Color.White;
            this.TxtFactura.Location = new System.Drawing.Point(218, 16);
            this.TxtFactura.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.ReadOnly = true;
            this.TxtFactura.Size = new System.Drawing.Size(79, 24);
            this.TxtFactura.TabIndex = 4;
            this.TxtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFactura.Validated += new System.EventHandler(this.TxtFactura_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvNewFac);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1058, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione los productos e ingrese la cantidad:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(839, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNewFac
            // 
            this.dgvNewFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoCol,
            this.CantidadCol});
            this.dgvNewFac.Location = new System.Drawing.Point(8, 31);
            this.dgvNewFac.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNewFac.Name = "dgvNewFac";
            this.dgvNewFac.RowHeadersWidth = 51;
            this.dgvNewFac.Size = new System.Drawing.Size(773, 281);
            this.dgvNewFac.TabIndex = 0;
            // 
            // ProductoCol
            // 
            this.ProductoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductoCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProductoCol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProductoCol.HeaderText = "Producto";
            this.ProductoCol.MinimumWidth = 6;
            this.ProductoCol.Name = "ProductoCol";
            this.ProductoCol.Sorted = true;
            // 
            // CantidadCol
            // 
            this.CantidadCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantidadCol.HeaderText = "Cantidad";
            this.CantidadCol.MinimumWidth = 6;
            this.CantidadCol.Name = "CantidadCol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de la Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código de la Factura:";
            // 
            // Facturas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1112, 566);
            this.Controls.Add(this.TabPages);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1128, 605);
            this.Name = "Facturas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturas_FormClosing);
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.TabPages.ResumeLayout(false);
            this.TabVisualizar.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage TabVisualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Textbox_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVisualizar;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.DateTimePicker Tiempo;
        private System.Windows.Forms.TextBox TxtNombreDeCliente;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNewFac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox MultiLineText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboVisualizar;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCol;
    }
}