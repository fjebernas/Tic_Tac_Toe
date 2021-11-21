using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeProgram
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int flag = 1;
        int[] matrix =
        {
            0,0,0,
            0,0,0,
            0,0,0
        };

        Bitmap b = new Bitmap(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\RedX.PNG");
        Bitmap b1 = new Bitmap(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\BlueO.PNG");

        private void btnRow1Col1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow1Col1.BackgroundImage = b;
                matrix[0] = 1;
                OTurn();
                Check();
                flag *= -1;
                
            } else
            {
                btnRow1Col1.BackgroundImage = b1;
                matrix[0] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col1.Click -= btnRow1Col1_Click;
        }

        private void btnRow1Col2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow1Col2.BackgroundImage = b;
                matrix[1] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow1Col2.BackgroundImage = b1;
                matrix[1] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col2.Click -= btnRow1Col2_Click;
        }

        private void btnRow1Col3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow1Col3.BackgroundImage = b;
                matrix[2] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow1Col3.BackgroundImage = b1;
                matrix[2] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col3.Click -= btnRow1Col3_Click;
        }

        private void btnRow2Col1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow2Col1.BackgroundImage = b;
                matrix[3] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col1.BackgroundImage = b1;
                matrix[3] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col1.Click -= btnRow2Col1_Click;
        }

        private void btnRow2Col2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow2Col2.BackgroundImage = b;
                matrix[4] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col2.BackgroundImage = b1;
                matrix[4] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col2.Click -= btnRow2Col2_Click;
        }

        private void btnRow2Col3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow2Col3.BackgroundImage = b;
                matrix[5] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col3.BackgroundImage = b1;
                matrix[5] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col3.Click -= btnRow2Col3_Click;
        }

        private void btnRow3Col1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow3Col1.BackgroundImage = b;
                matrix[6] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col1.BackgroundImage = b1;
                matrix[6] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col1.Click -= btnRow3Col1_Click;
        }

        private void btnRow3Col2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow3Col2.BackgroundImage = b;
                matrix[7] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col2.BackgroundImage = b1;
                matrix[7] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col2.Click -= btnRow3Col2_Click;
        }

        private void btnRow3Col3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btnRow3Col3.BackgroundImage = b;
                matrix[8] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col3.BackgroundImage = b1;
                matrix[8] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col3.Click -= btnRow3Col3_Click;
        }

        private void XTurn()
        {
            displayBox.Text = "Your Turn X!";
        }

        private void OTurn()
        {
            displayBox.Text = "Your Turn O!";
        }

        private void Check()
        {
            if (matrix[0] == 1 && matrix[1] == 1 && matrix[2] == 1 ||
                matrix[3] == 1 && matrix[4] == 1 && matrix[5] == 1 ||
                matrix[6] == 1 && matrix[7] == 1 && matrix[8] == 1 ||

                matrix[0] == 1 && matrix[3] == 1 && matrix[6] == 1 ||
                matrix[1] == 1 && matrix[4] == 1 && matrix[7] == 1 ||
                matrix[2] == 1 && matrix[5] == 1 && matrix[8] == 1 ||

                matrix[0] == 1 && matrix[4] == 1 && matrix[8] == 1 ||
                matrix[2] == 1 && matrix[4] == 1 && matrix[6] == 1
                )
            {
                displayBox.Text = "X WINS!";
                
            }
            else if (
              matrix[0] == 2 && matrix[1] == 2 && matrix[2] == 2 ||
              matrix[3] == 2 && matrix[4] == 2 && matrix[5] == 2 ||
              matrix[6] == 2 && matrix[7] == 2 && matrix[8] == 2 ||

              matrix[0] == 2 && matrix[3] == 2 && matrix[6] == 2 ||
              matrix[1] == 2 && matrix[4] == 2 && matrix[7] == 2 ||
              matrix[2] == 2 && matrix[5] == 2 && matrix[8] == 2 ||

              matrix[0] == 2 && matrix[4] == 2 && matrix[8] == 2 ||
              matrix[2] == 2 && matrix[4] == 2 && matrix[6] == 2
              )
            {
                displayBox.Text = "O WINS!";
                
            }
        }
    }
}
