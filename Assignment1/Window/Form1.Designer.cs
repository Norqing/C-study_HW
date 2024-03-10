namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            result = new Button();
            Clear = new Button();
            Add = new Button();
            Sub = new Button();
            Mul = new Button();
            Div = new Button();
            CalBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            resultBox = new TextBox();
            CalBox2 = new TextBox();
            OpBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 290);
            button1.Name = "button1";
            button1.Size = new Size(78, 61);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 290);
            button2.Name = "button2";
            button2.Size = new Size(78, 61);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(533, 290);
            button3.Name = "button3";
            button3.Size = new Size(76, 61);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(314, 370);
            button4.Name = "button4";
            button4.Size = new Size(78, 67);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(423, 370);
            button5.Name = "button5";
            button5.Size = new Size(78, 67);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(533, 370);
            button6.Name = "button6";
            button6.Size = new Size(76, 67);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(314, 461);
            button7.Name = "button7";
            button7.Size = new Size(78, 58);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(423, 461);
            button8.Name = "button8";
            button8.Size = new Size(78, 58);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(533, 461);
            button9.Name = "button9";
            button9.Size = new Size(76, 58);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(423, 543);
            button10.Name = "button10";
            button10.Size = new Size(78, 57);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(533, 543);
            button11.Name = "button11";
            button11.Size = new Size(76, 57);
            button11.TabIndex = 10;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // result
            // 
            result.Location = new Point(660, 151);
            result.Name = "result";
            result.Size = new Size(91, 84);
            result.TabIndex = 11;
            result.Text = "计算";
            result.UseVisualStyleBackColor = true;
            result.Click += result_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(314, 543);
            Clear.Name = "Clear";
            Clear.Size = new Size(78, 57);
            Clear.TabIndex = 12;
            Clear.Text = "清空";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Add
            // 
            Add.Location = new Point(640, 290);
            Add.Name = "Add";
            Add.Size = new Size(63, 61);
            Add.TabIndex = 14;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(640, 370);
            Sub.Name = "Sub";
            Sub.Size = new Size(63, 67);
            Sub.TabIndex = 15;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Mul
            // 
            Mul.Location = new Point(640, 461);
            Mul.Name = "Mul";
            Mul.Size = new Size(63, 58);
            Mul.TabIndex = 16;
            Mul.Text = "*";
            Mul.UseVisualStyleBackColor = true;
            Mul.Click += Mul_Click;
            // 
            // Div
            // 
            Div.Location = new Point(640, 543);
            Div.Name = "Div";
            Div.Size = new Size(63, 57);
            Div.TabIndex = 17;
            Div.Text = "÷";
            Div.UseVisualStyleBackColor = true;
            Div.Click += Div_Click;
            // 
            // CalBox1
            // 
            CalBox1.Location = new Point(361, 133);
            CalBox1.Name = "CalBox1";
            CalBox1.Size = new Size(115, 30);
            CalBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 133);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 19;
            label1.Text = "表达式";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 202);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 20;
            label2.Text = "结果";
            // 
            // resultBox
            // 
            resultBox.Location = new Point(361, 199);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(267, 30);
            resultBox.TabIndex = 21;
            // 
            // CalBox2
            // 
            CalBox2.Location = new Point(513, 133);
            CalBox2.Name = "CalBox2";
            CalBox2.Size = new Size(115, 30);
            CalBox2.TabIndex = 23;
            // 
            // OpBox
            // 
            OpBox.Location = new Point(482, 133);
            OpBox.Name = "OpBox";
            OpBox.Size = new Size(25, 30);
            OpBox.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(962, 751);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 749);
            Controls.Add(OpBox);
            Controls.Add(CalBox2);
            Controls.Add(resultBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CalBox1);
            Controls.Add(Div);
            Controls.Add(Mul);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(Clear);
            Controls.Add(result);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button result;
        private Button Clear;
        private Button Add;
        private Button Sub;
        private Button Mul;
        private Button Div;
        private TextBox CalBox1;
        private Label label1;
        private Label label2;
        private TextBox resultBox;
        private TextBox CalBox2;
        private TextBox OpBox;
        private PictureBox pictureBox1;
    }
}