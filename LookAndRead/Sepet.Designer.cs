﻿
namespace LookAndRead
{
    partial class Sepet
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBackSepet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(219, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 178);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sepetim";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonBackSepet
            // 
            this.buttonBackSepet.Location = new System.Drawing.Point(65, 49);
            this.buttonBackSepet.Name = "buttonBackSepet";
            this.buttonBackSepet.Size = new System.Drawing.Size(75, 23);
            this.buttonBackSepet.TabIndex = 1;
            this.buttonBackSepet.Text = "BACK";
            this.buttonBackSepet.UseVisualStyleBackColor = true;
            this.buttonBackSepet.Click += new System.EventHandler(this.buttonBackSepet_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 453);
            this.Controls.Add(this.buttonBackSepet);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBackSepet;
    }
}