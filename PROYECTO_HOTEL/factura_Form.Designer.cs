
namespace PROYECTO_HOTEL
{
    partial class factura_Form
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
            this.factura_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.factura_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // factura_dataGridView
            // 
            this.factura_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factura_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.factura_dataGridView.Name = "factura_dataGridView";
            this.factura_dataGridView.Size = new System.Drawing.Size(809, 479);
            this.factura_dataGridView.TabIndex = 0;
            // 
            // factura_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 521);
            this.Controls.Add(this.factura_dataGridView);
            this.Name = "factura_Form";
            this.Text = "factura_Form";
            this.Load += new System.EventHandler(this.factura_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factura_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView factura_dataGridView;
    }
}