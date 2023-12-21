namespace VEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.muny = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LayerList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.muny.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // muny
            // 
            this.muny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muny.Controls.Add(this.panel6);
            this.muny.Controls.Add(this.panel5);
            this.muny.Controls.Add(this.panel4);
            this.muny.Controls.Add(this.button11);
            this.muny.Controls.Add(this.button10);
            this.muny.Controls.Add(this.panel3);
            this.muny.Controls.Add(this.panel2);
            this.muny.Dock = System.Windows.Forms.DockStyle.Top;
            this.muny.Location = new System.Drawing.Point(0, 0);
            this.muny.Name = "muny";
            this.muny.Size = new System.Drawing.Size(1275, 115);
            this.muny.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button17);
            this.panel6.Controls.Add(this.button16);
            this.panel6.Controls.Add(this.button15);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(227, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(378, 113);
            this.panel6.TabIndex = 21;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(98, 25);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(67, 65);
            this.button17.TabIndex = 2;
            this.button17.Text = "Эллипс";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.circle_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(171, 25);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 65);
            this.button16.TabIndex = 1;
            this.button16.Text = "Прямоугольник";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(244, 24);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 65);
            this.button15.TabIndex = 0;
            this.button15.Text = "Линия";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.line_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.LayerList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(605, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 113);
            this.panel5.TabIndex = 20;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(37, 82);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(23, 26);
            this.button14.TabIndex = 18;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.LayerDelete_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(9, 82);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(24, 26);
            this.button13.TabIndex = 17;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.LayerAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Слои";
            // 
            // LayerList
            // 
            this.LayerList.FormattingEnabled = true;
            this.LayerList.ItemHeight = 16;
            this.LayerList.Location = new System.Drawing.Point(6, 25);
            this.LayerList.Name = "LayerList";
            this.LayerList.Size = new System.Drawing.Size(147, 52);
            this.LayerList.TabIndex = 0;
            this.LayerList.SelectedIndexChanged += new System.EventHandler(this.LayerList_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(761, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 113);
            this.panel4.TabIndex = 19;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 45);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 28);
            this.button12.TabIndex = 16;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.backcolor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цвет фона";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(11, 57);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(104, 37);
            this.button11.TabIndex = 18;
            this.button11.Text = "Удалить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.delete_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 37);
            this.button10.TabIndex = 17;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.color1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(843, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 113);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Цвет линии";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 28);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.color2_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Fuchsia;
            this.button8.Location = new System.Drawing.Point(103, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 19);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.color1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(76, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 19);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.color1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(49, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 19);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.color1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(103, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 19);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.color1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(76, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 19);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.color1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(49, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 19);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.color1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(103, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 19);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.color1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(76, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 19);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Black;
            this.color1.ForeColor = System.Drawing.Color.Black;
            this.color1.Location = new System.Drawing.Point(49, 25);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(21, 19);
            this.color1.TabIndex = 0;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SizeList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1059, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 113);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Размер линии";
            // 
            // SizeList
            // 
            this.SizeList.FormattingEnabled = true;
            this.SizeList.ItemHeight = 16;
            this.SizeList.Location = new System.Drawing.Point(35, 45);
            this.SizeList.Name = "SizeList";
            this.SizeList.Size = new System.Drawing.Size(140, 52);
            this.SizeList.TabIndex = 12;
            this.SizeList.SelectedIndexChanged += new System.EventHandler(this.SizeList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 547);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vector Editor";
            this.muny.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel muny;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox SizeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LayerList;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
    }
}

