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
        private FormFigure _formFigure;
        public FormMoveToFigure(FormFigure formFigure)
        {
            InitializeComponent();
            this._formFigure = formFigure;
            foreach (Figure figure in ShapeContainer.figures)
            {
                comboBoxFigures.Items.Add(figure.name);
            }
        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {
            if(comboBoxFigures.SelectedIndex == -1)
            {
                MessageBox.Show("Фигура для перемещения не выбрана");
                return;
            }
            foreach (Figure figure in ShapeContainer.figures)
            {
                if (figure.name == comboBoxFigures.SelectedItem.ToString())
                {
                    figure.MoveTo(Convert.ToInt32(textBoxCoordOffsetX.Text), Convert.ToInt32(textBoxCoordOffsetY.Text));
                    FormFigure.FormMoveToFigure = this;
                    comboBoxFigures.Text = "";
                    return;
                }
            }
            FormFigure.FormMoveToFigure = this;
        }

        private void textBoxCoordOffsetX_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormDrawRectangle.CheckIsDigit(e);
        }

        private void textBoxCoordOffsetY_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormDrawRectangle.CheckIsDigit(e);
        }
    }
}
