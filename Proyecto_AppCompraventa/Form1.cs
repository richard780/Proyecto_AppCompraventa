using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Proyecto_AppCompraventa
{
    public partial class Form1 : Form
    {
        private Boolean ShowCuenta = false;

        public Form1()
        {
            InitializeComponent();
            tooglePanel();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tooglePanel()
        {
            //if (ShowCuenta)
            //{
            //    panel2.Height = 180;
            //}
            //else
            //{
            //    panel2.Height = 0;
            //}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowCuenta = !ShowCuenta;
            tooglePanel();
        }

       
      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            fechaHora();
        }
        private void fechaHora() { 

            labelfecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
 }

