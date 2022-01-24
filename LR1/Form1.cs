using FigureClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class FormFigure : Form
    {
        private Bitmap _bitmap;
        private Pen _pen;
        public FormFigure()
        {
            InitializeComponent();
            this._bitmap = new Bitmap(pictureBoxBitmap.ClientSize.Width, pictureBoxBitmap.ClientSize.Height);
            this._pen = new Pen(Color.Black, 5);
            Init.bitmap = this._bitmap;
            Init.pictureBox = pictureBoxBitmap;
            Init.pen = this._pen;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawLine(Init.pen, float.Parse(textBoxCoordX.Text), float.Parse(textBoxCoordY.Text), float.Parse(textBoxCoordX.Text) * 2, float.Parse(textBoxCoordY.Text));
            Init.pictureBox.Image = Init.bitmap;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {

        }

        private void FormFigure_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormFigure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                (new FormDrawRectangle(this)).ShowDialog();
            }
            else if (e.KeyCode == Keys.L && groupBoxAddLine.Visible == false)
            {
                groupBoxAddLine.Visible = true;
            }
            else if (e.KeyCode == Keys.L && groupBoxAddLine.Visible)
            {
                groupBoxAddLine.Visible = false;
            }
            else if(e.KeyCode == Keys.D && groupBoxDeleteFigure.Visible == false)
            {
                groupBoxDeleteFigure.Visible = true;
            }
            else if(e.KeyCode == Keys.D && groupBoxDeleteFigure.Visible)
            {
                groupBoxDeleteFigure.Visible = false;
            }
            else if(e.KeyCode == Keys.M && groupBoxMoveToFigure.Visible == false)
            {
                groupBoxMoveToFigure.Visible = true;
            }
            else if(e.KeyCode == Keys.M && groupBoxMoveToFigure.Visible)
            {
                groupBoxMoveToFigure.Visible = false;
            }
        }
    }
}
