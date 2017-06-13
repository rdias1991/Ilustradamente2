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
    public partial class Som : Form
    {
        int confirma = 0;

       

        public Som()
        {
            InitializeComponent();
        }

        public void não_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para que se tenha um aprendizado com maior qualidade, é necessário ler e falar em voz alta o que escreveu.");
            this.Close();

        }
        
        public void sim_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Agora que você leu, escreva os pontos em que possui mais dificuldade e os que possui maior facilidade no tema estudado.");

        }
    }
}
