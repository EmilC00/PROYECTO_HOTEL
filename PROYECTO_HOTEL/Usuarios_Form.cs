using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_HOTEL
{
    public partial class Usuarios_Form : Syncfusion.Windows.Forms.Office2010Form
    {
        public Usuarios_Form()
        {
            InitializeComponent();
        }

        private void Usuarios_Form_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            BaseDatos bd = new BaseDatos();
            Usuarios_dataGridView.DataSource = bd.ListarUsuarios();
        }
    }
}
