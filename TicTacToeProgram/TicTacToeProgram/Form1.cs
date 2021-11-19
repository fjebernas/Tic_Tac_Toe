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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bitmap b = new Bitmap(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\RedX.PNG");
        Bitmap b1 = new Bitmap(@"C:\Users\franc\source\repos\Assign#5TicTacToe\TicTacToeProgram\TicTacToeProgram\Properties\BlueO.PNG");

        private void btnRow1Col1_Click(object sender, EventArgs e)
        {
            btnRow1Col1.BackgroundImage = b;
        }

        private void btnRow1Col2_Click(object sender, EventArgs e)
        {
            btnRow1Col2.BackgroundImage = b1;
        }

        private void btnRow1Col3_Click(object sender, EventArgs e)
        {

        }

        private void btnRow2Col1_Click(object sender, EventArgs e)
        {

        }

        private void btnRow2Col2_Click(object sender, EventArgs e)
        {

        }

        private void btnRow2Col3_Click(object sender, EventArgs e)
        {

        }

        private void btnRow3Col1_Click(object sender, EventArgs e)
        {

        }

        private void btnRow3Col2_Click(object sender, EventArgs e)
        {

        }

        private void btnRow3Col3_Click(object sender, EventArgs e)
        {

        }
    }
}
