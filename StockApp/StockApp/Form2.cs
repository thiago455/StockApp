using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


 

        private void BTNIng_Click(object sender, EventArgs e)
        {
            addRow(TXTProd.Text, TXTGen.Text, TXTPrec.Text, TXTSto.Text);
        }

        private void addRow(string Producto, string Género, string Precio, string Stock)
        {

            string[] row = { Producto, Género, Precio, Stock };
            dataGridView1.Rows.Add(row);


        
        }

        private void BTNSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTSearch.Text))
            {

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;

            }

            else

            {

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Su búsqueda es:= '{0}'", TXTSearch.Text);

            }



        }

        }

    }
