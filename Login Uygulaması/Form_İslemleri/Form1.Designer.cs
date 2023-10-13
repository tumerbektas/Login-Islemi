namespace Form_İslemleri
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtKullaniciAdi = new TextBox();
            checkBox1 = new CheckBox();
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            TxtKod1 = new TextBox();
            label4 = new Label();
            TxtKod2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 100);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adınız:";
            label1.Click += label1_Click;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.Location = new Point(129, 97);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(193, 23);
            TxtKullaniciAdi.TabIndex = 1;
            TxtKullaniciAdi.TextChanged += TxtKullaniciAdi_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(230, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(129, 195);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(75, 26);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(129, 126);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(193, 23);
            TxtSifre.TabIndex = 2;
            TxtSifre.UseSystemPasswordChar = true;
            TxtSifre.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 129);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Şifreniz";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(129, 234);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(75, 27);
            label3.Name = "label3";
            label3.Size = new Size(297, 42);
            label3.TabIndex = 8;
            label3.Text = "Admin Login Form";
            label3.Click += label3_Click;
            // 
            // TxtKod1
            // 
            TxtKod1.Location = new Point(129, 158);
            TxtKod1.Name = "TxtKod1";
            TxtKod1.Size = new Size(87, 23);
            TxtKod1.TabIndex = 3;
            TxtKod1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 161);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 10;
            label4.Text = "Kodu Girin:";
            // 
            // TxtKod2
            // 
            TxtKod2.Enabled = false;
            TxtKod2.Location = new Point(230, 158);
            TxtKod2.Name = "TxtKod2";
            TxtKod2.Size = new Size(92, 23);
            TxtKod2.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(493, 317);
            Controls.Add(TxtKod2);
            Controls.Add(TxtKod1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(TxtSifre);
            Controls.Add(label2);
            Controls.Add(BtnGirisYap);
            Controls.Add(checkBox1);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtKullaniciAdi;
        private CheckBox checkBox1;
        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private TextBox TxtKod1;
        private Label label4;
        private TextBox TxtKod2;
        private System.Windows.Forms.Timer timer1;
    }
}