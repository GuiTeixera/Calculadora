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
    public partial class frmCalculadoraPadrao : Form
    {        
        double zika1;
        double zika2;
        double resultado;
        string operacao;
        bool loco = true;

        public frmCalculadoraPadrao()
        {                   
            InitializeComponent();
        }     

       

        //Inicio botoes numericos
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Clear();
            }                
            
            else
            {
                txtVisor.Text = txtVisor.Text + "0";
            }                       
                        
        }

            private void btnUm_Click(object sender, EventArgs e)
            {
            
               if (loco)
               {
                 txtVisor.Text = " ";
                 txtVisor.Text = "1";
                 loco = false;
               }

                 else
                 {
                    txtVisor.Text = txtVisor.Text + "1";
                 }
            }

        private void btnDois_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "2";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "2";
            }

        }

        private void btnTres_Click(object sender, EventArgs e) 
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "3";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "3";
            }

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "4";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "5";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "5";
            }

        }
        
                 

        private void btnSeis_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "6";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "6";
            }

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "7";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "7";
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "8";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "8";
            }

        }

        private void btnNove_Click(object sender, EventArgs e)
        {

            if (loco)
            {
                txtVisor.Text = "";
                txtVisor.Text = "9";
                loco = false;
            }

            else
            {
                txtVisor.Text = txtVisor.Text + "9";
            }

        }
        //Fim dos botoes numericos

      
        //Inicio dos botoes de operacoes 
        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = "+";
            loco = true;
            zika1 = double.Parse(txtVisor.Text);

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operacao = "-";
            loco = true;
            zika1 = double.Parse(txtVisor.Text);
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacao = "*";
            loco = true;
            zika1 = double.Parse(txtVisor.Text);
        }

        private void bntDividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            loco = true;
            zika1 = double.Parse(txtVisor.Text);
        }
        //Fim dos botoes de operacoes
        
          // Inicio do Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            zika2 = double.Parse(txtVisor.Text);
            loco = true;

            switch (operacao)
            {
                case "+":
                    resultado = zika1 + zika2;
                    txtVisor.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = zika1 - zika2;
                    txtVisor.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = zika1 * zika2;
                    txtVisor.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = zika1 / zika2;
                    txtVisor.Text = resultado.ToString();
                    break;
            }
        }
        //Fim do Igual

        
       //Inicio dos botoes para apagar
        private void btnApagaNumeroExibido_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            operacao = "";

        }

        private void btnLimpaContaAtual_Click(object sender, EventArgs e)
        {
            resultado = 0;
            txtVisor.Text = "";

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int g = txtVisor.Text.Length - 1;

            if (g >= 0)
            {
                txtVisor.Text = txtVisor.Text.Substring(0, g);

            }
        }
        //Fim dos botoes de apagar

        //  Inicio dos formularios para abrir as calculadoras e o sobre 
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

        private void mniEstatistica_Click(object sender, EventArgs e)
        {
            frmCalculadoraEstatistica objFrmCalculadoraEstatistica = new frmCalculadoraEstatistica();
            objFrmCalculadoraEstatistica.Show();
            this.Hide();
        }


        private void mniCalculadoraSobre_Click(object sender, EventArgs e)
        {
            frmCalculadoraSobre objFrmCalculadoraSobre = new frmCalculadoraSobre();
            objFrmCalculadoraSobre.voltar = "Padrao";
            objFrmCalculadoraSobre.Show();
            this.Hide();

        }
        // Fim dos formularios para abrir as calculadoras e o sobre 


        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text.IndexOf(",") < 0) || (lblExibicao.Text.IndexOf(",") < 0))
            {
                txtVisor.Text += ",";
                lblExibicao.Text += ",";
            }

        }



        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            double g = double.Parse(txtVisor.Text) *(-1);

            txtVisor.Text = g.ToString();
            lblExibicao.Text = g.ToString();

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            
            double x = double.Parse(txtVisor.Text);
            
            if (x < 0)

            {
                txtVisor.Text = "Entrada invalida";
            }

            else
            {
                
                x = Math.Sqrt(x);                
                txtVisor.Text = x.ToString();
                lblExibicao.Text += "√";
            }
        }

        private void frmCalculadoraPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                btnSoma.PerformClick();
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                btnSubtrair.PerformClick();
            }

            else if (e.KeyCode == Keys.Multiply)
            {
                btnMultiplicar.PerformClick();
            }

            else if (e.KeyCode == Keys.Divide)
            {
                bntDividir.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btnZero.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btnUm.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btnDois.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btnTres.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btnQuatro.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btnCinco.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btnSeis.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btnSete.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btnOito.PerformClick();
            }

            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btnNove.PerformClick();
            }
            
            else if (e.KeyCode == Keys.Back)
            {
                btnBackspace.PerformClick();
            }
            
            else if (e.KeyCode == Keys.Enter)
            {
                btnIgual.PerformClick();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                btnLimpaContaAtual.PerformClick();
            }

            else if (e.KeyCode == Keys.Delete)
            {
                btnApagaNumeroExibido.PerformClick();
            }

            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma)
            {
                btnVirgula.PerformClick();
            }

            else if (e.KeyCode == Keys.F9)
            {
                btnMaisOuMenos.PerformClick();
            }

            else if (e.KeyCode == Keys.R)
            {
                btnReciprocaNumero.PerformClick();
            }


        


        }

        
    }
}

    

                                        
    

