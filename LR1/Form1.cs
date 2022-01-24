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
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {

        }
    }
}
