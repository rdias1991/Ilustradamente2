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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              }

        private void Historia_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Richard Feynman foi um físico norte-americano que deu contribuições importantes para a Física quântica no século XX, tanto que em 1965 ganhou o prêmio Nobel de Física graças ao seu trabalho sobre Eletrodinâmica Quântica. Biografia Feynman nasceu em Nova Iorque, no dia 11 de maio de 1918.Desde cedo demostrava interesse e facilidade para tratar de assuntos científicos. Formou - se em Física no MIT (sigla em inglês para Instituto de Tecnologia de Massachusetts), onde, durante a graduação, escreveu e publicou dois artigos: um sobre raios cósmicos e outro sobre forças moleculares.A sua pós - graduação foi feita no Instituto de Estudos Avançados de Princeton, nos EUA. Albert Einstein participava de estudos nesse instituto.";

        }
    }
}
