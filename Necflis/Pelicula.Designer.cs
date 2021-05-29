
namespace Necflis
{
    partial class FormPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelicula));
            this.pnlOpCliente = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.btnListaPeliculas = new System.Windows.Forms.Button();
            this.pnlPelicula = new System.Windows.Forms.PictureBox();
            this.pnlOpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpCliente
            // 
            this.pnlOpCliente.Controls.Add(this.lblClientes);
            this.pnlOpCliente.Controls.Add(this.btnNuevaPelicula);
            this.pnlOpCliente.Controls.Add(this.btnListaPeliculas);
            this.pnlOpCliente.Location = new System.Drawing.Point(2, 1);
            this.pnlOpCliente.Name = "pnlOpCliente";
            this.pnlOpCliente.Size = new System.Drawing.Size(221, 481);
            this.pnlOpCliente.TabIndex = 1;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblClientes.Location = new System.Drawing.Point(41, 36);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(147, 39);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "Películas";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.btnNuevaPelicula.FlatAppearance.BorderSize = 0;
            this.btnNuevaPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnNuevaPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnNuevaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPelicula.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevaPelicula.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaPelicula.Image")));
            this.btnNuevaPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaPelicula.Location = new System.Drawing.Point(3, 180);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(218, 35);
            this.btnNuevaPelicula.TabIndex = 7;
            this.btnNuevaPelicula.Text = "Crear nueva película";
            this.btnNuevaPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaPelicula.UseVisualStyleBackColor = false;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnListaPeliculas
            // 
            this.btnListaPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.btnListaPeliculas.FlatAppearance.BorderSize = 0;
            this.btnListaPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnListaPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnListaPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPeliculas.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListaPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnListaPeliculas.Image")));
            this.btnListaPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPeliculas.Location = new System.Drawing.Point(3, 110);
            this.btnListaPeliculas.Name = "btnListaPeliculas";
            this.btnListaPeliculas.Size = new System.Drawing.Size(218, 35);
            this.btnListaPeliculas.TabIndex = 6;
            this.btnListaPeliculas.Text = " Ver lista de películas";
            this.btnListaPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaPeliculas.UseVisualStyleBackColor = false;
            this.btnListaPeliculas.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.Image = ((System.Drawing.Image)(resources.GetObject("pnlPelicula.Image")));
            this.pnlPelicula.Location = new System.Drawing.Point(219, 1);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(447, 481);
            this.pnlPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlPelicula.TabIndex = 2;
            this.pnlPelicula.TabStop = false;
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 482);
            this.Controls.Add(this.pnlPelicula);
            this.Controls.Add(this.pnlOpCliente);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPelicula";
            this.Text = "Pelicula";
            this.pnlOpCliente.ResumeLayout(false);
            this.pnlOpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnNuevaPelicula;
        private System.Windows.Forms.Button btnListaPeliculas;
        private System.Windows.Forms.PictureBox pnlPelicula;
    }
}