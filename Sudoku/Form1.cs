using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private Button[,] sudokuButtons = new Button[9, 9];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMatrix matrixCreator = new CreateMatrix(pnMatrix, sudokuButtons);
            matrixCreator.createMatrix();
        }

       
    }
}
