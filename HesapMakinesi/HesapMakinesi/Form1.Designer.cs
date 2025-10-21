namespace HesapMakinesi
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 49);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 96);
            button3.Name = "button3";
            button3.Size = new Size(75, 49);
            button3.TabIndex = 3;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 96);
            button4.Name = "button4";
            button4.Size = new Size(75, 49);
            button4.TabIndex = 4;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 151);
            button5.Name = "button5";
            button5.Size = new Size(75, 49);
            button5.TabIndex = 5;
            button5.Text = " √";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(93, 151);
            button6.Name = "button6";
            button6.Size = new Size(75, 49);
            button6.TabIndex = 6;
            button6.Text = "^";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 206);
            button7.Name = "button7";
            button7.Size = new Size(75, 49);
            button7.TabIndex = 7;
            button7.Text = "%";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 206);
            button8.Name = "button8";
            button8.Size = new Size(75, 49);
            button8.TabIndex = 8;
            button8.Text = "Temizle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 49);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 10;
            label1.Text = "SONUÇ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(205, 96);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 154);
            listBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 282);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox2;
        private Label label1;
        private ListBox listBox1;
        private TextBox textBox3;
    }
}
