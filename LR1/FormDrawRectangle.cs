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
        private string _text;
        public FormDrawRectangle(FormFigure formFigure, string text)
        {
            InitializeComponent();
            _formFigure = formFigure;
            _text = text;
            if(_text == "Rectangle")
            {
                tableLayoutPanel1.Visible = true;
                groupBox1.Text = "Введите X:";
                groupBox2.Text = "Введите Y:";
                groupBox3.Text = "Введите W:";
                groupBox4.Text = "Введите H:";
                Text = "Прямоугольник";
            }
            else if(_text == "Line")
            {
                tableLayoutPanel1.Visible = true;
                groupBox1.Text = "Введите X1:";
                groupBox2.Text = "Введите Y1:";
                groupBox3.Text = "Введите X2:";
                groupBox4.Text = "Введите Y2:";
                Text = "Линия";
            }
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            if (_text == "Rectangle")
            {
                FigureClassLibrary.Rectangle rectangle = new FigureClassLibrary.Rectangle(Convert.ToInt32(textBoxCoordX.Text), Convert.ToInt32(textBoxCoordY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                rectangle.Draw();
                ShapeContainer.AddFigure(rectangle);
                UpdateComboBoxDeletedFigureItems();
            }
            else if(_text == "Line")
            {
                FigureClassLibrary.Line line = new FigureClassLibrary.Line(Convert.ToInt32(textBoxCoordX.Text), Convert.ToInt32(textBoxCoordY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                line.Draw();
                ShapeContainer.AddFigure(line);
                UpdateComboBoxDeletedFigureItems();
            }
        }

        private void UpdateComboBoxDeletedFigureItems()
        {
            FormFigure.FormDeleteFigure.comboBoxDeletedFigure.Items.Clear();
            foreach (var item in ShapeContainer.figures)
            {
                FormFigure.FormDeleteFigure.comboBoxDeletedFigure.Items.Add(item.name);
            }
        }
    }
}
