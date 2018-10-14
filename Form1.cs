using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoLin
{
    public partial class Form1 : Form
    {        
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            Thread hilo = new Thread(lineaEspera);
            hilo.Start();
            CheckForIllegalCrossThreadCalls = false;
            lblFin.Text = "";
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;
            p5.Visible = false;
            p6.Visible = false;
            p7.Visible = false;
            p8.Visible = false;
            m1.Visible = false;
            m2.Visible = false;
            m3.Visible = false;
            m4.Visible = false;
            m5.Visible = true;
            m6.Visible = true;
            m7.Visible = true;
            m8.Visible = true;
            game1.Visible = false;
            game2.Visible = false;
            game3.Visible = false;
            game4.Visible = false;
            tmp1.Visible = false;
            tmp2.Visible = false;
            tmp3.Visible = false;
            tmp4.Visible = false;
            label2.Visible = false;
            label13.Visible = false;
            label17.Visible = false;
            label6.Visible = false;
            label15.Visible = false;
            label4.Visible = false;
            label22.Visible = false;
            label8.Visible = false;
            label1.Visible = false;
            lblJugadores.Visible = false;
        }

        private void lineaEspera()
        {
            int horas = Convert.ToInt32(txtCantidad.Text);
            int num = 3;
            Boolean Active = false;

            int[] espera1 = new int[60];
            int[] espera2 = new int[60];
            int[] espera3 = new int[60];
            int[] espera4 = new int[60];

            int[] maquina1 = new int[1];
            int[] maquina2 = new int[1];
            int[] maquina3 = new int[1];
            int[] maquina4 = new int[1];

            int juego;
            int players1 = 1;
            int players2 = 0;
            int players3 = 0;
            int players4 = 0;

            int tiempoB1 = 0;
            int tiempoB2 = 0;
            int tiempoB3 = 0;
            int tiempoB4 = 0;
            
            Boolean estatus = false;
            Thread.Sleep(500);

            Boolean esta_libre1 = true;
            Boolean esta_libre2 = true;
            Boolean esta_libre3 = true;
            Boolean esta_libre4 = true;
            int reloj1 = 0, reloj2 = 0, reloj3 = 0, reloj4 = 0,total_clientes_atendidos = 0;


            int minutos_transcurridos = 0;
            for (int i = 0; i < horas; i++)
            {
                Thread.Sleep(500);
                if (esta_libre1 == true)
                {
                    esta_libre1 = false;
                    Thread.Sleep(1000);
                    m5.Visible = false;
                    p2.Visible = false;
                    p5.Visible = true;
                    Ocupado1.Text = "En Uso";
                    Ocupado1.ForeColor = Color.FromArgb(255, 0, 0);
                    m1.Visible = true;
                    p5.Image = ProyectoLin.Properties.Resources._2;
                    juego = Convert.ToInt32(Math.Round(rand.NextDouble() * 10, 2) + 1);
                    maquina1[0] = juego;
                    espera1[0] = (maquina1[0]);
                    total_clientes_atendidos++;
                    players1 = players1 + 1;
                    game1.Text = "" + players1 + " Jugadores";
                    Player1.Text = juego + " min";
                    tiempoB1 = tiempoB1 + juego;
                    tmp1.Text = "" + (tiempoB1 / players1) + " min";
                    lblJugadores.Text = total_clientes_atendidos + "";
                }
                else if (esta_libre2 == true)
                {
                    esta_libre2 = false;
                    Thread.Sleep(1000);
                    m6.Visible = false;
                    p1.Visible = false;
                    p6.Visible = true;
                    Ocupado3.Text = "En Uso";
                    Ocupado3.ForeColor = Color.FromArgb(255, 0, 0);
                    m2.Visible = true;
                    p6.Image = ProyectoLin.Properties.Resources._1;
                    juego = Convert.ToInt32(Math.Round(rand.NextDouble() * 10, 2) + 1);
                    maquina2[0] = juego;
                    espera2[0] = (maquina2[0]);
                    total_clientes_atendidos = total_clientes_atendidos + 1;
                    players2 = players2 + 1;
                    game2.Text = "" + players2 + " Clientes";
                    Player2.Text = juego + " min";
                    tiempoB2 = tiempoB2 + juego;
                    tmp2.Text = "" + (tiempoB2 / players2) + " min";
                    lblJugadores.Text = total_clientes_atendidos + "";
                }
                else if (esta_libre3 == true)
                {
                    esta_libre3 = false;
                    Thread.Sleep(1000);
                    m7.Visible = false;
                    p3.Visible = false;
                    p7.Visible = true;
                    Ocupado2.Text = "En Uso";
                    Ocupado2.ForeColor = Color.FromArgb(255, 0, 0);
                    m3.Visible = true;
                    p7.Image = ProyectoLin.Properties.Resources._3;
                    juego = Convert.ToInt32(Math.Round(rand.NextDouble() * 10, 2) + 1);
                    maquina3[0] = juego;
                    espera3[0] = (maquina3[0]);
                    total_clientes_atendidos = total_clientes_atendidos + 1;
                    players3 = players3 + 1;
                    game3.Text = "" + players3 + " Clientes";
                    Player3.Text = juego + " min";
                    tiempoB3 = tiempoB3 + juego;
                    tmp3.Text = "" + (tiempoB3 / players3) + " min";
                    lblJugadores.Text = total_clientes_atendidos + "";
                }
                else if (esta_libre4 == true)
                {
                    esta_libre4 = false;
                    Thread.Sleep(1000);
                    m8.Visible = false;
                    p4.Visible = false;
                    p8.Visible = true;
                    Ocupado4.Text = "En Uso";
                    Ocupado4.ForeColor = Color.FromArgb(255, 0, 0);
                    m4.Visible = true;
                    p8.Image = ProyectoLin.Properties.Resources._4;
                    juego = Convert.ToInt32(Math.Round(rand.NextDouble() * 10, 2) + 1);
                    maquina4[0] = juego;
                    espera4[0] = (maquina4[0]);
                    total_clientes_atendidos = total_clientes_atendidos + 1;
                    players4 = players4 + 1;
                    game4.Text = "" + players4 + " Clientes";
                    Player4.Text = juego + " min";
                    tiempoB4 = tiempoB4 + juego;
                    tmp4.Text = "" + (tiempoB4 / players4) + " min";
                    lblJugadores.Text = total_clientes_atendidos + "";
                }
                if (reloj1 == maquina1[0])
                {
                    Player1.Text = "";
                    esta_libre1 = true;
                    p2.Visible = true;
                    p5.Visible = false;
                    m5.Visible = false;
                    m1.Visible = true;
                    Ocupado1.Text = "Desocupada";
                    Ocupado1.ForeColor = Color.FromArgb(0, 255, 0);
                    reloj1 = 0;
                }
                if (reloj2 == maquina2[0])
                {
                    Player2.Text = "";
                    esta_libre2 = true;
                    p1.Visible = true;
                    p6.Visible = false;
                    m6.Visible = false;
                    m2.Visible = true;
                    m2.Image = ProyectoLin.Properties.Resources.maquina_encendida;
                    Ocupado3.Text = "Desocupada";
                    Ocupado3.ForeColor = Color.FromArgb(0, 255, 0);
                    reloj2 = 0;
                }
                if (reloj3 == maquina3[0])
                {
                    Player3.Text = "";
                    esta_libre3 = true;
                    p3.Visible = true;
                    p7.Visible = false;
                    m7.Visible = false;
                    m3.Visible = true;
                    m3.Image = ProyectoLin.Properties.Resources.maquina_encendida;
                    Ocupado2.Text = "Desocupada";
                    Ocupado2.ForeColor = Color.FromArgb(0, 255, 0);
                    reloj3 = 0;
                }
                if (reloj4 == maquina4[0])
                {
                    Player4.Text = "";
                    esta_libre4 = true;
                    p4.Visible = true;
                    p8.Visible = false;
                    m8.Visible = false;
                    m4.Visible = true;
                    m4.Image = ProyectoLin.Properties.Resources.maquina_encendida;
                    Ocupado4.Text = "Desocupada";
                    Ocupado4.ForeColor = Color.FromArgb(0, 255, 0);
                    reloj4 = 0;
                }
                minutos_transcurridos++;
                lbl_reloj.Text = minutos_transcurridos + " min";
                reloj1++;
                reloj2++;
                reloj3++;
                reloj4++;
            }
            game1.Visible = true;
            game2.Visible = true;
            game3.Visible = true;
            game4.Visible = true;
            tmp1.Visible = true;
            tmp2.Visible = true;
            tmp3.Visible = true;
            tmp4.Visible = true;
            label2.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label6.Visible = true;
            label15.Visible = true;
            label4.Visible = true;
            label22.Visible = true;
            label8.Visible = true;
            label1.Visible = true;
            lblJugadores.Visible = true;
            lblFin.Text = "Fin de la Simulacion, se alcanzo el tiempo establecido atendiendo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;
            p5.Visible = false;
            p6.Visible = false;
            p7.Visible = false;
            p8.Visible = false;
            m1.Visible = false;
            m2.Visible = false;
            m3.Visible = false;
            m4.Visible = false;
            m5.Visible = true;
            m6.Visible = true;
            m7.Visible = true;
            m8.Visible = true;
            game1.Visible = false;
            game2.Visible = false;
            game3.Visible = false;
            game4.Visible = false;
            tmp1.Visible = false;
            tmp2.Visible = false;
            tmp3.Visible = false;
            tmp4.Visible = false;
            label2.Visible = false;
            label13.Visible = false;
            label17.Visible = false;
            label6.Visible = false;
            label15.Visible = false;
            label4.Visible = false;
            label22.Visible = false;
            label8.Visible = false;
            label1.Visible = false;
            lblJugadores.Visible = false;
        }
    }
}