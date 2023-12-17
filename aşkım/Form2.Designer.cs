namespace aşkım
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(475, 597);
            button1.Name = "button1";
            button1.Size = new Size(104, 46);
            button1.TabIndex = 2;
            button1.Text = "İleri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(246, 597);
            button2.Name = "button2";
            button2.Size = new Size(104, 46);
            button2.TabIndex = 3;
            button2.Text = "Dönüş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(12, 597);
            button3.Name = "button3";
            button3.Size = new Size(104, 46);
            button3.TabIndex = 4;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 655);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 255, 255);
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.FromArgb(0, 0, 192);
            textBox1.Location = new Point(26, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 67);
            textBox1.TabIndex = 5;
            textBox1.Text = "أريد أن أختبئ من العالم ‏بأكمله في عناق منك.";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 255);
            textBox2.ForeColor = Color.FromArgb(0, 0, 192);
            textBox2.Location = new Point(26, 152);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 73);
            textBox2.TabIndex = 6;
            textBox2.Text = "غارق بك مُـتناسياً هذا العالم بأكملهُ ";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(128, 255, 255);
            textBox3.ForeColor = Color.FromArgb(0, 0, 192);
            textBox3.Location = new Point(12, 305);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 128);
            textBox3.TabIndex = 7;
            textBox3.Text = "أرى بك شيئًا مُختلفًا عن البقية لا أعلم ما هو ، لكنّه يشبهني ويناسبني و أنتمي إليه كثيرًا.\"";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(128, 255, 255);
            textBox4.ForeColor = Color.FromArgb(0, 0, 192);
            textBox4.Location = new Point(433, 138);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 74);
            textBox4.TabIndex = 8;
            textBox4.Text = "‏حديثٌك الشيء الوحيد الذي أوّد كثرته دائما";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(128, 255, 255);
            textBox5.ForeColor = Color.FromArgb(0, 0, 192);
            textBox5.Location = new Point(433, 385);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(115, 48);
            textBox5.TabIndex = 9;
            textBox5.Text = "أن يطول طريق العمر برفقتك،";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 655);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}