﻿namespace EsiniBulOyunuOnline6
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
            pnlKartlar = new Panel();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.ForeColor = Color.Black;
            pnlKartlar.Location = new Point(12, 12);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 628);
            Controls.Add(pnlKartlar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esini Bul Oyunu";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKartlar;
    }
}