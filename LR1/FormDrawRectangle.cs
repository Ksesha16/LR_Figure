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
        private Random _random = new Random();
        public FormDrawRectangle(FormFigure formFigure, string text)
        {
            InitializeComponent();
            _formFigure = formFigure;
            RandomGenerateRectangle();
            
            _text = text;
            if (_text == "Rectangle")
            {
                tableLayoutPanel1.Visible = true;
                groupBox1.Text = "Введите X:";
                groupBox2.Text = "Введите Y:";
                groupBox3.Text = "Введите W:";
                groupBox4.Text = "Введите H:";
                Text = "Прямоугольник";
            }
            else if (_text == "Line")
            {
                tableLayoutPanel1.Visible = true;
                groupBox1.Text = "Введите X1:";
                groupBox2.Text = "Введите Y1:";
                groupBox3.Text = "Введите X2:";
                groupBox4.Text = "Введите Y2:";
                Text = "Линия";
            }
        }

        private void RandomGenerateRectangle()
        {
            textBoxCoordX.Text = _random.Next(0, this._formFigure.MaximumSize.Width / 2).ToString();
            textBoxCoordY.Text = _random.Next(0, this._formFigure.MaximumSize.Height / 2).ToString();
            textBoxH.Text = _random.Next(0, this._formFigure.MaximumSize.Width / 2).ToString();
            textBoxW.Text = _random.Next(0, this._formFigure.MaximumSize.Height / 2).ToString();
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            if (_text == "Rectangle")
            {
                FigureClassLibrary.Rectangle rectangle = new FigureClassLibrary.Rectangle(Convert.ToInt32(textBoxCoordX.Text), Convert.ToInt32(textBoxCoordY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                rectangle.Draw();
                ShapeContainer.AddFigure(rectangle);
                UpdateComboBoxDeletedFigureItems();
                RandomGenerateRectangle();
            }
            else if(_text == "Line")
            {
                FigureClassLibrary.Line line = new FigureClassLibrary.Line(Convert.ToInt32(textBoxCoordX.Text), Convert.ToInt32(textBoxCoordY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                line.Draw();
                ShapeContainer.AddFigure(line);
                UpdateComboBoxDeletedFigureItems();
                RandomGenerateRectangle();
            }
        }

        private void UpdateComboBoxDeletedFigureItems()
        {
            FormFigure.FormDeleteFigure.comboBoxDeletedFigure.Items.Clear();
            FormFigure.FormMoveToFigure.comboBoxFigures.Items.Clear();
            foreach (var item in ShapeContainer.figures)
            {
                FormFigure.FormDeleteFigure.comboBoxDeletedFigure.Items.Add(item.name);
                FormFigure.FormMoveToFigure.comboBoxFigures.Items.Add(item.name);
            }
        }

        private void textBoxCoordX_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigit(e);
        }

        public static void CheckIsDigit(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxCoordY_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigit(e);
        }

        private void textBoxW_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigit(e);
        }

        private void textBoxH_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIsDigit(e);
        }
    }
}
