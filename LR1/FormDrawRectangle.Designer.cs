namespace LR1
{
    partial class FormDrawRectangle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonDrawRectangle, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCoordX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите X:";
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordX.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordX.Multiline = true;
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.Size = new System.Drawing.Size(370, 43);
            this.textBoxCoordX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCoordY);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите Y:";
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCoordY.Location = new System.Drawing.Point(3, 18);
            this.textBoxCoordY.Multiline = true;
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.Size = new System.Drawing.Size(370, 43);
            this.textBoxCoordY.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxW);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Введите W:";
            // 
            // textBoxW
            // 
            this.textBoxW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxW.Location = new System.Drawing.Point(3, 18);
            this.textBoxW.Multiline = true;
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(370, 43);
            this.textBoxW.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Введите H:";
            // 
            // textBoxH
            // 
            this.textBoxH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxH.Location = new System.Drawing.Point(3, 18);
            this.textBoxH.Multiline = true;
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(370, 43);
            this.textBoxH.TabIndex = 0;
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDrawRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawRectangle.Location = new System.Drawing.Point(3, 283);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(376, 67);
            this.buttonDrawRectangle.TabIndex = 4;
            this.buttonDrawRectangle.Text = "Нарисовать";
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonDrawRectangle_Click);
            // 
            // FormDrawRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormDrawRectangle";
            this.Text = "Прямоугольник";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.TextBox textBoxCoordX;
        private System.Windows.Forms.TextBox textBoxCoordY;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxH;
    }
}