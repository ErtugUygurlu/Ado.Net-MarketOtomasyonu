namespace market
{
    partial class KasiyerPanel
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
            this.etBtn = new System.Windows.Forms.Button();
            this.sutBtn = new System.Windows.Forms.Button();
            this.sebzeBtn = new System.Windows.Forms.Button();
            this.baklaBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.saatLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // etBtn
            // 
            this.etBtn.Location = new System.Drawing.Point(45, 51);
            this.etBtn.Name = "etBtn";
            this.etBtn.Size = new System.Drawing.Size(121, 121);
            this.etBtn.TabIndex = 0;
            this.etBtn.Text = "ET";
            this.etBtn.UseVisualStyleBackColor = true;
            // 
            // sutBtn
            // 
            this.sutBtn.Location = new System.Drawing.Point(243, 51);
            this.sutBtn.Name = "sutBtn";
            this.sutBtn.Size = new System.Drawing.Size(121, 121);
            this.sutBtn.TabIndex = 1;
            this.sutBtn.Text = "SÜT";
            this.sutBtn.UseVisualStyleBackColor = true;
            // 
            // sebzeBtn
            // 
            this.sebzeBtn.Location = new System.Drawing.Point(243, 238);
            this.sebzeBtn.Name = "sebzeBtn";
            this.sebzeBtn.Size = new System.Drawing.Size(121, 121);
            this.sebzeBtn.TabIndex = 3;
            this.sebzeBtn.Text = "SEBZE";
            this.sebzeBtn.UseVisualStyleBackColor = true;
            this.sebzeBtn.Click += new System.EventHandler(this.sebzeBtn_Click);
            // 
            // baklaBtn
            // 
            this.baklaBtn.Location = new System.Drawing.Point(45, 238);
            this.baklaBtn.Name = "baklaBtn";
            this.baklaBtn.Size = new System.Drawing.Size(121, 121);
            this.baklaBtn.TabIndex = 2;
            this.baklaBtn.Text = "BAKLAGİL";
            this.baklaBtn.UseVisualStyleBackColor = true;
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(45, 365);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(81, 36);
            this.cikisBtn.TabIndex = 4;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.Location = new System.Drawing.Point(302, 9);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(35, 13);
            this.saatLbl.TabIndex = 5;
            this.saatLbl.Text = "label1";
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.Location = new System.Drawing.Point(343, 9);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(35, 13);
            this.dakikaLbl.TabIndex = 6;
            this.dakikaLbl.Text = "label2";
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.Location = new System.Drawing.Point(384, 9);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(35, 13);
            this.saniyeLbl.TabIndex = 6;
            this.saniyeLbl.Text = "label2";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 411);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.saatLbl);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.baklaBtn);
            this.Controls.Add(this.sebzeBtn);
            this.Controls.Add(this.sutBtn);
            this.Controls.Add(this.etBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button etBtn;
        private System.Windows.Forms.Button sutBtn;
        private System.Windows.Forms.Button sebzeBtn;
        private System.Windows.Forms.Button baklaBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
    }
}