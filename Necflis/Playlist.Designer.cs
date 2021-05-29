
namespace Necflis
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.tblSelecCliente = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.ptbPeliculas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPelicula = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblSelecCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSelecCliente
            // 
            this.tblSelecCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblSelecCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSelecCliente.Location = new System.Drawing.Point(16, 92);
            this.tblSelecCliente.Name = "tblSelecCliente";
            this.tblSelecCliente.Size = new System.Drawing.Size(356, 299);
            this.tblSelecCliente.TabIndex = 28;
            this.tblSelecCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSelecCliente_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPlaylist.Location = new System.Drawing.Point(153, 37);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(122, 39);
            this.lblPlaylist.TabIndex = 29;
            this.lblPlaylist.Text = "Playlist";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerLista);
            this.panel1.Controls.Add(this.tblSelecCliente);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 481);
            this.panel1.TabIndex = 31;
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnVerLista.FlatAppearance.BorderSize = 0;
            this.btnVerLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnVerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerLista.Location = new System.Drawing.Point(108, 419);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(176, 35);
            this.btnVerLista.TabIndex = 29;
            this.btnVerLista.Text = "Ver lista de peliculas";
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // ptbPeliculas
            // 
            this.ptbPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("ptbPeliculas.Image")));
            this.ptbPeliculas.Location = new System.Drawing.Point(388, -2);
            this.ptbPeliculas.Name = "ptbPeliculas";
            this.ptbPeliculas.Size = new System.Drawing.Size(390, 481);
            this.ptbPeliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPeliculas.TabIndex = 32;
            this.ptbPeliculas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(481, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lista de peliculas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblPelicula
            // 
            this.tblPelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPelicula.Location = new System.Drawing.Point(407, 92);
            this.tblPelicula.Name = "tblPelicula";
            this.tblPelicula.Size = new System.Drawing.Size(356, 299);
            this.tblPelicula.TabIndex = 33;
            this.tblPelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSelecCliente_CellContentClick);
            this.tblPelicula.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblPelicula_RowHeaderMouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(425, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(776, 481);
            this.Controls.Add(this.ptbPeliculas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblPelicula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist";
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.tblSelecCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSelecCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbPeliculas;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblPelicula;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}