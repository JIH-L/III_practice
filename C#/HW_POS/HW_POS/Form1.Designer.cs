namespace HW_POS
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labMenu = new System.Windows.Forms.Label();
            this.btnThor = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnIronMan = new System.Windows.Forms.Button();
            this.btnPepper = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Label();
            this.labtotal2 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCD = new System.Windows.Forms.Button();
            this.labPay = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.lablist2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(27, 25);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(240, 304);
            this.labMenu.TabIndex = 1;
            this.labMenu.Text = "任君挑選";
            // 
            // btnThor
            // 
            this.btnThor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThor.BackgroundImage")));
            this.btnThor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnThor.ForeColor = System.Drawing.Color.Black;
            this.btnThor.Location = new System.Drawing.Point(43, 62);
            this.btnThor.Name = "btnThor";
            this.btnThor.Size = new System.Drawing.Size(82, 110);
            this.btnThor.TabIndex = 2;
            this.btnThor.Text = "索爾 Thor $1200";
            this.btnThor.UseVisualStyleBackColor = true;
            this.btnThor.Click += new System.EventHandler(this.btnThor_Click);
            // 
            // btnCA
            // 
            this.btnCA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCA.BackgroundImage")));
            this.btnCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCA.ForeColor = System.Drawing.Color.Black;
            this.btnCA.Location = new System.Drawing.Point(144, 62);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(90, 110);
            this.btnCA.TabIndex = 3;
            this.btnCA.Text = "美國隊長 Captain $1500";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnIronMan
            // 
            this.btnIronMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIronMan.BackgroundImage")));
            this.btnIronMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIronMan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIronMan.ForeColor = System.Drawing.Color.Black;
            this.btnIronMan.Location = new System.Drawing.Point(43, 191);
            this.btnIronMan.Name = "btnIronMan";
            this.btnIronMan.Size = new System.Drawing.Size(82, 121);
            this.btnIronMan.TabIndex = 4;
            this.btnIronMan.Text = "鋼鐵人 Iron Man $1800";
            this.btnIronMan.UseVisualStyleBackColor = true;
            this.btnIronMan.Click += new System.EventHandler(this.btnIronMan_Click);
            // 
            // btnPepper
            // 
            this.btnPepper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPepper.BackgroundImage")));
            this.btnPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPepper.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPepper.ForeColor = System.Drawing.Color.Black;
            this.btnPepper.Location = new System.Drawing.Point(144, 191);
            this.btnPepper.Name = "btnPepper";
            this.btnPepper.Size = new System.Drawing.Size(81, 121);
            this.btnPepper.TabIndex = 5;
            this.btnPepper.Text = "浩克 Hulk $2500";
            this.btnPepper.UseVisualStyleBackColor = true;
            this.btnPepper.Click += new System.EventHandler(this.btnPepper_Click);
            // 
            // labTotal
            // 
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(282, 25);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(249, 81);
            this.labTotal.TabIndex = 6;
            this.labTotal.Text = "總金額";
            // 
            // labtotal2
            // 
            this.labtotal2.BackColor = System.Drawing.Color.Black;
            this.labtotal2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtotal2.ForeColor = System.Drawing.Color.White;
            this.labtotal2.Location = new System.Drawing.Point(333, 58);
            this.labtotal2.Name = "labtotal2";
            this.labtotal2.Size = new System.Drawing.Size(184, 31);
            this.labtotal2.TabIndex = 7;
            this.labtotal2.Text = "NT$0";
            this.labtotal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(307, 152);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(92, 39);
            this.btnCash.TabIndex = 8;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCD
            // 
            this.btnCD.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCD.Location = new System.Drawing.Point(415, 152);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(92, 39);
            this.btnCD.TabIndex = 9;
            this.btnCD.Text = "信用卡";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // labPay
            // 
            this.labPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPay.Location = new System.Drawing.Point(282, 116);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(249, 116);
            this.labPay.TabIndex = 10;
            this.labPay.Text = "付款方式";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab3.Location = new System.Drawing.Point(392, 202);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(133, 19);
            this.lab3.TabIndex = 11;
            this.lab3.Text = "信用卡加手續費3%唷";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(695, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(548, 25);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(233, 304);
            this.labList.TabIndex = 13;
            this.labList.Text = "明細";
            // 
            // lablist2
            // 
            this.lablist2.BackColor = System.Drawing.Color.White;
            this.lablist2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist2.Location = new System.Drawing.Point(559, 68);
            this.lablist2.Name = "lablist2";
            this.lablist2.Size = new System.Drawing.Size(211, 197);
            this.lablist2.TabIndex = 16;
            this.lablist2.Text = "尚未選取";
            this.lablist2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(310, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 93);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lablist2);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labtotal2);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.btnPepper);
            this.Controls.Add(this.btnIronMan);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.btnThor);
            this.Controls.Add(this.labMenu);
            this.Controls.Add(this.labPay);
            this.Name = "Form1";
            this.Text = "Marvel POS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Button btnThor;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Button btnIronMan;
        private System.Windows.Forms.Button btnPepper;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labtotal2;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Label lablist2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

