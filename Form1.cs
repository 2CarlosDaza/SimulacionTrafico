using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulación
{
    public partial class Form1 : Form
    {
        int secuencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = (tiempoSemaforo.Interval / 1000).ToString();
            txtVerde1.BringToFront();
            txtAmarillo1.BringToFront();
            txtRojo1.BringToFront();
            estadoInicialSemaforos();
        }

        private void estadoInicialSemaforos()
        {
            secuencia = 0;
            txtVerde1.BackColor = Color.Green;
            txtAmarillo1.BackColor = Color.Black;
            txtRojo1.BackColor = Color.Black;
            btnVerde2.BackColor = Color.Black;
            btnAmarillo2.BackColor = Color.Black;
            btnRojo2.BackColor = Color.Red; ;
            btnVerde3.BackColor = Color.Black;
            btnAmarillo3.BackColor = Color.Black;
            btnRojo3.BackColor = Color.Red; ;
            btnVerde4.BackColor = Color.Black;
            btnAmarillo4.BackColor = Color.Black;
            btnRojo4.BackColor = Color.Red; ;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*  
              if (txtVerde1.BackColor == Color.Green)
              {
                  txtVerde1.BackColor = Color.Black;
                  txtAmarillo1.BackColor = Color.Yellow;
                  txtRojo1.BackColor = Color.Black;
              }else if (txtAmarillo1.BackColor == Color.Yellow)
              {
                  txtVerde1.BackColor = Color.Black;
                  txtAmarillo1.BackColor = Color.Black;
                  txtRojo1.BackColor = Color.Red;
              }else if (txtRojo1.BackColor==Color.Red)
              {
                  txtVerde1.BackColor = Color.Green;
                  txtAmarillo1.BackColor = Color.Black;
                  txtRojo1.BackColor = Color.Black;
              }
              */
            secuencia++;
            if (secuencia==1)
            {
                cambiarColorSemaforo1(this.txtVerde1,this.txtAmarillo1,this.txtRojo1,Color.Yellow);
            }
            else if (secuencia==2)
            {
                cambiarColorSemaforo1(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Red);
                cambiarColorSemaforo1(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Yellow);
            }
            else if (secuencia==3)//semaforo2
            {
                cambiarColorSemaforo1(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Green);
            }
            else if (secuencia == 4)
            {
                cambiarColorSemaforo1(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Yellow);
            }
            else if (secuencia==5)
            {
                cambiarColorSemaforo1(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Red);
                cambiarColorSemaforo1(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Yellow);
            }
            else if (secuencia == 6)//semaforo3
            {
                cambiarColorSemaforo1(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Green);
            }
            else if (secuencia == 7)
            {
                cambiarColorSemaforo1(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Yellow);
            }
            else if (secuencia == 8)
            {
                cambiarColorSemaforo1(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Red);
                cambiarColorSemaforo1(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Yellow);
            }
            else if (secuencia == 9)//semaforo4
            {
                cambiarColorSemaforo1(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Green);
            }
            else if (secuencia == 10)
            {
                cambiarColorSemaforo1(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Yellow);
            }
            else if (secuencia == 12)
            {
                cambiarColorSemaforo1(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Red);
                cambiarColorSemaforo1(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Yellow);
            }else if (secuencia == 13)
            {
                cambiarColorSemaforo1(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Green);
                secuencia = 0;
            }
        }


        private void cambiarColorSemaforo1(TextBox txtVerde, TextBox txtAmarillo,TextBox txtRojo, Color color)
        {
            if (color == Color.Red)
            {
                txtVerde.BackColor = Color.Black;
                txtAmarillo.BackColor = Color.Black;
                txtRojo.BackColor = Color.Red;
            } else if (color == Color.Yellow)
            {
                txtVerde.BackColor = Color.Black;
                txtAmarillo.BackColor = Color.Yellow;
                txtRojo.BackColor = Color.Black;
            }
            else if (color == Color.Green)
            {
                txtVerde.BackColor = Color.Green;
                txtAmarillo.BackColor = Color.Black;
                txtRojo.BackColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = ((3*tiempoSemaforo.Interval) / 1000).ToString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            tiempoSemaforo.Interval += 1000;
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (tiempoSemaforo.Interval <= 1000)
            {
                tiempoSemaforo.Interval = tiempoSemaforo.Interval / 2;
            }
            else
            {
                tiempoSemaforo.Interval -= 1000;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
