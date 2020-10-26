using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
    public partial class Form1 : Form
    {
        LogicaDoJogo logic = new LogicaDoJogo();
        public int[] casas = new int[9];
        public int pedra = 0, velha, vito, vitx, rod;
        bool acabou = false;

        public Form1()
        {
            InitializeComponent();
            Limpar(1);
            logic.Casa(1);
            vito = logic.vito; vitx = logic.vitx; rod = logic.rod; velha = logic.velha;
        }

        public void Limpar(int acao)
        {
            if(acao == 1)
            {
                this.pedra = 0;
                this.btn1.Text = "";
                this.btn2.Text = "";
                this.btn3.Text = "";
                this.btn4.Text = "";
                this.btn5.Text = "";
                this.btn6.Text = "";
                this.btn7.Text = "";
                this.btn8.Text = "";
                this.btn9.Text = "";
                this.label6.Text = vitx.ToString();
                this.label7.Text = vito.ToString();
                this.label8.Text = velha.ToString();
                this.label9.Text = rod.ToString();
                this.label10.Text = "";
            }
            else if(acao == 2)
            {
                this.vitx = 0;
                this.vito = 0;
                this.rod = 0;
                logic.Casa(1);
                this.Limpar(1);
            }
        }       
    
        private string VerJogador(int verPedra)
        {
            return verPedra == 0 ? "X" : "O";
        }

        private void ColocandoPedra()
        {
            label10.Text = $"{VerJogador(pedra)}";
            pedra = pedra == 0 ? 1 : 0;
            this.Analise();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(casas[0] == 3)
            {
                casas[0] = pedra;
                this.btn1.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (casas[1] == 3)
            {
                casas[1] = pedra;
                this.btn2.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (casas[2] == 3)
            {
                casas[2] = pedra;
                this.btn3.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (casas[3] == 3)
            {
                casas[3] = pedra;
                this.btn4.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (casas[4] == 3)
            {
                casas[4] = pedra;
                this.btn5.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (casas[5] == 3)
            {
                casas[5] = pedra;
                this.btn6.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (casas[6] == 3)
            {
                casas[6] = pedra;
                this.btn7.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (casas[7] == 3)
            {
                casas[7] = pedra;
                this.btn8.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (casas[8] == 3)
            {
                casas[8] = pedra;
                this.btn9.Text = this.VerJogador(this.pedra);
                ColocandoPedra();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           Limpar(2);
        }       

        private void Analise()
        {
            int venceu = 3;

            if (((casas[0] == casas[1] && casas[0] == casas[2]) || (casas[0] == casas[3] && casas[0] == casas[6]) || (casas[0] == casas[4] && casas[0] == casas[8]) && casas[0] != 3))
            {
                venceu = casas[0];
                acabou = true;
            }
            else if (((casas[4] == casas[1] && casas[4] == casas[7]) || (casas[4] == casas[3] && casas[4] == casas[5]) || (casas[4] == casas[6] && casas[4] == casas[2]) && casas[4] != 3))
            {
                venceu = casas[4];
                acabou = true;
            }
            else if (((casas[8] == casas[5] && casas[8] == casas[2]) || (casas[8] == casas[6] && casas[8] == casas[7]) && casas[8] != 3))
            {
                venceu = casas[8];
                acabou = true;
            }
            else
            {
                logic.Casa(2);
                Limpar(1);
            }

            if (acabou && venceu == 1)
            {
                logic.Ganhou(1);
                label7.Text = logic.vitBolinhaTexto.ToString();
                Limpar(1);
            }

            if (acabou && venceu == 0)
            {
                logic.Ganhou(2);
                label6.Text = logic.vitXTexto.ToString();
                Limpar(1);
            }
        }      
    }
}
