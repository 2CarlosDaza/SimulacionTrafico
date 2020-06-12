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
using static Entity.Vehiculo;

namespace simulación
{
    public partial class Form1 : Form
    {
        int secuencia, hora, minuto, segundo;
        string meridiano;//AM o PM
         
        readonly Random random = new Random();
        private Semaforo semaforo1;
        private Semaforo semaforo2;
        private Semaforo semaforo3;
        private Semaforo semaforo4;
        //coordenadasPlano coordenadasPlano;
        VehiculoRepository vehiculoRepository;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = (tiempoSemaforo.Interval / 1000).ToString();
            vehiculoRepository = new VehiculoRepository();
     
            //setCoordenadas();
            
            reiniciar();
            
          //  crearAuto(this,70,250);
        }
        

        private void reiniciar()
        {
            destruirCarros();
            estadoInicialSemaforos();
            crearSemaforos();
            setTiempoInicial();
        }
        public void crearSemaforos()
        {
            semaforo1= new Semaforo(txtVerde1,txtAmarillo1,txtRojo1);
            semaforo2 = new Semaforo(txtVerde2, txtAmarillo2, txtRojo2);
            semaforo3 = new Semaforo(txtVerde3, txtAmarillo3, txtRojo3);
            semaforo4 = new Semaforo(txtVerde4, txtAmarillo4, txtRojo4);
        }
        /*
        private void setCoordenadas()
        {
            coordenadasPlano = new coordenadasPlano();
            coordenadasPlano.coordenadaX[0] = 15;//lado izquierdo
            coordenadasPlano.coordenadaY[0] = -60;
            coordenadasPlano.coordenadaX[1] = 12;//lado abajo
            coordenadasPlano.coordenadaY[1] = 23;
            coordenadasPlano.coordenadaX[2] = 15;//lado derecho
            coordenadasPlano.coordenadaY[2] = -60;
            coordenadasPlano.coordenadaX[3] =12;//lado arriba
            coordenadasPlano.coordenadaY[3]=23;
        }
        */
        private void setTiempoInicial()
        {
            hora = 6;
            minuto = 0;
            segundo = 0;
            meridiano = "AM";
            tiempoGeneral.Interval = 1000;
        }

        private void estadoInicialSemaforos()
        {
            secuencia = 0;
            txtVerde1.BackColor = Color.Green;
            txtAmarillo1.BackColor = Color.Black;
            txtRojo1.BackColor = Color.Black;
            txtVerde2.BackColor = Color.Black;
            txtAmarillo2.BackColor = Color.Black;
            txtRojo2.BackColor = Color.Red; ;
            txtVerde3.BackColor = Color.Black;
            txtAmarillo3.BackColor = Color.Black;
            txtRojo3.BackColor = Color.Red; ;
            txtVerde4.BackColor = Color.Black;
            txtAmarillo4.BackColor = Color.Black;
            txtRojo4.BackColor = Color.Red; ;
            txtVerde1.BringToFront();
            txtAmarillo1.BringToFront();
            txtRojo1.BringToFront();
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

        private void crearAuto(Form formi,int x,int y)
        {
            vehiculoRepository.crearAuto(formi);
            
        }
        private void moverAutos()
        {
            vehiculoRepository.moverAutos(this);
        }


       
        private void cambiarColorSemaforo( int colorSemaforo,Semaforo semaforo)
        {
            semaforo.cambiarColorSemaforo(colorSemaforo);
        }

        
        private void TimerAutos_Tick(object sender, EventArgs e)
        {
            moverAutos();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            //tiempoGeneral
            label1.Text = ((3*tiempoSemaforo.Interval) / 1000).ToString();
            
            cambiarHora();
            label2.Text = hora + ":" + minuto + ":" + segundo+" "+meridiano;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            crearAuto(this, -60, 211);
            secuencia++;
            if (secuencia == 1)
            {
                cambiarColorSemaforo( Semaforo.AMARILLO, semaforo1);
            }
            else if (secuencia == 2)
            {
                cambiarColorSemaforo(Semaforo.ROJO, semaforo1);
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo2);
            }
            else if (secuencia == 3)//semaforo2
            {
                cambiarColorSemaforo(Semaforo.VERDE, semaforo2);
            }
            else if (secuencia == 4)
            {
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo2);
            }
            else if (secuencia == 5)
            {
                cambiarColorSemaforo(Semaforo.ROJO, semaforo2);
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo3);
            }
            else if (secuencia == 6)//semaforo3
            {
                cambiarColorSemaforo(Semaforo.VERDE, semaforo3);
            }
            else if (secuencia == 7)
            {
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo3);
            }
            else if (secuencia == 8)
            {
                cambiarColorSemaforo(Semaforo.ROJO, semaforo3);
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo4);
            }
            else if (secuencia == 9)//semaforo4
            {
                cambiarColorSemaforo(Semaforo.VERDE, semaforo4);
            }
            else if (secuencia == 10)
            {
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo4);
            }
            else if (secuencia == 12)
            {
                cambiarColorSemaforo(Semaforo.ROJO, semaforo4);
                cambiarColorSemaforo(Semaforo.AMARILLO, semaforo1);
            }
            else if (secuencia == 13)
            {
                cambiarColorSemaforo(Semaforo.VERDE, semaforo1);
                secuencia = 0;
            }
        }



        private void cambiarHora()
        {
            segundo++;
            if (segundo == 60)
            {
                segundo = 0; 
                minuto++;
            }
            if (minuto == 60)
            {
                minuto = 0; 
                hora++;
            }
        }

        private void empezar()
        {
            timerAutosMover.Enabled = true;
            tiempoSemaforo.Enabled = true;
            tiempoGeneral.Enabled = true;
        }

        private void pausar()
        {
            timerAutosMover.Enabled = false;
            tiempoSemaforo.Enabled = false;
            tiempoGeneral.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAumentar_Click(object sender, EventArgs e){aumentar(this.tiempoSemaforo);}

        private void btnDisminuir_Click(object sender, EventArgs e){disminuir(this.tiempoSemaforo);}

        private void btnPausa_Click(object sender, EventArgs e){pausar();}

        private void startBtn_MouseUp(object sender, MouseEventArgs e){ empezar(); }

        private void btnReiniciar_Click(object sender, EventArgs e){destruirCarros();}

        private void destruirCarros()
        {
            vehiculoRepository.destruirVehiculos(this);
        }

        private void btnAcelerar_MouseUp(object sender, MouseEventArgs e){ disminuir(this.tiempoGeneral); }

        private void btnAlentizar_MouseUp(object sender, MouseEventArgs e){ aumentar(this.tiempoGeneral); }
    }
}
