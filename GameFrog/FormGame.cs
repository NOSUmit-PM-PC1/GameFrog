using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFrog
{
    public partial class FormGame : Form
    {
        int[] gameField = new int[9];
        Image imgFrogRight, imgLeaf, imgFrogLeft;
        int emptyCell = 4;

        public FormGame()
        {
            InitializeComponent();
            imgFrogRight = Bitmap.FromFile("images/frogRight.png");
            imgFrogLeft = Bitmap.FromFile("images/frogLeft.png");
            imgLeaf = Bitmap.FromFile("images/leaf.png");
        }

        void NewGame()
        {
            for (int i = 0; i < 4; i++)
            {
                gameField[i] = 1;
                gameField[5 + i] = 2;
            }
        }

        private void dataGridViewGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            int currentCell = e.ColumnIndex;
            if (Math.Abs(currentCell - emptyCell) <= 2)
            {
                gameField[emptyCell] = gameField[currentCell];
                gameField[currentCell] = 0;
                emptyCell = currentCell;
                DrawField();
            }
            else
                MessageBox.Show("Так ходить нельзя!");
        }

        void DrawField()
        {
            for (int i = 0; i < 9; i++)
            {
                switch (gameField[i])
                {
                    case 0: dataGridViewGame.Rows[0].Cells[i].Value = imgLeaf; break;
                    case 1: dataGridViewGame.Rows[0].Cells[i].Value = imgFrogLeft; break;
                    case 2: dataGridViewGame.Rows[0].Cells[i].Value = imgFrogRight; break;
                }
            }
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            dataGridViewGame.Rows.Add(1);

            NewGame();
            DrawField();
        }
    }
}
