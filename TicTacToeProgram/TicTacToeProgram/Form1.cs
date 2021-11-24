using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        SoundPlayer tadaSound = new SoundPlayer(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\TadaSound.wav");
        SoundPlayer ticSound = new SoundPlayer(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\TicSound.wav");
        SoundPlayer tacSound = new SoundPlayer(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\TacSound.wav");
        SoundPlayer drawSound = new SoundPlayer(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\DrawSound.wav");

        /*--------------------------TILE CLICKS(BELOW)--------------------------*/
        private void btnRow1Col1_Click(object sender, EventArgs e)
        {
            btnRow1Col1.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow1Col1.BackgroundImage = b;
                ticSound.Play();
                matrix[0] = 1;
                OTurn();
                Check();
                flag *= -1;
                
            } else
            {
                btnRow1Col1.BackgroundImage = b1;
                tacSound.Play();
                matrix[0] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col1.Click -= btnRow1Col1_Click;

            btnRow1Col1.MouseEnter -= btnRow1Col1_MouseEnter;
            btnRow1Col1.Cursor = Cursors.No;
        }

        private void btnRow1Col2_Click(object sender, EventArgs e)
        {
            btnRow1Col2.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow1Col2.BackgroundImage = b;
                ticSound.Play();
                matrix[1] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow1Col2.BackgroundImage = b1;
                tacSound.Play();
                matrix[1] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col2.Click -= btnRow1Col2_Click;

            btnRow1Col2.MouseEnter -= btnRow1Col2_MouseEnter;
            btnRow1Col2.Cursor = Cursors.No;
        }

        private void btnRow1Col3_Click(object sender, EventArgs e)
        {
            btnRow1Col3.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow1Col3.BackgroundImage = b;
                ticSound.Play();
                matrix[2] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow1Col3.BackgroundImage = b1;
                tacSound.Play();
                matrix[2] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow1Col3.Click -= btnRow1Col3_Click;

            btnRow1Col3.MouseEnter -= btnRow1Col3_MouseEnter;
            btnRow1Col3.Cursor = Cursors.No;
        }

        private void btnRow2Col1_Click(object sender, EventArgs e)
        {
            btnRow2Col1.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow2Col1.BackgroundImage = b;
                ticSound.Play();
                matrix[3] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col1.BackgroundImage = b1;
                tacSound.Play();
                matrix[3] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col1.Click -= btnRow2Col1_Click;

            btnRow2Col1.MouseEnter -= btnRow2Col1_MouseEnter;
            btnRow2Col1.Cursor = Cursors.No;
        }

        private void btnRow2Col2_Click(object sender, EventArgs e)
        {
            btnRow2Col2.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow2Col2.BackgroundImage = b;
                ticSound.Play();
                matrix[4] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col2.BackgroundImage = b1;
                tacSound.Play();
                matrix[4] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col2.Click -= btnRow2Col2_Click;

            btnRow2Col2.MouseEnter -= btnRow2Col2_MouseEnter;
            btnRow2Col2.Cursor = Cursors.No;
        }

        private void btnRow2Col3_Click(object sender, EventArgs e)
        {
            btnRow2Col3.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow2Col3.BackgroundImage = b;
                ticSound.Play();
                matrix[5] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow2Col3.BackgroundImage = b1;
                tacSound.Play();
                matrix[5] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow2Col3.Click -= btnRow2Col3_Click;

            btnRow2Col3.MouseEnter -= btnRow2Col3_MouseEnter;
            btnRow2Col3.Cursor = Cursors.No;
        }

        private void btnRow3Col1_Click(object sender, EventArgs e)
        {
            btnRow3Col1.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow3Col1.BackgroundImage = b;
                ticSound.Play();
                matrix[6] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col1.BackgroundImage = b1;
                tacSound.Play();
                matrix[6] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col1.Click -= btnRow3Col1_Click;

            btnRow3Col1.MouseEnter -= btnRow3Col1_MouseEnter;
            btnRow3Col1.Cursor = Cursors.No;
        }

        private void btnRow3Col2_Click(object sender, EventArgs e)
        {
            btnRow3Col2.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow3Col2.BackgroundImage = b;
                ticSound.Play();
                matrix[7] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col2.BackgroundImage = b1;
                tacSound.Play();
                matrix[7] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col2.Click -= btnRow3Col2_Click;

            btnRow3Col2.MouseEnter -= btnRow3Col2_MouseEnter;
            btnRow3Col2.Cursor = Cursors.No;
        }

        private void btnRow3Col3_Click(object sender, EventArgs e)
        {
            btnRow3Col3.BackColor = Color.Black;

            if (flag == 1)
            {
                btnRow3Col3.BackgroundImage = b;
                ticSound.Play();
                matrix[8] = 1;
                OTurn();
                Check();
                flag *= -1;
            }
            else
            {
                btnRow3Col3.BackgroundImage = b1;
                tacSound.Play();
                matrix[8] = 2;
                XTurn();
                Check();
                flag *= -1;
            }

            btnRow3Col3.Click -= btnRow3Col3_Click;

            btnRow3Col3.MouseEnter -= btnRow3Col3_MouseEnter;
            btnRow3Col3.Cursor = Cursors.No;
        }
        /*--------------------------TILE CLICKERS(ABOVE)--------------------------*/

        private void XTurn()
        {
            headText.Text = "Your Turn X!";
        }

        private void OTurn()
        {
            headText.Text = "Your Turn O!";
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
                headText.Text = "    X WINS!";
                tadaSound.Play();
                GameOver();
                MessageBox.Show("         X WINS!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                headText.Text = "    O WINS!";
                tadaSound.Play();
                GameOver();
                MessageBox.Show("         O WINS!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
            } else if (
                matrix[0] != 0 &&
                matrix[1] != 0 &&
                matrix[2] != 0 &&
                matrix[3] != 0 &&
                matrix[4] != 0 &&
                matrix[5] != 0 &&
                matrix[6] != 0 &&
                matrix[7] != 0 &&
                matrix[8] != 0
                )
            {
                headText.Text = "     DRAW";
                drawSound.Play();
                GameOver();
                MessageBox.Show("          DRAW", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void GameOver()
        {
            if (matrix[0] == 1 && matrix[1] == 1 && matrix[2] == 1 ||
                matrix[0] == 2 && matrix[1] == 2 && matrix[2] == 2)
            {
                btnRow1Col1.BackColor = Color.Orange;
                btnRow1Col2.BackColor = Color.Orange;
                btnRow1Col3.BackColor = Color.Orange;
            } else if (matrix[3] == 1 && matrix[4] == 1 && matrix[5] == 1 ||
                       matrix[3] == 2 && matrix[4] == 2 && matrix[5] == 2)
            {
                btnRow2Col1.BackColor = Color.Orange;
                btnRow2Col2.BackColor = Color.Orange;
                btnRow2Col3.BackColor = Color.Orange;
            } else if (matrix[6] == 1 && matrix[7] == 1 && matrix[8] == 1 ||
                       matrix[6] == 1 && matrix[7] == 1 && matrix[8] == 1)
            {
                btnRow3Col1.BackColor = Color.Orange;
                btnRow3Col2.BackColor = Color.Orange;
                btnRow3Col3.BackColor = Color.Orange;
            } 
            
              else if (matrix[0] == 1 && matrix[3] == 1 && matrix[6] == 1 ||
                       matrix[0] == 2 && matrix[3] == 2 && matrix[6] == 2)
            {
                btnRow1Col1.BackColor = Color.Orange;
                btnRow2Col1.BackColor = Color.Orange;
                btnRow3Col1.BackColor = Color.Orange;
            } else if (matrix[1] == 1 && matrix[4] == 1 && matrix[7] == 1 ||
                       matrix[1] == 2 && matrix[4] == 2 && matrix[7] == 2)
            {
                btnRow1Col2.BackColor = Color.Orange;
                btnRow2Col2.BackColor = Color.Orange;
                btnRow3Col2.BackColor = Color.Orange;
            } else if (matrix[2] == 1 && matrix[5] == 1 && matrix[8] == 1 ||
                       matrix[2] == 2 && matrix[5] == 2 && matrix[8] == 2)
            {
                btnRow1Col3.BackColor = Color.Orange;
                btnRow2Col3.BackColor = Color.Orange;
                btnRow3Col3.BackColor = Color.Orange;
            } else if (matrix[0] == 1 && matrix[4] == 1 && matrix[8] == 1 ||
                       matrix[0] == 2 && matrix[4] == 2 && matrix[8] == 2)
            {
                btnRow1Col1.BackColor = Color.Orange;
                btnRow2Col2.BackColor = Color.Orange;
                btnRow3Col3.BackColor = Color.Orange;
            } else if (matrix[2] == 1 && matrix[4] == 1 && matrix[6] == 1 ||
                       matrix[2] == 2 && matrix[4] == 2 && matrix[6] == 2)
            {
                btnRow1Col3.BackColor = Color.Orange;
                btnRow2Col2.BackColor = Color.Orange;
                btnRow3Col1.BackColor = Color.Orange;
            }

            btnRow1Col1.Click -= btnRow1Col1_Click;
            btnRow1Col2.Click -= btnRow1Col2_Click;
            btnRow1Col3.Click -= btnRow1Col3_Click;
            btnRow2Col1.Click -= btnRow2Col1_Click;
            btnRow2Col2.Click -= btnRow2Col2_Click;
            btnRow2Col3.Click -= btnRow2Col3_Click;
            btnRow3Col1.Click -= btnRow3Col1_Click;
            btnRow3Col2.Click -= btnRow3Col2_Click;
            btnRow3Col3.Click -= btnRow3Col3_Click;

            btnRow1Col1.MouseEnter -= btnRow1Col1_MouseEnter;
            btnRow1Col2.MouseEnter -= btnRow1Col2_MouseEnter;
            btnRow1Col3.MouseEnter -= btnRow1Col3_MouseEnter;
            btnRow2Col1.MouseEnter -= btnRow2Col1_MouseEnter;
            btnRow2Col2.MouseEnter -= btnRow2Col2_MouseEnter;
            btnRow2Col3.MouseEnter -= btnRow2Col3_MouseEnter;
            btnRow3Col1.MouseEnter -= btnRow3Col1_MouseEnter;
            btnRow3Col2.MouseEnter -= btnRow3Col2_MouseEnter;
            btnRow3Col3.MouseEnter -= btnRow3Col3_MouseEnter;

            btnRow1Col1.MouseLeave -= btnRow1Col1_MouseLeave;
            btnRow1Col2.MouseLeave -= btnRow1Col2_MouseLeave;
            btnRow1Col3.MouseLeave -= btnRow1Col3_MouseLeave;
            btnRow2Col1.MouseLeave -= btnRow2Col1_MouseLeave;
            btnRow2Col2.MouseLeave -= btnRow2Col2_MouseLeave;
            btnRow2Col3.MouseLeave -= btnRow2Col3_MouseLeave;
            btnRow3Col1.MouseLeave -= btnRow3Col1_MouseLeave;
            btnRow3Col2.MouseLeave -= btnRow3Col2_MouseLeave;
            btnRow3Col3.MouseLeave -= btnRow3Col3_MouseLeave;

            btnRow1Col1.Cursor = Cursors.No;
            btnRow1Col2.Cursor = Cursors.No;
            btnRow1Col3.Cursor = Cursors.No;
            btnRow2Col1.Cursor = Cursors.No;
            btnRow2Col2.Cursor = Cursors.No;
            btnRow2Col3.Cursor = Cursors.No;
            btnRow3Col1.Cursor = Cursors.No;
            btnRow3Col2.Cursor = Cursors.No;
            btnRow3Col3.Cursor = Cursors.No;
        }

        /*--------------------------TILE HIGHLIGHTERS(BELOW)--------------------------*/
        private void btnRow1Col1_MouseEnter(object sender, EventArgs e)
        {
            btnRow1Col1.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow1Col1_MouseLeave(object sender, EventArgs e)
        {
            btnRow1Col1.BackColor = Color.Black;
        }

        private void btnRow1Col2_MouseEnter(object sender, EventArgs e)
        {
            btnRow1Col2.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow1Col2_MouseLeave(object sender, EventArgs e)
        {
            btnRow1Col2.BackColor = Color.Black; ;
        }

        private void btnRow1Col3_MouseEnter(object sender, EventArgs e)
        {
            btnRow1Col3.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow1Col3_MouseLeave(object sender, EventArgs e)
        {
            btnRow1Col3.BackColor = Color.Black;
        }

        private void btnRow2Col1_MouseEnter(object sender, EventArgs e)
        {
            btnRow2Col1.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow2Col1_MouseLeave(object sender, EventArgs e)
        {
            btnRow2Col1.BackColor = Color.Black;
        }

        private void btnRow2Col2_MouseEnter(object sender, EventArgs e)
        {
            btnRow2Col2.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow2Col2_MouseLeave(object sender, EventArgs e)
        {
            btnRow2Col2.BackColor = Color.Black;
        }

        private void btnRow2Col3_MouseEnter(object sender, EventArgs e)
        {
            btnRow2Col3.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow2Col3_MouseLeave(object sender, EventArgs e)
        {
            btnRow2Col3.BackColor = Color.Black;
        }

        private void btnRow3Col1_MouseEnter(object sender, EventArgs e)
        {
            btnRow3Col1.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow3Col1_MouseLeave(object sender, EventArgs e)
        {
            btnRow3Col1.BackColor = Color.Black;
        }

        private void btnRow3Col2_MouseEnter(object sender, EventArgs e)
        {
            btnRow3Col2.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow3Col2_MouseLeave(object sender, EventArgs e)
        {
            btnRow3Col2.BackColor = Color.Black;
        }

        private void btnRow3Col3_MouseEnter(object sender, EventArgs e)
        {
            btnRow3Col3.BackColor = Color.DarkOliveGreen;
        }

        private void btnRow3Col3_MouseLeave(object sender, EventArgs e)
        {
            btnRow3Col3.BackColor = Color.Black;
        }
        /*--------------------------TILE HIGHLIGHTERS(ABOVE)--------------------------*/




        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
