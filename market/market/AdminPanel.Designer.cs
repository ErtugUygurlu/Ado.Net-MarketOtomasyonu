namespace market
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.saatLbl = new System.Windows.Forms.Label();
            this.kullaniciBtn = new System.Windows.Forms.Button();
            this.urunBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.Location = new System.Drawing.Point(384, 9);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(19, 13);
            this.saniyeLbl.TabIndex = 9;
            this.saniyeLbl.Text = "00";
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.Location = new System.Drawing.Point(343, 9);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(19, 13);
            this.dakikaLbl.TabIndex = 8;
            this.dakikaLbl.Text = "00";
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.Location = new System.Drawing.Point(302, 9);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(19, 13);
            this.saatLbl.TabIndex = 7;
            this.saatLbl.Text = "00";
            // 
            // kullaniciBtn
            // 
            this.kullaniciBtn.Location = new System.Drawing.Point(49, 74);
            this.kullaniciBtn.Name = "kullaniciBtn";
            this.kullaniciBtn.Size = new System.Drawing.Size(121, 121);
            this.kullaniciBtn.TabIndex = 10;
            this.kullaniciBtn.Text = "KULLANICI";
            this.kullaniciBtn.UseVisualStyleBackColor = true;
            this.kullaniciBtn.Click += new System.EventHandler(this.kullaniciBtn_Click);
            // 
            // urunBtn
            // 
            this.urunBtn.Location = new System.Drawing.Point(247, 74);
            this.urunBtn.Name = "urunBtn";
            this.urunBtn.Size = new System.Drawing.Size(121, 121);
            this.urunBtn.TabIndex = 10;
            this.urunBtn.Text = "ÜRÜN";
            this.urunBtn.UseVisualStyleBackColor = true;
            this.urunBtn.Click += new System.EventHandler(this.urunBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(146, 226);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(121, 121);
            this.cikisBtn.TabIndex = 10;
            this.cikisBtn.Text = "ÇIKIŞ";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 411);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.urunBtn);
            this.Controls.Add(this.kullaniciBtn);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.saatLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Button kullaniciBtn;
        private System.Windows.Forms.Button urunBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}