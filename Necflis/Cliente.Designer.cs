
namespace Necflis
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.pnlOpCliente = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.PictureBox();
            this.pnlOpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpCliente
            // 
            this.pnlOpCliente.Controls.Add(this.lblClientes);
            this.pnlOpCliente.Controls.Add(this.button1);
            this.pnlOpCliente.Controls.Add(this.btnNuevoCliente);
            this.pnlOpCliente.Controls.Add(this.btnListaClientes);
            this.pnlOpCliente.Location = new System.Drawing.Point(2, 1);
            this.pnlOpCliente.Name = "pnlOpCliente";
            this.pnlOpCliente.Size = new System.Drawing.Size(225, 481);
            this.pnlOpCliente.TabIndex = 0;
            this.pnlOpCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpCliente_Paint);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClientes.Location = new System.Drawing.Point(41, 36);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(133, 39);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccionar cliente ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(3, 180);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(219, 35);
            this.btnNuevoCliente.TabIndex = 7;
            this.btnNuevoCliente.Text = "Crear nuevo cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.btnListaClientes.FlatAppearance.BorderSize = 0;
            this.btnListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientes.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListaClientes.Image")));
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(3, 110);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(219, 35);
            this.btnListaClientes.TabIndex = 6;
            this.btnListaClientes.Text = "Ver lista de clientes";
            this.btnListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaClientes.UseVisualStyleBackColor = false;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Image = ((System.Drawing.Image)(resources.GetObject("pnlCliente.Image")));
            this.pnlCliente.Location = new System.Drawing.Point(223, 1);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(447, 481);
            this.pnlCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlCliente.TabIndex = 1;
            this.pnlCliente.TabStop = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(671, 481);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlOpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.pnlOpCliente.ResumeLayout(false);
            this.pnlOpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.PictureBox pnlCliente;
    }
}