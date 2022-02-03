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
    public partial class FormDeleteFigure : Form
    {
        private FormFigure _formFigure;
        public FormDeleteFigure(FormFigure formFigure)
        {
            InitializeComponent();
            _formFigure = formFigure;
            foreach (var item in ShapeContainer.figures)
            {
                comboBoxDeletedFigure.Items.Add(item.name);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDeletedFigure.SelectedIndex == -1)
            {
                MessageBox.Show("Фигура для удаления не выбрана");
                return;
            }
            foreach (Figure figure in ShapeContainer.figures)
            {
                if(figure.name == comboBoxDeletedFigure.SelectedItem.ToString())
                {
                    figure.DeleteF(figure, _formFigure.pictureBoxBitmap);
                    FormFigure.FormDeleteFigure = this;
                    comboBoxDeletedFigure.Text = "";
                    return;
                }
            }
            FormFigure.FormDeleteFigure = this;
        }

        private void FormDeleteFigure_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormFigure.FormDeleteFigure = this;
        }
    }
}
