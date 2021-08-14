using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_HOTEL
{
    public partial class Principal_Form : Syncfusion.Windows.Forms.Office2010Form
    {
        public Principal_Form()
        {
            InitializeComponent();
        }

        Usuarios_Form formularioUsuario;
        Reserva_Form formularioReserva;
        factura_Form formularioFactura;

        public string CodigoUsuario { get; internal set; }


        private void Usuario_toolStripButton_Click_1(object sender, EventArgs e)
        {
            if (formularioUsuario == null)
            {
                formularioUsuario = new Usuarios_Form();
                formularioUsuario.FormClosed += FormularioUsuario_FormClosed;
                formularioUsuario.Show();
            }
            else
            {
                formularioUsuario.Activate();
            }
        }


        private void FormularioUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioUsuario = null;
        }

        private void Reserva_toolStripButton_Click(object sender, EventArgs e)
        {
            if (formularioReserva == null)
            {
                formularioReserva = new Reserva_Form();
                formularioReserva.FormClosed += FormularioReserva_FormClosed;
                formularioReserva.Show();
            }
            else
            {
                formularioUsuario.Activate();
            }
        }
        private void FormularioReserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioReserva = null;
        }

        private void Factura_toolStripButton_Click(object sender, EventArgs e)
        {
                 if (formularioFactura == null)
            {
                formularioFactura = new factura_Form();
                formularioFactura.FormClosed += FormularioFactura_FormClosed;
                formularioFactura.Show();
            }
            else
            {
                formularioFactura.Activate();
            }
        }
        private void FormularioFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioFactura = null;
        }
    }
}
