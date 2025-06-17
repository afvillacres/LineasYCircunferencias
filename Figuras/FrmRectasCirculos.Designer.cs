namespace Figuras
{
    partial class FrmRectasCirculos
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
            this.txtPuntoInicial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.btnDDA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuntoFinal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.txtPuntoOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picPizarra = new System.Windows.Forms.PictureBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.lstPuntos = new System.Windows.Forms.ListBox();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizarra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPuntoInicial
            // 
            this.txtPuntoInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPuntoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoInicial.Location = new System.Drawing.Point(15, 78);
            this.txtPuntoInicial.Name = "txtPuntoInicial";
            this.txtPuntoInicial.Size = new System.Drawing.Size(126, 27);
            this.txtPuntoInicial.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.btnBresenham);
            this.groupBox1.Controls.Add(this.btnDDA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPuntoFinal);
            this.groupBox1.Controls.Add(this.txtPuntoInicial);
            this.groupBox1.Location = new System.Drawing.Point(35, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectas";
            // 
            // btnBresenham
            // 
            this.btnBresenham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenham.Location = new System.Drawing.Point(61, 173);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(205, 30);
            this.btnBresenham.TabIndex = 5;
            this.btnBresenham.Text = "Bresenham";
            this.btnBresenham.UseVisualStyleBackColor = false;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // btnDDA
            // 
            this.btnDDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.Location = new System.Drawing.Point(61, 125);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(205, 30);
            this.btnDDA.TabIndex = 4;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = false;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Punto final \"x,y\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punto inicial \"x,y\"";
            // 
            // txtPuntoFinal
            // 
            this.txtPuntoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPuntoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoFinal.Location = new System.Drawing.Point(176, 78);
            this.txtPuntoFinal.Name = "txtPuntoFinal";
            this.txtPuntoFinal.Size = new System.Drawing.Size(126, 27);
            this.txtPuntoFinal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.txtRadio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCirculo);
            this.groupBox2.Controls.Add(this.txtPuntoOrigen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(35, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circunferencias";
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(116, 109);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(150, 27);
            this.txtRadio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Radio";
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculo.Location = new System.Drawing.Point(62, 160);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(197, 30);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Graficar";
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // txtPuntoOrigen
            // 
            this.txtPuntoOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPuntoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoOrigen.Location = new System.Drawing.Point(61, 61);
            this.txtPuntoOrigen.Name = "txtPuntoOrigen";
            this.txtPuntoOrigen.Size = new System.Drawing.Size(205, 27);
            this.txtPuntoOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Punto de orígen \"x,y\"";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.picPizarra);
            this.groupBox3.Location = new System.Drawing.Point(376, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 548);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picPizarra
            // 
            this.picPizarra.BackColor = System.Drawing.Color.White;
            this.picPizarra.Location = new System.Drawing.Point(28, 32);
            this.picPizarra.Name = "picPizarra";
            this.picPizarra.Size = new System.Drawing.Size(539, 504);
            this.picPizarra.TabIndex = 0;
            this.picPizarra.TabStop = false;
            this.picPizarra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPizarra_MouseClick);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(211, 537);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(99, 28);
            this.btnResetear.TabIndex = 4;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // lstPuntos
            // 
            this.lstPuntos.BackColor = System.Drawing.Color.Lime;
            this.lstPuntos.FormattingEnabled = true;
            this.lstPuntos.ItemHeight = 16;
            this.lstPuntos.Location = new System.Drawing.Point(1013, 29);
            this.lstPuntos.Name = "lstPuntos";
            this.lstPuntos.Size = new System.Drawing.Size(245, 548);
            this.lstPuntos.TabIndex = 5;
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnRellenar.Location = new System.Drawing.Point(35, 537);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(126, 27);
            this.btnRellenar.TabIndex = 6;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // FrmRectasCirculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1283, 595);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.lstPuntos);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRectasCirculos";
            this.Text = "FrmRectasCirculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuntoInicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuntoFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picPizarra;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.TextBox txtPuntoOrigen;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstPuntos;
        private System.Windows.Forms.Button btnRellenar;
    }
}