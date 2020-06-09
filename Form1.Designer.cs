namespace simulación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempoSemaforo = new System.Windows.Forms.Timer(this.components);
            this.txtRojo1 = new System.Windows.Forms.TextBox();
            this.txtAmarillo1 = new System.Windows.Forms.TextBox();
            this.txtVerde1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAmarillo4 = new System.Windows.Forms.TextBox();
            this.btnRojo4 = new System.Windows.Forms.TextBox();
            this.btnVerde4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAmarillo3 = new System.Windows.Forms.TextBox();
            this.btnRojo3 = new System.Windows.Forms.TextBox();
            this.btnVerde3 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAmarillo2 = new System.Windows.Forms.TextBox();
            this.btnRojo2 = new System.Windows.Forms.TextBox();
            this.btnVerde2 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tiempoSemaforo
            // 
            this.tiempoSemaforo.Enabled = true;
            this.tiempoSemaforo.Interval = 3000;
            this.tiempoSemaforo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtRojo1
            // 
            this.txtRojo1.BackColor = System.Drawing.Color.Black;
            this.txtRojo1.Location = new System.Drawing.Point(-1, 52);
            this.txtRojo1.Multiline = true;
            this.txtRojo1.Name = "txtRojo1";
            this.txtRojo1.Size = new System.Drawing.Size(21, 21);
            this.txtRojo1.TabIndex = 1;
            this.txtRojo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAmarillo1
            // 
            this.txtAmarillo1.BackColor = System.Drawing.Color.Black;
            this.txtAmarillo1.Location = new System.Drawing.Point(0, 26);
            this.txtAmarillo1.Multiline = true;
            this.txtAmarillo1.Name = "txtAmarillo1";
            this.txtAmarillo1.Size = new System.Drawing.Size(20, 20);
            this.txtAmarillo1.TabIndex = 2;
            // 
            // txtVerde1
            // 
            this.txtVerde1.BackColor = System.Drawing.Color.Green;
            this.txtVerde1.Location = new System.Drawing.Point(0, 3);
            this.txtVerde1.Multiline = true;
            this.txtVerde1.Name = "txtVerde1";
            this.txtVerde1.Size = new System.Drawing.Size(20, 19);
            this.txtVerde1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisminuir);
            this.panel1.Controls.Add(this.btnAumentar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(601, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo del semaforo(seg)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(22, 108);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 7;
            this.btnAumentar.Text = "Aumentar Tiempo";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(125, 108);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(75, 23);
            this.btnDisminuir.TabIndex = 8;
            this.btnDisminuir.Text = "Disminuir Tiempo";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAmarillo1);
            this.panel2.Controls.Add(this.txtRojo1);
            this.panel2.Controls.Add(this.txtVerde1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(336, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 74);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(310, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 70);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::simulación.Properties.Resources.dibujosim2;
            this.pictureBox1.InitialImage = global::simulación.Properties.Resources.mapa3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 461);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAmarillo4);
            this.panel3.Controls.Add(this.btnRojo4);
            this.panel3.Controls.Add(this.btnVerde4);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Location = new System.Drawing.Point(475, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 74);
            this.panel3.TabIndex = 9;
            // 
            // btnAmarillo4
            // 
            this.btnAmarillo4.BackColor = System.Drawing.Color.Black;
            this.btnAmarillo4.Location = new System.Drawing.Point(0, 26);
            this.btnAmarillo4.Multiline = true;
            this.btnAmarillo4.Name = "btnAmarillo4";
            this.btnAmarillo4.Size = new System.Drawing.Size(20, 20);
            this.btnAmarillo4.TabIndex = 2;
            // 
            // btnRojo4
            // 
            this.btnRojo4.BackColor = System.Drawing.Color.Black;
            this.btnRojo4.Location = new System.Drawing.Point(-1, 52);
            this.btnRojo4.Multiline = true;
            this.btnRojo4.Name = "btnRojo4";
            this.btnRojo4.Size = new System.Drawing.Size(21, 21);
            this.btnRojo4.TabIndex = 1;
            // 
            // btnVerde4
            // 
            this.btnVerde4.BackColor = System.Drawing.Color.Green;
            this.btnVerde4.Location = new System.Drawing.Point(0, 3);
            this.btnVerde4.Multiline = true;
            this.btnVerde4.Name = "btnVerde4";
            this.btnVerde4.Size = new System.Drawing.Size(20, 19);
            this.btnVerde4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 70);
            this.textBox5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAmarillo3);
            this.panel4.Controls.Add(this.btnRojo3);
            this.panel4.Controls.Add(this.btnVerde3);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Location = new System.Drawing.Point(474, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 76);
            this.panel4.TabIndex = 9;
            // 
            // btnAmarillo3
            // 
            this.btnAmarillo3.BackColor = System.Drawing.Color.Black;
            this.btnAmarillo3.Location = new System.Drawing.Point(0, 26);
            this.btnAmarillo3.Multiline = true;
            this.btnAmarillo3.Name = "btnAmarillo3";
            this.btnAmarillo3.Size = new System.Drawing.Size(20, 20);
            this.btnAmarillo3.TabIndex = 2;
            // 
            // btnRojo3
            // 
            this.btnRojo3.BackColor = System.Drawing.Color.Black;
            this.btnRojo3.Location = new System.Drawing.Point(-1, 52);
            this.btnRojo3.Multiline = true;
            this.btnRojo3.Name = "btnRojo3";
            this.btnRojo3.Size = new System.Drawing.Size(21, 21);
            this.btnRojo3.TabIndex = 1;
            // 
            // btnVerde3
            // 
            this.btnVerde3.BackColor = System.Drawing.Color.Green;
            this.btnVerde3.Location = new System.Drawing.Point(0, 3);
            this.btnVerde3.Multiline = true;
            this.btnVerde3.Name = "btnVerde3";
            this.btnVerde3.Size = new System.Drawing.Size(20, 19);
            this.btnVerde3.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(0, 4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(24, 70);
            this.textBox9.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAmarillo2);
            this.panel5.Controls.Add(this.btnRojo2);
            this.panel5.Controls.Add(this.btnVerde2);
            this.panel5.Controls.Add(this.textBox13);
            this.panel5.Location = new System.Drawing.Point(313, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 76);
            this.panel5.TabIndex = 10;
            // 
            // btnAmarillo2
            // 
            this.btnAmarillo2.BackColor = System.Drawing.Color.Black;
            this.btnAmarillo2.Location = new System.Drawing.Point(0, 26);
            this.btnAmarillo2.Multiline = true;
            this.btnAmarillo2.Name = "btnAmarillo2";
            this.btnAmarillo2.Size = new System.Drawing.Size(20, 20);
            this.btnAmarillo2.TabIndex = 2;
            // 
            // btnRojo2
            // 
            this.btnRojo2.BackColor = System.Drawing.Color.Black;
            this.btnRojo2.Location = new System.Drawing.Point(-1, 52);
            this.btnRojo2.Multiline = true;
            this.btnRojo2.Name = "btnRojo2";
            this.btnRojo2.Size = new System.Drawing.Size(21, 21);
            this.btnRojo2.TabIndex = 1;
            // 
            // btnVerde2
            // 
            this.btnVerde2.BackColor = System.Drawing.Color.Green;
            this.btnVerde2.Location = new System.Drawing.Point(0, 3);
            this.btnVerde2.Multiline = true;
            this.btnVerde2.Name = "btnVerde2";
            this.btnVerde2.Size = new System.Drawing.Size(20, 19);
            this.btnVerde2.TabIndex = 3;
            this.btnVerde2.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(0, 4);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(24, 70);
            this.textBox13.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 470);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tiempoSemaforo;
        private System.Windows.Forms.TextBox txtRojo1;
        private System.Windows.Forms.TextBox txtAmarillo1;
        private System.Windows.Forms.TextBox txtVerde1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox btnAmarillo4;
        private System.Windows.Forms.TextBox btnRojo4;
        private System.Windows.Forms.TextBox btnVerde4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox btnAmarillo3;
        private System.Windows.Forms.TextBox btnRojo3;
        private System.Windows.Forms.TextBox btnVerde3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox btnAmarillo2;
        private System.Windows.Forms.TextBox btnRojo2;
        private System.Windows.Forms.TextBox btnVerde2;
        private System.Windows.Forms.TextBox textBox13;
    }
}

