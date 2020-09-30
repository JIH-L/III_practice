namespace HW_Hello
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbEnName = new System.Windows.Forms.Label();
            this.lbsex = new System.Windows.Forms.Label();
            this.lbzodiac = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(29, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "姓名：";
            // 
            // lbEnName
            // 
            this.lbEnName.AutoSize = true;
            this.lbEnName.BackColor = System.Drawing.Color.Transparent;
            this.lbEnName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnName.ForeColor = System.Drawing.Color.White;
            this.lbEnName.Location = new System.Drawing.Point(29, 80);
            this.lbEnName.Name = "lbEnName";
            this.lbEnName.Size = new System.Drawing.Size(156, 24);
            this.lbEnName.TabIndex = 1;
            this.lbEnName.Text = "English Name：";
            // 
            // lbsex
            // 
            this.lbsex.AutoSize = true;
            this.lbsex.BackColor = System.Drawing.Color.Transparent;
            this.lbsex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbsex.ForeColor = System.Drawing.Color.White;
            this.lbsex.Location = new System.Drawing.Point(29, 126);
            this.lbsex.Name = "lbsex";
            this.lbsex.Size = new System.Drawing.Size(67, 24);
            this.lbsex.TabIndex = 2;
            this.lbsex.Text = "姓別：";
            // 
            // lbzodiac
            // 
            this.lbzodiac.AutoSize = true;
            this.lbzodiac.BackColor = System.Drawing.Color.Transparent;
            this.lbzodiac.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbzodiac.ForeColor = System.Drawing.Color.White;
            this.lbzodiac.Location = new System.Drawing.Point(29, 172);
            this.lbzodiac.Name = "lbzodiac";
            this.lbzodiac.Size = new System.Drawing.Size(67, 24);
            this.lbzodiac.TabIndex = 3;
            this.lbzodiac.Text = "星座：";
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSayHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHello.Location = new System.Drawing.Point(24, 327);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(167, 58);
            this.btnSayHello.TabIndex = 4;
            this.btnSayHello.Text = "Say Hello !";
            this.btnSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtEnName
            // 
            this.txtEnName.Location = new System.Drawing.Point(206, 80);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(138, 22);
            this.txtEnName.TabIndex = 6;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(111, 128);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(143, 22);
            this.txtSex.TabIndex = 7;
            // 
            // txtZodiac
            // 
            this.txtZodiac.Location = new System.Drawing.Point(111, 178);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(145, 22);
            this.txtZodiac.TabIndex = 8;
            // 
            // btnSayHi
            // 
            this.btnSayHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHi.Image")));
            this.btnSayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSayHi.Location = new System.Drawing.Point(228, 327);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(155, 58);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi !";
            this.btnSayHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(650, 436);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.lbzodiac);
            this.Controls.Add(this.lbsex);
            this.Controls.Add(this.lbEnName);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "你好! C#!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEnName;
        private System.Windows.Forms.Label lbsex;
        private System.Windows.Forms.Label lbzodiac;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.Button btnSayHi;
    }
}

