using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
    class LogicaDoJogo
    { 
        public string vitBolinhaTexto, vitXTexto;
        public int vito = 0, vitx = 0, rod = 0, velha = 0;
        public int[] casas = new int[9];
        public void Casa(int acao)
        {
            if (acao == 1)
            {
                for (int i = 0; i < casas.Length; i++)
                {
                    casas[i] = 3;
                }
            }
            else if (acao == 2)
            {
                int cont = 0;
                for (int i = 0; i < casas.Length; i++)
                {
                    if (casas[i] == 3)
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    this.velha++;
                    this.rod++;
                    MessageBox.Show("Deu VELHA!");                    
                    this.Casa(1);
                }
            }
        }       

        public void Ganhou(int jogador)
        {
            if (jogador == 1)
            {
                vito++;
                rod++;
                MessageBox.Show("O jogador O venceu!");
                vitBolinhaTexto = vito.ToString();               
                Casa(1);
            }
            else if (jogador == 2)
            {
                vitx++;
                rod++;
                MessageBox.Show("O jogador X venceu!");
                vitXTexto = vitx.ToString();
                Casa(1);
            }
        }
    }
}
