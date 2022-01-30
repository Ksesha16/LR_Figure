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
    public partial class FormMoveToFigure : Form
    {
        public FormMoveToFigure()
        {
            InitializeComponent();
            foreach (Figure figure in ShapeContainer.figures)
            {
                comboBoxFigures.Items.Add(figure.name);
            }
        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {

        }
    }
}
