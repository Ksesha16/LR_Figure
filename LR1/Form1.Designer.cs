namespace LR1
{
    partial class FormFigure
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFigure));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxBitmap = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAddLine = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.groupBoxDeleteFigure = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDeletedFigure = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxMoveToFigure = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.textBoxCoordOffsetX = new System.Windows.Forms.TextBox();
            this.textBoxCoordOffsetY = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxAddLine.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxDeleteFigure.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxMoveToFigure.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.72731F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.2727F));
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxBitmap, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 510);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // pictureBoxBitmap
            // 
            this.pictureBoxBitmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBitmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBitmap.Location = new System.Drawing.Point(176, 3);
            this.pictureBoxBitmap.Name = "pictureBoxBitmap";
            this.pictureBoxBitmap.Size = new System.Drawing.Size(621, 504);
            this.pictureBoxBitmap.TabIndex = 0;
            this.pictureBoxBitmap.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxAddLine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDeleteFigure, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxMoveToFigure, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 504);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBoxAddLine
            // 
            this.groupBoxAddLine.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxAddLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddLine.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddLine.Name = "groupBoxAddLine";
            this.groupBoxAddLine.Size = new System.Drawing.Size(161, 195);
            this.groupBoxAddLine.TabIndex = 0;
            this.groupBoxAddLine.TabStop = false;
            this.groupBoxAddLine.Text = "Добавить фигуру";
            this.groupBoxAddLine.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonDraw, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 174);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCoordX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите X:";
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordX.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordX.Multiline = true;
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.Size = new System.Drawing.Size(143, 31);
            this.textBoxCoordX.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCoordY);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введите Y:";
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordY.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordY.Multiline = true;
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.Size = new System.Drawing.Size(143, 31);
            this.textBoxCoordY.TabIndex = 0;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDraw.Location = new System.Drawing.Point(3, 119);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(149, 52);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // groupBoxDeleteFigure
            // 
            this.groupBoxDeleteFigure.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxDeleteFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDeleteFigure.Location = new System.Drawing.Point(3, 204);
            this.groupBoxDeleteFigure.Name = "groupBoxDeleteFigure";
            this.groupBoxDeleteFigure.Size = new System.Drawing.Size(161, 94);
            this.groupBoxDeleteFigure.TabIndex = 1;
            this.groupBoxDeleteFigure.TabStop = false;
            this.groupBoxDeleteFigure.Text = "Удалить фигуру";
            this.groupBoxDeleteFigure.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDeletedFigure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(155, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxDeletedFigure
            // 
            this.comboBoxDeletedFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDeletedFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeletedFigure.FormattingEnabled = true;
            this.comboBoxDeletedFigure.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDeletedFigure.Name = "comboBoxDeletedFigure";
            this.comboBoxDeletedFigure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDeletedFigure.Size = new System.Drawing.Size(149, 24);
            this.comboBoxDeletedFigure.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(3, 39);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 31);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxMoveToFigure
            // 
            this.groupBoxMoveToFigure.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxMoveToFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMoveToFigure.Location = new System.Drawing.Point(3, 304);
            this.groupBoxMoveToFigure.Name = "groupBoxMoveToFigure";
            this.groupBoxMoveToFigure.Size = new System.Drawing.Size(161, 197);
            this.groupBoxMoveToFigure.TabIndex = 2;
            this.groupBoxMoveToFigure.TabStop = false;
            this.groupBoxMoveToFigure.Text = "Перемещение фигуры";
            this.groupBoxMoveToFigure.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonMoveTo, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(155, 176);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxCoordOffsetX);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 52);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Смещение по X:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxCoordOffsetY);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 61);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 52);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Смещение по Y:";
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMoveTo.Location = new System.Drawing.Point(3, 119);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(149, 54);
            this.buttonMoveTo.TabIndex = 2;
            this.buttonMoveTo.Text = "Переместить";
            this.buttonMoveTo.UseVisualStyleBackColor = true;
            this.buttonMoveTo.Click += new System.EventHandler(this.buttonMoveTo_Click);
            // 
            // textBoxCoordOffsetX
            // 
            this.textBoxCoordOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordOffsetX.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordOffsetX.Multiline = true;
            this.textBoxCoordOffsetX.Name = "textBoxCoordOffsetX";
            this.textBoxCoordOffsetX.Size = new System.Drawing.Size(143, 31);
            this.textBoxCoordOffsetX.TabIndex = 0;
            // 
            // textBoxCoordOffsetY
            // 
            this.textBoxCoordOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordOffsetY.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordOffsetY.Multiline = true;
            this.textBoxCoordOffsetY.Name = "textBoxCoordOffsetY";
            this.textBoxCoordOffsetY.Size = new System.Drawing.Size(143, 31);
            this.textBoxCoordOffsetY.TabIndex = 0;
            // 
            // FormFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 561);
            this.MinimumSize = new System.Drawing.Size(822, 561);
            this.Name = "FormFigure";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фигуры";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFigure_KeyDown);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBitmap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxAddLine.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxDeleteFigure.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxMoveToFigure.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBoxBitmap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxAddLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCoordX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCoordY;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.GroupBox groupBoxDeleteFigure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxMoveToFigure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.TextBox textBoxCoordOffsetX;
        private System.Windows.Forms.TextBox textBoxCoordOffsetY;
        public System.Windows.Forms.ComboBox comboBoxDeletedFigure;
    }
}

