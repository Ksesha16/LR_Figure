using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureClassLibrary;

namespace LR1
{
    public partial class FormDrawRectangle : Form
    {
        private FormFigure _formFigure;
        public FormDrawRectangle(FormFigure formFigure)
        {
            InitializeComponent();
            _formFigure = formFigure;
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            FigureClassLibrary.Rectangle rectangle = new FigureClassLibrary.Rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            rectangle.Draw();
            ShapeContainer.AddFigure(rectangle);
            _formFigure.comboBoxDeletedFigure.Items.Clear();
            foreach (var item in ShapeContainer.figures)
            {
                _formFigure.comboBoxDeletedFigure.Items.Add(item.ToString());
            }
        }
    }
}
