namespace HW_Student_StructForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labShow = new System.Windows.Forms.Label();
            this.labShowHL = new System.Windows.Forms.Label();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文：";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(32, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "儲存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(159, 262);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(147, 51);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "顯示儲存內容(&S)";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShowHL);
            this.groupBox1.Controls.Add(this.labShow);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(341, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 333);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(102, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 33);
            this.txtName.TabIndex = 7;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCN.Location = new System.Drawing.Point(102, 76);
            this.txtCN.Name = "txtCN";
            this.txtCN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCN.Size = new System.Drawing.Size(153, 33);
            this.txtCN.TabIndex = 8;
            this.txtCN.Text = "0";
            this.txtCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEN.Location = new System.Drawing.Point(102, 127);
            this.txtEN.Name = "txtEN";
            this.txtEN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEN.Size = new System.Drawing.Size(153, 33);
            this.txtEN.TabIndex = 9;
            this.txtEN.Text = "0";
            this.txtEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(102, 178);
            this.txtMath.Name = "txtMath";
            this.txtMath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMath.Size = new System.Drawing.Size(153, 33);
            this.txtMath.TabIndex = 10;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(15, 40);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(241, 172);
            this.labShow.TabIndex = 0;
            // 
            // labShowHL
            // 
            this.labShowHL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowHL.Location = new System.Drawing.Point(15, 223);
            this.labShowHL.Name = "labShowHL";
            this.labShowHL.Size = new System.Drawing.Size(241, 97);
            this.labShowHL.TabIndex = 1;
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighLow.Location = new System.Drawing.Point(423, 355);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(190, 46);
            this.btnHighLow.TabIndex = 11;
            this.btnHighLow.Text = "最高分 / 最低分科目";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 439);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labShowHL;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnHighLow;
    }
}

