namespace EsiniBulOyunuOnline6
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
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.BackgroundImageLayout = ImageLayout.Center;
            pnlKartlar.ForeColor = Color.Black;
            pnlKartlar.Location = new Point(13, 31);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 637);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gboYeniOyun.Location = new Point(208, 186);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(204, 337);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb5
            // 
            rb5.Anchor = AnchorStyles.None;
            rb5.AutoSize = true;
            rb5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.Location = new Point(19, 238);
            rb5.Name = "rb5";
            rb5.Size = new Size(125, 36);
            rb5.TabIndex = 5;
            rb5.TabStop = true;
            rb5.Text = "Cok Zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.Anchor = AnchorStyles.None;
            rb4.AutoSize = true;
            rb4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.Location = new Point(19, 187);
            rb4.Name = "rb4";
            rb4.Size = new Size(75, 36);
            rb4.TabIndex = 4;
            rb4.TabStop = true;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.Anchor = AnchorStyles.None;
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location = new Point(19, 136);
            rb3.Name = "rb3";
            rb3.Size = new Size(86, 36);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.Anchor = AnchorStyles.None;
            rb2.AutoSize = true;
            rb2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location = new Point(19, 85);
            rb2.Name = "rb2";
            rb2.Size = new Size(99, 36);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.AutoSize = true;
            rb1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(19, 34);
            rb1.Name = "rb1";
            rb1.Size = new Size(149, 36);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Cok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOyunuBaslat.Location = new Point(6, 289);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(192, 40);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Baslat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(626, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(57, 24);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(181, 26);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(626, 680);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esini Bul Oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private RadioButton rb1;
        private Button btnOyunuBaslat;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}