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
    public partial class frmCalculadoraProgramador : Form
    {
        public frmCalculadoraProgramador()
        {
            InitializeComponent();
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
            objFrmCalculadoraSobre.voltar = "Programador";
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
