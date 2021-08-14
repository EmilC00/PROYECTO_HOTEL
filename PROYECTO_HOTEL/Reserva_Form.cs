using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_HOTEL
{
    public partial class Reserva_Form : Syncfusion.Windows.Forms.Office2010Form
    {
        public Reserva_Form()
        {
            InitializeComponent();
        }

        private string Operacion = string.Empty;
        private void Reserva_Form_Load(object sender, EventArgs e)
        {
            Llenar_Tip_hab();
            ListarReserva();
        }

        private void Llenar_Tip_hab()
        {
            BaseDatos bd = new BaseDatos();
            Tip_Hab_comboBox.DataSource = bd.CargarTipoHabitacion();
            Tip_Hab_comboBox.DisplayMember = "DESCRIPCION";
            Tip_Hab_comboBox.ValueMember = "ID";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo";
            Habilitar_Controles();
            txt_cliente.Focus();

        }

        private void Habilitar_Controles()
        {
            txt_cliente.Enabled = true;
            Tip_Hab_comboBox.Enabled = true;
            txt_numdias.Enabled = true;
            txt_precio.Enabled = true;
            txt_codigo.Enabled = true;
        }

        private void Inhabilitar_Controles()
        {
            txt_cliente.Enabled = false;
            Tip_Hab_comboBox.Enabled = false;
            txt_numdias.Enabled = false;
            txt_precio.Enabled = false;
            txt_codigo.Enabled = false;
        }


        private void Limpiar_Controles()
        {
            txt_cliente.Clear();
            txt_numdias.Clear();
            txt_precio.Clear();
            txt_codigo.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text))
            {
                errorProvider1.SetError(txt_codigo, "Ingrese un código");
                txt_codigo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorProvider1.SetError(txt_precio, "Ingrese un precio");
                txt_precio.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_cliente.Text))
            {
                errorProvider1.SetError(txt_cliente, "Ingrese nombre del cliente");
                txt_cliente.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_numdias.Text))
            {
                errorProvider1.SetError(txt_numdias, "Ingrese numero de dias");
                txt_numdias.Focus();
                return;
            }

            BaseDatos bd = new BaseDatos();
            if (Operacion == "Nuevo")
            {
                bool inserto = bd.InsertarReserva(txt_codigo.Text, txt_cliente.Text, Convert.ToInt32(Tip_Hab_comboBox.SelectedValue), Convert.ToDecimal(txt_precio.Text), Convert.ToInt32(txt_numdias.Text));


                ListarReserva();
                Limpiar_Controles();
                Inhabilitar_Controles();
            }

            else if (Operacion == "Modificar")
            {
                bool modifico = bd.EditarReserva(txt_numdias.Text, txt_cliente.Text, Convert.ToInt32(Tip_Hab_comboBox.SelectedValue), Convert.ToDecimal(txt_precio.Text), Convert.ToInt32(txt_numdias.Text));
                ListarReserva();
                Limpiar_Controles();
                Inhabilitar_Controles();
            }
        }
        

    private void ListarReserva()
        {
            BaseDatos bd = new BaseDatos();
            reserva_dataGridView.DataSource = bd.ListarReserva();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Operacion = "Modificar";
            BaseDatos bd = new BaseDatos();
            if (reserva_dataGridView.SelectedRows.Count > 0)
            {
                txt_codigo.Text = reserva_dataGridView.CurrentRow.Cells["CODIGO"].Value.ToString();
                txt_cliente.Text = reserva_dataGridView.CurrentRow.Cells["CLIENTE"].Value.ToString();
                txt_precio.Text = reserva_dataGridView.CurrentRow.Cells["PRECIO"].Value.ToString();
                txt_numdias.Text = reserva_dataGridView.CurrentRow.Cells["DIAS_ESTADIA"].Value.ToString();
 
                Habilitar_Controles();
                Tip_Hab_comboBox.Focus();
                txt_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

            }
        }
}
