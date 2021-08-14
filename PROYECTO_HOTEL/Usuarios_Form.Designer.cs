
namespace PROYECTO_HOTEL
{
    partial class Usuarios_Form
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
            this.Usuarios_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuarios_dataGridView
            // 
            this.Usuarios_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuarios_dataGridView.Location = new System.Drawing.Point(5, 10);
            this.Usuarios_dataGridView.Name = "Usuarios_dataGridView";
            this.Usuarios_dataGridView.Size = new System.Drawing.Size(481, 199);
            this.Usuarios_dataGridView.TabIndex = 0;
            // 
            // Usuarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 215);
            this.Controls.Add(this.Usuarios_dataGridView);
            this.Name = "Usuarios_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios_Form";
            this.Load += new System.EventHandler(this.Usuarios_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Usuarios_dataGridView;
    }
}