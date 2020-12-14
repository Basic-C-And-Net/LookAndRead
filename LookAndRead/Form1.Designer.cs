
namespace LookAndRead
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSepet = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSepet = new System.Windows.Forms.Button();
            this.panelSubMenuBooks = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonPaylas = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSepet.SuspendLayout();
            this.panelSubMenuBooks.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panelSideMenu.Controls.Add(this.panelSepet);
            this.panelSideMenu.Controls.Add(this.btnSepet);
            this.panelSideMenu.Controls.Add(this.panelSubMenuBooks);
            this.panelSideMenu.Controls.Add(this.btnBooks);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(244, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSepet
            // 
            this.panelSepet.Controls.Add(this.button7);
            this.panelSepet.Controls.Add(this.button6);
            this.panelSepet.Controls.Add(this.button8);
            this.panelSepet.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSepet.Location = new System.Drawing.Point(0, 323);
            this.panelSepet.Name = "panelSepet";
            this.panelSepet.Size = new System.Drawing.Size(244, 151);
            this.panelSepet.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 90);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(244, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 45);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(244, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(244, 45);
            this.button8.TabIndex = 6;
            this.button8.Text = "Sepetim";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSepet
            // 
            this.btnSepet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btnSepet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSepet.FlatAppearance.BorderSize = 0;
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSepet.Location = new System.Drawing.Point(0, 278);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSepet.Size = new System.Drawing.Size(244, 45);
            this.btnSepet.TabIndex = 8;
            this.btnSepet.Text = "SEPETİM";
            this.btnSepet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSepet.UseVisualStyleBackColor = false;
            this.btnSepet.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelSubMenuBooks
            // 
            this.panelSubMenuBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelSubMenuBooks.Controls.Add(this.button4);
            this.panelSubMenuBooks.Controls.Add(this.button3);
            this.panelSubMenuBooks.Controls.Add(this.button2);
            this.panelSubMenuBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBooks.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuBooks.Name = "panelSubMenuBooks";
            this.panelSubMenuBooks.Size = new System.Drawing.Size(244, 133);
            this.panelSubMenuBooks.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 90);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(244, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 45);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(244, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(244, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Çok Satanlar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBooks.Location = new System.Drawing.Point(0, 100);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(244, 45);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "BOOKS";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(244, 100);
            this.panelLogo.TabIndex = 3;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.White;
            this.panelUp.Controls.Add(this.pictureBox1);
            this.panelUp.Controls.Add(this.buttonPaylas);
            this.panelUp.Controls.Add(this.buttonClose);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(244, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(706, 113);
            this.panelUp.TabIndex = 1;
            // 
            // buttonPaylas
            // 
            this.buttonPaylas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaylas.Location = new System.Drawing.Point(581, 12);
            this.buttonPaylas.Name = "buttonPaylas";
            this.buttonPaylas.Size = new System.Drawing.Size(37, 37);
            this.buttonPaylas.TabIndex = 1;
            this.buttonPaylas.Text = "P";
            this.buttonPaylas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPaylas.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(639, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 37);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(244, 113);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(706, 487);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(185, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 268);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Form";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSepet.ResumeLayout(false);
            this.panelSubMenuBooks.ResumeLayout(false);
            this.panelUp.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuBooks;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSepet;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonPaylas;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

