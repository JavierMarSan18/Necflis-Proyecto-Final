
namespace Necflis
{
    partial class SeleccionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblSelecCliente = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSelecCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tblSelecCliente
            // 
            this.tblSelecCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblSelecCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSelecCliente.Location = new System.Drawing.Point(12, 86);
            this.tblSelecCliente.Name = "tblSelecCliente";
            this.tblSelecCliente.Size = new System.Drawing.Size(423, 299);
            this.tblSelecCliente.TabIndex = 27;
            this.tblSelecCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSelecCliente_CellContentClick);
            this.tblSelecCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblSelecCliente_RowHeaderMouseClick);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClientes.Location = new System.Drawing.Point(98, 30);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(307, 39);
            this.lblClientes.TabIndex = 26;
            this.lblClientes.Text = "Seleccionar clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // SeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(447, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tblSelecCliente);
            this.Controls.Add(this.lblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarCliente";
            this.Text = "SeleccionarCliente";
            this.Load += new System.EventHandler(this.SeleccionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSelecCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tblSelecCliente;
        private System.Windows.Forms.Label lblClientes;
    }
}