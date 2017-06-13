using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlustradaMente2
{
    public partial class Principal : Form
    {
        public int contadorhistoria = 0;
        public int contadorjanela = 0;
        public int contadorinicio = 0;

        public Principal()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            Significado telasignificado = new Significado();
            telasignificado.Show();
            contadorjanela = contadorjanela + 1;
            if(contadorjanela > 1)
            {
                telasignificado.Close();
                MessageBox.Show("Esta janela já está aberta");
            }
            else
            {
                telasignificado.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio telainicio = new Inicio();
            telainicio.Show();
            contadorinicio = contadorinicio + 1;
            if (contadorinicio > 1)
            {
                telainicio.Close();
                MessageBox.Show("Esta janela já está aberta");
            }
            else
            {
                telainicio.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historia telahistoria = new Historia();
            telahistoria.Show();
            contadorhistoria = contadorhistoria + 1;
            if (contadorhistoria > 1)
            {
                telahistoria.Close();
                MessageBox.Show("Esta janela já está aberta");
            }
            else if(contadorhistoria >=2)
            {
                telahistoria.Show();
            }
            else
            {

            }

        }
    }
}
