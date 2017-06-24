using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        int vez = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void b1(object sender, EventArgs e)
        {
             if (vez == 1)
            {
                if (button1.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button1.BackColor = Color.Red;
                    final();
                    vez = 2;
                }
            }
            else if (vez == 2)
            {
                if (button1.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button1.BackColor = Color.Blue;
                    final();
                    vez = 1;
                }
            }
        }
        private void b2(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button2.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button2.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button2.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button2.BackColor = Color.Blue;
                    vez = 1;
                    final();
                }
            }

        }
        private void b3(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button3.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button3.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button3.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button3.BackColor = Color.Blue;
                    vez = 1;
                    final();
                }
            }
        }
        private void b4(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button4.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button4.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button4.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button4.BackColor = Color.Blue;
                    vez = 1;
                    final();
                }
            }
        }
        private void b5(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button5.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button5.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button5.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button5.BackColor = Color.Blue;
                    vez = 1;
                    final();

                }
            }
        }
        private void b6(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button6.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button6.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button6.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button6.BackColor = Color.Blue;
                    vez = 1;
                    final();

                }
            }
        }
        private void b7(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button7.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button7.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button7.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button7.BackColor = Color.Blue;
                    vez = 1;
                    final();
                }
            }
        }
        private void b8(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button8.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button8.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button8.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button8.BackColor = Color.Blue;
                    vez = 1;
                    final();
                }
            }
        }
        private void b9(object sender, EventArgs e)
        {
            if (vez == 1)
            {
                if (button9.BackColor == Color.Blue)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button9.BackColor = Color.Red;
                    vez = 2;
                    final();
                }
            }
            else if (vez == 2)
            {
                if (button9.BackColor == Color.Red)
                {
                    MessageBox.Show("Este campo já foi preenchido");
                }
                else
                {
                    button9.BackColor = Color.Blue;
                    vez = 1;
                    final();
                   }
            }
        }

        private void final()
        {
            if (button1.BackColor == Color.Red && button2.BackColor == Color.Red && button3.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button1.BackColor == Color.Red && button5.BackColor == Color.Red && button9.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button1.BackColor == Color.Red && button4.BackColor == Color.Red && button7.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }

            if (button1.BackColor == Color.Blue && button2.BackColor == Color.Blue && button3.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button1.BackColor == Color.Blue && button5.BackColor == Color.Blue && button9.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button1.BackColor == Color.Blue && button4.BackColor == Color.Blue && button7.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button2.BackColor == Color.Red && button5.BackColor == Color.Red && button8.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button2.BackColor == Color.Blue && button5.BackColor == Color.Blue && button8.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button3.BackColor == Color.Red && button5.BackColor == Color.Red && button7.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button3.BackColor == Color.Blue && button5.BackColor == Color.Blue && button7.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button3.BackColor == Color.Red && button6.BackColor == Color.Red && button9.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button3.BackColor == Color.Blue && button6.BackColor == Color.Blue && button9.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button4.BackColor == Color.Red && button5.BackColor == Color.Red && button6.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button4.BackColor == Color.Blue && button5.BackColor == Color.Blue && button6.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button7.BackColor == Color.Red && button8.BackColor == Color.Red && button9.BackColor == Color.Red)
            {
                MessageBox.Show("O VERMELHO É O VENCEDOR !!!");
                Limpar();
            }
            if (button7.BackColor == Color.Blue && button8.BackColor == Color.Blue && button9.BackColor == Color.Blue)
            {
                MessageBox.Show("O AZUL É O VENCEDOR !!!");
                Limpar();
            }
            if (button1.BackColor != Color.White && button2.BackColor != Color.White && button3.BackColor != Color.White && button4.BackColor != Color.White && button5.BackColor != Color.White && button6.BackColor != Color.White && button7.BackColor != Color.White && button8.BackColor != Color.White && button9.BackColor != Color.White)
            {
                MessageBox.Show("DEU VELHA !!!");
                Limpar();
            }
        }
        private void Limpar()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }
        private void L_click(object sender, EventArgs e)
        {
            Limpar();
        }
      }
    }



