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
    public partial class frmCalculadoraCientifica : Form
    {
        public frmCalculadoraCientifica()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mniPadrao_Click(object sender, EventArgs e)
        {
            frmCalculadoraPadrao objFrmCalculadoraPadrao = new frmCalculadoraPadrao();
            objFrmCalculadoraPadrao.Show();
            this.Hide();
        }

        private void mniCientifica_Click(object sender, EventArgs e)
        {
            frmCalculadoraCientifica objFrmCalculadoraCientifica = new frmCalculadoraCientifica();
            objFrmCalculadoraCientifica.Show();
            this.Hide();

        }

        private void mniProgramador_Click(object sender, EventArgs e)
        {
            frmCalculadoraProgramador objFrmCalculadoraProgramador = new frmCalculadoraProgramador();
            objFrmCalculadoraProgramador.Show();
            this.Hide();
        }

        private void mniCalculadoraSobre_Click(object sender, EventArgs e)
        {
            frmCalculadoraSobre objFrmCalculadoraSobre = new frmCalculadoraSobre();
            objFrmCalculadoraSobre.voltar = "Cientifica";
            objFrmCalculadoraSobre.Show();
            this.Hide();
        }

        private void mniEstatistica_Click(object sender, EventArgs e)
        {
            frmCalculadoraEstatistica objFrmCalculadoraEstatistica = new frmCalculadoraEstatistica();
            objFrmCalculadoraEstatistica.Show();
            this.Hide();

        }
    }
    
}