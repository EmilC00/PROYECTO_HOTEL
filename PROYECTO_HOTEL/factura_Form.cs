using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_HOTEL
{
    public partial class factura_Form : Syncfusion.Windows.Forms.Office2010Form
    {
        public factura_Form()
        {
            InitializeComponent();
        }

        private void factura_Form_Load(object sender, EventArgs e)
        {
            ListarFactura();
        }

        private void ListarFactura()
        {
            BaseDatos bd = new BaseDatos();
            factura_dataGridView.DataSource = bd.ListarFactura();
        }
    }
}
