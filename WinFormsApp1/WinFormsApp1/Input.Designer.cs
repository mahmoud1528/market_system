namespace WinFormsApp1
{
    partial class Input
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._690058c92fc185cf7233f4a46b7d30a91;
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 529);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(285, 416);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 17;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 279);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 15;
            label3.Text = "quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 179);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 14;
            label2.Text = "price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 69);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 13;
            label1.Text = "product_name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 276);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 179);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 65);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 73);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 18;
            label5.Text = "supplier_name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 239);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 19;
            label6.Text = "supplier_phone";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Awlad Khater", "Awlad Ragab", "Fathalla", "Spinneys", "Hyperone" });
            comboBox1.Location = new Point(568, 69);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(640, 416);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 22;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "19555", "19666", "18450", "15900", "20548" });
            comboBox2.Location = new Point(601, 239);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(157, 28);
            comboBox2.TabIndex = 23;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 531);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Input";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button button2;
        private ComboBox comboBox2;
    }
}