namespace Velocidad_Motor
{
    partial class FrmVelocidad
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnDerivar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinRed = new System.Windows.Forms.TextBox();
            this.txtMaxRed = new System.Windows.Forms.TextBox();
            this.txtMinGreen = new System.Windows.Forms.TextBox();
            this.txtMaxGreen = new System.Windows.Forms.TextBox();
            this.txtMinBlue = new System.Windows.Forms.TextBox();
            this.txtMaxBlue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiempo,
            this.Posicion,
            this.Velocidad});
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(264, 344);
            this.dgvDatos.TabIndex = 0;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // Velocidad
            // 
            this.Velocidad.HeaderText = "Velocidad";
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.ReadOnly = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 362);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "button1";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(12, 391);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "button1";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnDerivar
            // 
            this.btnDerivar.Location = new System.Drawing.Point(12, 420);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(75, 23);
            this.btnDerivar.TabIndex = 1;
            this.btnDerivar.Text = "button1";
            this.btnDerivar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(542, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 278);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MINIMO ROJO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MINIMO AZUL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MINIMO VERDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MINIMO VERDE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MINIMO AZUL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "MINIMO ROJO";
            // 
            // txtMinRed
            // 
            this.txtMinRed.Location = new System.Drawing.Point(381, 300);
            this.txtMinRed.Name = "txtMinRed";
            this.txtMinRed.Size = new System.Drawing.Size(100, 20);
            this.txtMinRed.TabIndex = 10;
            this.txtMinRed.TextChanged += new System.EventHandler(this.txtMinRed_TextChanged);
            // 
            // txtMaxRed
            // 
            this.txtMaxRed.Location = new System.Drawing.Point(636, 300);
            this.txtMaxRed.Name = "txtMaxRed";
            this.txtMaxRed.Size = new System.Drawing.Size(100, 20);
            this.txtMaxRed.TabIndex = 11;
            // 
            // txtMinGreen
            // 
            this.txtMinGreen.Location = new System.Drawing.Point(381, 329);
            this.txtMinGreen.Name = "txtMinGreen";
            this.txtMinGreen.Size = new System.Drawing.Size(100, 20);
            this.txtMinGreen.TabIndex = 12;
            // 
            // txtMaxGreen
            // 
            this.txtMaxGreen.Location = new System.Drawing.Point(636, 329);
            this.txtMaxGreen.Name = "txtMaxGreen";
            this.txtMaxGreen.Size = new System.Drawing.Size(100, 20);
            this.txtMaxGreen.TabIndex = 13;
            // 
            // txtMinBlue
            // 
            this.txtMinBlue.Location = new System.Drawing.Point(381, 358);
            this.txtMinBlue.Name = "txtMinBlue";
            this.txtMinBlue.Size = new System.Drawing.Size(100, 20);
            this.txtMinBlue.TabIndex = 14;
            // 
            // txtMaxBlue
            // 
            this.txtMaxBlue.Location = new System.Drawing.Point(636, 358);
            this.txtMaxBlue.Name = "txtMaxBlue";
            this.txtMaxBlue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxBlue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(296, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 80);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // FrmVelocidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxBlue);
            this.Controls.Add(this.txtMinBlue);
            this.Controls.Add(this.txtMaxGreen);
            this.Controls.Add(this.txtMinGreen);
            this.Controls.Add(this.txtMaxRed);
            this.Controls.Add(this.txtMinRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDerivar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.dgvDatos);
            this.Name = "FrmVelocidad";
            this.Text = "VelocidadMotor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVelocidad_FormClosing);
            this.Load += new System.EventHandler(this.FrmVelocidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnDerivar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinRed;
        private System.Windows.Forms.TextBox txtMaxRed;
        private System.Windows.Forms.TextBox txtMinGreen;
        private System.Windows.Forms.TextBox txtMaxGreen;
        private System.Windows.Forms.TextBox txtMinBlue;
        private System.Windows.Forms.TextBox txtMaxBlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidad;
        private System.Windows.Forms.Label label7;
    }
}