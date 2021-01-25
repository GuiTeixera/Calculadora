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
    public partial class frmCalculadoraSobre : Form
    {
        public string voltar = "";
              
       
        public frmCalculadoraSobre()
        {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
                if (voltar == "Padrao")
                {
                 frmCalculadoraPadrao objFrmCalculadoraPadrao = new frmCalculadoraPadrao();
                 objFrmCalculadoraPadrao.Show();
                 this.Hide();
                }

                else if (voltar == "Cientifica")
                {

                 frmCalculadoraCientifica objFrmCalculadoraCientifica = new frmCalculadoraCientifica();
                 objFrmCalculadoraCientifica.Show();
                 this.Hide();

                }   

                else if (voltar == "Programador")
                {
                 frmCalculadoraProgramador objFrmCalculadoraProgramador = new frmCalculadoraProgramador();
                 objFrmCalculadoraProgramador.Show();
                 this.Hide();
                }

                else if (voltar == "Estatistica")
                {
                 frmCalculadoraEstatistica objFrmCalculadoraEstatistica = new frmCalculadoraEstatistica();
                 objFrmCalculadoraEstatistica.Show();
                 this.Hide();
                }
        }


        
    }
}
