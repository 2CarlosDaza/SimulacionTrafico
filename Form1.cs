using Entity;
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
        int secuencia, hora, minuto, segundo;
        string meridiano;//AM o PM
        readonly List<PictureBox> ListaCarros = new List<PictureBox>();
        coordenadasPlano coordenadasPlano;
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
            setTiempoInicial();
            setCoordenadas();
            crearAuto();
        }
        private void setCoordenadas()
        {
            coordenadasPlano = new coordenadasPlano();
            coordenadasPlano.coordenadaX[0] = 15;//lado izquierdo
            coordenadasPlano.coordenadaY[0] = -60;
            coordenadasPlano.coordenadaX[1] = 12;//lado abajo
            coordenadasPlano.coordenadaY[1] = 23;
            coordenadasPlano.coordenadaX[2] = 15;//lado derecho
            coordenadasPlano.coordenadaY[2] = -60;
            coordenadasPlano.coordenadaX[3] =12;
            coordenadasPlano.coordenadaY[3]=23;
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

        private void aumentar(Timer timer){
            if (timer.Interval <= 1000)
            {
                timer.Interval = timer.Interval * 2;
            }
            else
            {
                timer.Interval += 1000;
            }
        }

        private void disminuir(Timer timer)
        {
            if (timer.Interval <= 1000)
            {
                if (timer.Interval == 1)
                {
                    //poner una alerta de que ya es el limite
                }
                else
                {
                    timer.Interval = timer.Interval / 2;
                }
                
            }
            else
            {
                timer.Interval -= 1000;
            }
        }

        private void crearAuto()
        {
            //x=849,y=461
            //x=15 y=-60
            //Form panelCalle, int coordenadaXUno, int coordenadaYUno, int coordenadaXDos, int coordenadaYDos, int coordenadaXTres, int coordenadaYTres, int coordenadaXCuatro, int coordenadaYCuatro
            
        }
        private void moverAuto()
        {
            //ListaCarros[i].Location = new Point(ListaCarros[i].Location.X, ListaCarros[i].Location.Y + velocidad);
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            secuencia++;
            if (secuencia==1)
            {
                cambiarColorSemaforo(this.txtVerde1,this.txtAmarillo1,this.txtRojo1,Color.Yellow);
            }
            else if (secuencia==2)
            {
                cambiarColorSemaforo(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Red);
                cambiarColorSemaforo(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Yellow);
            }
            else if (secuencia==3)//semaforo2
            {
                cambiarColorSemaforo(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Green);
            }
            else if (secuencia == 4)
            {
                cambiarColorSemaforo(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Yellow);
            }
            else if (secuencia==5)
            {
                cambiarColorSemaforo(this.btnVerde2, this.btnAmarillo2, this.btnRojo2, Color.Red);
                cambiarColorSemaforo(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Yellow);
            }
            else if (secuencia == 6)//semaforo3
            {
                cambiarColorSemaforo(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Green);
            }
            else if (secuencia == 7)
            {
                cambiarColorSemaforo(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Yellow);
            }
            else if (secuencia == 8)
            {
                cambiarColorSemaforo(this.btnVerde3, this.btnAmarillo3, this.btnRojo3, Color.Red);
                cambiarColorSemaforo(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Yellow);
            }
            else if (secuencia == 9)//semaforo4
            {
                cambiarColorSemaforo(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Green);
            }
            else if (secuencia == 10)
            {
                cambiarColorSemaforo(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Yellow);
            }
            else if (secuencia == 12)
            {
                cambiarColorSemaforo(this.btnVerde4, this.btnAmarillo4, this.btnRojo4, Color.Red);
                cambiarColorSemaforo(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Yellow);
            }else if (secuencia == 13)
            {
                cambiarColorSemaforo(this.txtVerde1, this.txtAmarillo1, this.txtRojo1, Color.Green);
                secuencia = 0;
            }
        }

       

        private void cambiarColorSemaforo(TextBox txtVerde, TextBox txtAmarillo,TextBox txtRojo, Color color)
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

        private void setTiempoInicial()
        {
           hora = 6; 
           minuto = 0;
           segundo = 0;
           meridiano = "AM";
           TiempoGeneral.Interval = 1000;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //tiempoGeneral
            label1.Text = ((3*tiempoSemaforo.Interval) / 1000).ToString();
            //label2.Text = DateTime.Now.ToLongTimeString();
            segundo++;
            if (segundo == 60)
            {
                segundo = 0;minuto++;
            }
            if (minuto == 60)
            {
                minuto = 0;hora++;
            }

            label2.Text = hora + ":" + minuto + ":" + segundo+" "+meridiano;
        }
        private void empezar()
        {
            TiempoGeneral.Enabled = true;
            tiempoSemaforo.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAumentar_Click(object sender, EventArgs e){aumentar(this.tiempoSemaforo);}

        private void btnDisminuir_Click(object sender, EventArgs e){disminuir(this.tiempoSemaforo);}

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

        private void startBtn_MouseUp(object sender, MouseEventArgs e){ empezar(); }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_MouseUp(object sender, MouseEventArgs e){ disminuir(this.TiempoGeneral); }

        private void btnAlentizar_MouseUp(object sender, MouseEventArgs e){ aumentar(this.TiempoGeneral); }
    }
}
