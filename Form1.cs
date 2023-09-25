using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITHUB_Test
{
    public partial class Form1 : Form
    {
        private List<int> historicoNumeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,10);

            textBox1.Text  = valorInteiro.ToString();

            historicoNumeros.Add(valorInteiro);



            // Atualize o histórico na ListBox
            AtualizarHistorico();
        }

        private void AtualizarHistorico()
        {
            listHist.Items.Clear();
            foreach (int numero in historicoNumeros)
            {
                listHist.Items.Add(numero);
            }
        }
    }
}
