namespace StockApp
{
    partial class Form2
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
            this.BTNSearch = new System.Windows.Forms.Button();
            this.TXTSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNIng = new System.Windows.Forms.Button();
            this.TXTPrec = new System.Windows.Forms.TextBox();
            this.TXTGen = new System.Windows.Forms.TextBox();
            this.TXTProd = new System.Windows.Forms.TextBox();
            this.LBLProd = new System.Windows.Forms.Label();
            this.LBLGen = new System.Windows.Forms.Label();
            this.LBLPrecio = new System.Windows.Forms.Label();
            this.LBLStock = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTSto = new System.Windows.Forms.TextBox();
            this.TXTStock = new System.Windows.Forms.Label();
            this.LBLIng = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(270, 105);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(54, 19);
            this.BTNSearch.TabIndex = 11;
            this.BTNSearch.Text = "Buscar";
            this.BTNSearch.UseVisualStyleBackColor = true;
            // 
            // TXTSearch
            // 
            this.TXTSearch.Location = new System.Drawing.Point(49, 70);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.Size = new System.Drawing.Size(243, 20);
            this.TXTSearch.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Género,
            this.Precio,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(512, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 173);
            this.dataGridView1.TabIndex = 13;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Género
            // 
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTNSearch);
            this.groupBox1.Controls.Add(this.TXTSearch);
            this.groupBox1.Location = new System.Drawing.Point(554, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // BTNIng
            // 
            this.BTNIng.Location = new System.Drawing.Point(117, 223);
            this.BTNIng.Name = "BTNIng";
            this.BTNIng.Size = new System.Drawing.Size(75, 23);
            this.BTNIng.TabIndex = 16;
            this.BTNIng.Text = "Añadir";
            this.BTNIng.UseVisualStyleBackColor = true;
            this.BTNIng.Click += new System.EventHandler(this.BTNIng_Click);
            // 
            // TXTPrec
            // 
            this.TXTPrec.Location = new System.Drawing.Point(101, 130);
            this.TXTPrec.Name = "TXTPrec";
            this.TXTPrec.Size = new System.Drawing.Size(100, 20);
            this.TXTPrec.TabIndex = 18;
            // 
            // TXTGen
            // 
            this.TXTGen.Location = new System.Drawing.Point(101, 83);
            this.TXTGen.Name = "TXTGen";
            this.TXTGen.Size = new System.Drawing.Size(100, 20);
            this.TXTGen.TabIndex = 19;
            // 
            // TXTProd
            // 
            this.TXTProd.Location = new System.Drawing.Point(101, 40);
            this.TXTProd.Name = "TXTProd";
            this.TXTProd.Size = new System.Drawing.Size(100, 20);
            this.TXTProd.TabIndex = 20;
            // 
            // LBLProd
            // 
            this.LBLProd.AutoSize = true;
            this.LBLProd.Location = new System.Drawing.Point(19, 47);
            this.LBLProd.Name = "LBLProd";
            this.LBLProd.Size = new System.Drawing.Size(50, 13);
            this.LBLProd.TabIndex = 21;
            this.LBLProd.Text = "Producto";
            // 
            // LBLGen
            // 
            this.LBLGen.AutoSize = true;
            this.LBLGen.Location = new System.Drawing.Point(19, 90);
            this.LBLGen.Name = "LBLGen";
            this.LBLGen.Size = new System.Drawing.Size(42, 13);
            this.LBLGen.TabIndex = 22;
            this.LBLGen.Text = "Género";
            // 
            // LBLPrecio
            // 
            this.LBLPrecio.AutoSize = true;
            this.LBLPrecio.Location = new System.Drawing.Point(19, 137);
            this.LBLPrecio.Name = "LBLPrecio";
            this.LBLPrecio.Size = new System.Drawing.Size(37, 13);
            this.LBLPrecio.TabIndex = 23;
            this.LBLPrecio.Text = "Precio";
            // 
            // LBLStock
            // 
            this.LBLStock.AutoSize = true;
            this.LBLStock.Location = new System.Drawing.Point(19, 183);
            this.LBLStock.Name = "LBLStock";
            this.LBLStock.Size = new System.Drawing.Size(0, 13);
            this.LBLStock.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTSto);
            this.groupBox2.Controls.Add(this.TXTStock);
            this.groupBox2.Controls.Add(this.LBLIng);
            this.groupBox2.Controls.Add(this.BTNIng);
            this.groupBox2.Controls.Add(this.LBLStock);
            this.groupBox2.Controls.Add(this.LBLPrecio);
            this.groupBox2.Controls.Add(this.TXTPrec);
            this.groupBox2.Controls.Add(this.LBLGen);
            this.groupBox2.Controls.Add(this.TXTGen);
            this.groupBox2.Controls.Add(this.LBLProd);
            this.groupBox2.Controls.Add(this.TXTProd);
            this.groupBox2.Location = new System.Drawing.Point(25, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 290);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // TXTSto
            // 
            this.TXTSto.Location = new System.Drawing.Point(101, 176);
            this.TXTSto.Name = "TXTSto";
            this.TXTSto.Size = new System.Drawing.Size(100, 20);
            this.TXTSto.TabIndex = 29;
            // 
            // TXTStock
            // 
            this.TXTStock.AutoSize = true;
            this.TXTStock.Location = new System.Drawing.Point(19, 176);
            this.TXTStock.Name = "TXTStock";
            this.TXTStock.Size = new System.Drawing.Size(76, 13);
            this.TXTStock.TabIndex = 28;
            this.TXTStock.Text = "¿Existe stock?";
            // 
            // LBLIng
            // 
            this.LBLIng.AutoSize = true;
            this.LBLIng.Location = new System.Drawing.Point(76, 1);
            this.LBLIng.Name = "LBLIng";
            this.LBLIng.Size = new System.Drawing.Size(90, 13);
            this.LBLIng.TabIndex = 26;
            this.LBLIng.Text = "Ingresar producto";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.TextBox TXTSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNIng;
        private System.Windows.Forms.TextBox TXTPrec;
        private System.Windows.Forms.TextBox TXTGen;
        private System.Windows.Forms.TextBox TXTProd;
        private System.Windows.Forms.Label LBLProd;
        private System.Windows.Forms.Label LBLGen;
        private System.Windows.Forms.Label LBLPrecio;
        private System.Windows.Forms.Label LBLStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBLIng;
        private System.Windows.Forms.Label TXTStock;
        private System.Windows.Forms.TextBox TXTSto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}