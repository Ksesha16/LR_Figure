namespace LR1
{
    partial class FormMoveToFigure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMoveToFigure = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordOffsetX = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordOffsetY = new System.Windows.Forms.TextBox();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.groupBoxMoveToFigure.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMoveToFigure
            // 
            this.groupBoxMoveToFigure.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxMoveToFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMoveToFigure.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMoveToFigure.Name = "groupBoxMoveToFigure";
            this.groupBoxMoveToFigure.Size = new System.Drawing.Size(182, 253);
            this.groupBoxMoveToFigure.TabIndex = 3;
            this.groupBoxMoveToFigure.TabStop = false;
            this.groupBoxMoveToFigure.Text = "Перемещение фигуры";
            this.groupBoxMoveToFigure.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.buttonMoveTo, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(176, 232);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxCoordOffsetX);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 52);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Смещение по X:";
            // 
            // textBoxCoordOffsetX
            // 
            this.textBoxCoordOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordOffsetX.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordOffsetX.Multiline = true;
            this.textBoxCoordOffsetX.Name = "textBoxCoordOffsetX";
            this.textBoxCoordOffsetX.Size = new System.Drawing.Size(164, 31);
            this.textBoxCoordOffsetX.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxCoordOffsetY);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 119);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 52);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Смещение по Y:";
            // 
            // textBoxCoordOffsetY
            // 
            this.textBoxCoordOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordOffsetY.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordOffsetY.Multiline = true;
            this.textBoxCoordOffsetY.Name = "textBoxCoordOffsetY";
            this.textBoxCoordOffsetY.Size = new System.Drawing.Size(164, 31);
            this.textBoxCoordOffsetY.TabIndex = 0;
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMoveTo.Location = new System.Drawing.Point(3, 177);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(170, 52);
            this.buttonMoveTo.TabIndex = 2;
            this.buttonMoveTo.Text = "Переместить";
            this.buttonMoveTo.UseVisualStyleBackColor = true;
            this.buttonMoveTo.Click += new System.EventHandler(this.buttonMoveTo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFigures);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру:";
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Location = new System.Drawing.Point(3, 18);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(164, 24);
            this.comboBoxFigures.TabIndex = 0;
            // 
            // FormMoveToFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 253);
            this.Controls.Add(this.groupBoxMoveToFigure);
            this.MaximumSize = new System.Drawing.Size(200, 300);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "FormMoveToFigure";
            this.Text = "FormMoveToFigure";
            this.groupBoxMoveToFigure.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMoveToFigure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxCoordOffsetX;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxCoordOffsetY;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFigures;
    }
}