﻿namespace VEditor
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
            this.muny = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.muny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // muny
            // 
            this.muny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muny.Controls.Add(this.trackBar1);
            this.muny.Controls.Add(this.button9);
            this.muny.Controls.Add(this.button8);
            this.muny.Controls.Add(this.button7);
            this.muny.Controls.Add(this.button6);
            this.muny.Controls.Add(this.button5);
            this.muny.Controls.Add(this.button4);
            this.muny.Controls.Add(this.button3);
            this.muny.Controls.Add(this.button2);
            this.muny.Controls.Add(this.button1);
            this.muny.Controls.Add(this.color1);
            this.muny.Dock = System.Windows.Forms.DockStyle.Top;
            this.muny.Location = new System.Drawing.Point(0, 0);
            this.muny.Name = "muny";
            this.muny.Size = new System.Drawing.Size(912, 79);
            this.muny.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(316, 18);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(230, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 28);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Fuchsia;
            this.button8.Location = new System.Drawing.Point(192, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 19);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.color1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(165, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 19);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.color1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(138, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 19);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.color1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(192, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 19);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.color1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(165, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 19);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.color1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(138, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 19);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.color1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(192, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 19);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.color1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(165, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 19);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(138, 3);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(21, 19);
            this.color1.TabIndex = 0;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 451);
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
            this.ClientSize = new System.Drawing.Size(912, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.muny.ResumeLayout(false);
            this.muny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

