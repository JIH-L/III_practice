namespace HW_Loan
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
            this.labMoney = new System.Windows.Forms.Label();
            this.labDeadline = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.Location = new System.Drawing.Point(41, 39);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(117, 26);
            this.labMoney.TabIndex = 0;
            this.labMoney.Text = "貸款金額：";
            // 
            // labDeadline
            // 
            this.labDeadline.AutoSize = true;
            this.labDeadline.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDeadline.Location = new System.Drawing.Point(48, 88);
            this.labDeadline.Name = "labDeadline";
            this.labDeadline.Size = new System.Drawing.Size(110, 26);
            this.labDeadline.TabIndex = 1;
            this.labDeadline.Text = "期限(年)：";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(50, 136);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(108, 26);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)：";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirst.Location = new System.Drawing.Point(62, 188);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(96, 26);
            this.labFirst.TabIndex = 3;
            this.labFirst.Text = "頭期款：";
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(164, 35);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(150, 33);
            this.txtLoan.TabIndex = 4;
            this.txtLoan.Text = "100000";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(164, 87);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(149, 33);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "2";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(164, 135);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(150, 33);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "10";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirst.Location = new System.Drawing.Point(163, 187);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(150, 33);
            this.txtFirst.TabIndex = 7;
            this.txtFirst.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(27, 246);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(131, 46);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(196, 248);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(130, 42);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(122, 313);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(105, 56);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 410);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDeadline);
            this.Controls.Add(this.labMoney);
            this.Name = "Form1";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labDeadline;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}

