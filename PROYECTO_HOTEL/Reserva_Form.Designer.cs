
namespace PROYECTO_HOTEL
{
    partial class Reserva_Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tip_hab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_numdias = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.reserva_dataGridView = new System.Windows.Forms.DataGridView();
            this.Tip_Hab_comboBox = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reserva_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Cliente:";
            // 
            // lbl_tip_hab
            // 
            this.lbl_tip_hab.AutoSize = true;
            this.lbl_tip_hab.Location = new System.Drawing.Point(18, 72);
            this.lbl_tip_hab.Name = "lbl_tip_hab";
            this.lbl_tip_hab.Size = new System.Drawing.Size(100, 13);
            this.lbl_tip_hab.TabIndex = 1;
            this.lbl_tip_hab.Text = "Tipo de Habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días de estadia:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(134, 32);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(207, 20);
            this.txt_cliente.TabIndex = 5;
            // 
            // txt_numdias
            // 
            this.txt_numdias.Enabled = false;
            this.txt_numdias.Location = new System.Drawing.Point(134, 109);
            this.txt_numdias.Name = "txt_numdias";
            this.txt_numdias.Size = new System.Drawing.Size(207, 20);
            this.txt_numdias.TabIndex = 9;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(218, 190);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 36);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modifcar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // reserva_dataGridView
            // 
            this.reserva_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva_dataGridView.Location = new System.Drawing.Point(1, 266);
            this.reserva_dataGridView.Name = "reserva_dataGridView";
            this.reserva_dataGridView.Size = new System.Drawing.Size(829, 253);
            this.reserva_dataGridView.TabIndex = 15;
            // 
            // Tip_Hab_comboBox
            // 
            this.Tip_Hab_comboBox.Enabled = false;
            this.Tip_Hab_comboBox.FormattingEnabled = true;
            this.Tip_Hab_comboBox.Location = new System.Drawing.Point(134, 69);
            this.Tip_Hab_comboBox.Name = "Tip_Hab_comboBox";
            this.Tip_Hab_comboBox.Size = new System.Drawing.Size(207, 21);
            this.Tip_Hab_comboBox.TabIndex = 16;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(669, 190);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 36);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(519, 190);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 36);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(371, 190);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 36);
            this.btn_Guardar.TabIndex = 19;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(71, 190);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(94, 36);
            this.btn_nuevo.TabIndex = 20;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(134, 150);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(207, 20);
            this.txt_precio.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(582, 53);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(207, 20);
            this.txt_codigo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Codigo Factura:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reserva_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 520);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.Tip_Hab_comboBox);
            this.Controls.Add(this.reserva_dataGridView);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txt_numdias);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tip_hab);
            this.Controls.Add(this.label1);
            this.Name = "Reserva_Form";
            this.Text = "Reserva_Form";
            this.Load += new System.EventHandler(this.Reserva_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserva_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tip_hab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_numdias;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView reserva_dataGridView;
        private System.Windows.Forms.ComboBox Tip_Hab_comboBox;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}