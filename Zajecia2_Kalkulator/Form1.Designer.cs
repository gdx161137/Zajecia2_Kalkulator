﻿namespace Zajecia2_Kalkulator
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
            button1 = new Button();
            textBox_Result = new TextBox();
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
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            label_CurrentOperation = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 66);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClickNumber;
            // 
            // textBox_Result
            // 
            textBox_Result.Location = new Point(114, 22);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(193, 23);
            textBox_Result.TabIndex = 1;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Location = new Point(82, 66);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClickNumber;
            // 
            // button3
            // 
            button3.Location = new Point(138, 66);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClickNumber;
            // 
            // button4
            // 
            button4.Location = new Point(138, 122);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 6;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClickNumber;
            // 
            // button5
            // 
            button5.Location = new Point(82, 122);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClickNumber;
            // 
            // button6
            // 
            button6.Location = new Point(26, 122);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 4;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClickNumber;
            // 
            // button7
            // 
            button7.Location = new Point(138, 178);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 9;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClickNumber;
            // 
            // button8
            // 
            button8.Location = new Point(82, 178);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClickNumber;
            // 
            // button9
            // 
            button9.Location = new Point(26, 178);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 7;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClickNumber;
            // 
            // button10
            // 
            button10.Location = new Point(26, 234);
            button10.Name = "button10";
            button10.Size = new Size(106, 50);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonClickNumber;
            // 
            // button11
            // 
            button11.Location = new Point(201, 66);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 11;
            button11.Text = "/";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonClickOperator;
            // 
            // button12
            // 
            button12.Location = new Point(201, 122);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 12;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonClickOperator;
            // 
            // button13
            // 
            button13.Location = new Point(201, 178);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 13;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonClickOperator;
            // 
            // button14
            // 
            button14.Location = new Point(201, 234);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonClickOperator;
            // 
            // button15
            // 
            button15.Location = new Point(257, 66);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 15;
            button15.Text = "Kasuj";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonClickClear;
            // 
            // button16
            // 
            button16.Location = new Point(257, 178);
            button16.Name = "button16";
            button16.Size = new Size(50, 106);
            button16.TabIndex = 16;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += buttonClickSum;
            // 
            // button17
            // 
            button17.Location = new Point(138, 234);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 17;
            button17.Text = ",";
            button17.UseVisualStyleBackColor = true;
            button17.Click += buttonClickNumber;
            // 
            // label_CurrentOperation
            // 
            label_CurrentOperation.AutoSize = true;
            label_CurrentOperation.Location = new Point(26, 22);
            label_CurrentOperation.Name = "label_CurrentOperation";
            label_CurrentOperation.Size = new Size(0, 15);
            label_CurrentOperation.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 328);
            Controls.Add(label_CurrentOperation);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox_Result);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_Result;
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
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label label_CurrentOperation;
    }
}
