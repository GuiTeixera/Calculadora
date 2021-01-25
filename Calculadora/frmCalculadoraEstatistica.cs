using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadoraEstatistica : Form
    {
        public frmCalculadoraEstatistica()
        {
            InitializeComponent();
        }

        private void mniCalculadoraPadrao_Click(object sender, EventArgs e)
        {
            frmCalculadoraPadrao objFrmCalculadoraPadrao = new frmCalculadoraPadrao();
            objFrmCalculadoraPadrao.Show();
            this.Hide();
        }

        private void mniCalculadoraCientifica_Click(object sender, EventArgs e)
        {
            frmCalculadoraCientifica objFrmCalculadoraCientifica = new frmCalculadoraCientifica();
            objFrmCalculadoraCientifica.Show();
            this.Hide();
        }

        private void mniCalculadoraProgramador_Click(object sender, EventArgs e)
        {
            frmCalculadoraProgramador objFrmCalculadoraProgramador = new frmCalculadoraProgramador();
            objFrmCalculadoraProgramador.Show();
            this.Hide();
        }

        private void sobreCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadoraSobre objFrmCalculadoraSobre = new frmCalculadoraSobre();
            objFrmCalculadoraSobre.voltar = "Estatistica";
            objFrmCalculadoraSobre.Show();
            this.Hide();
        }

        private void mniCalculadoraEstatistica_Click(object sender, EventArgs e)
        {
            frmCalculadoraEstatistica objFrmCalculadoraEstatistica = new frmCalculadoraEstatistica();
            objFrmCalculadoraEstatistica.Show();
            this.Hide();
        }
    }
}
