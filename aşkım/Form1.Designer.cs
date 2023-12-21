namespace aşkım
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(180, 608);
            button1.Name = "button1";
            button1.Size = new Size(104, 46);
            button1.TabIndex = 1;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(40, 608);
            button2.Name = "button2";
            button2.Size = new Size(93, 44);
            button2.TabIndex = 2;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 192);
            textBox1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(40, 245);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 113);
            textBox1.TabIndex = 3;
            textBox1.Text = "‏كيف أن كل شيء يُزهر بوجودك";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 192);
            textBox2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(40, 76);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 144);
            textBox2.TabIndex = 4;
            textBox2.Text = "‏وما احبّبتكُ لأجلُ شيء ولكِن قلبيُ تعلق بكُ .";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 192);
            textBox3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(433, 76);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 83);
            textBox3.TabIndex = 5;
            textBox3.Text = "‏لا أحـد اسّعـد منـي وانا معـك";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(255, 192, 192);
            textBox4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(25, 389);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 177);
            textBox4.TabIndex = 6;
            textBox4.Text = "\r\n‏حتى لو ابتعدنا حتى لو قلّ حديثنا ، أنا دائماً أحملكِ في زاويةٍ ما في قلبي \r\n";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 192, 192);
            textBox5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox5.ForeColor = Color.Red;
            textBox5.Location = new Point(209, 76);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 129);
            textBox5.TabIndex = 7;
            textBox5.Text = "‏أحبُّك لأنك أنت أنت لا شبيه لا مثيل لا بديل لك.";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 702);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 702);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox1;
    }
}
