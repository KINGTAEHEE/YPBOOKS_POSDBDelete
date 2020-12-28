namespace POSDBDelete
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBRCODE = new System.Windows.Forms.Label();
            this.lbWKDATE = new System.Windows.Forms.Label();
            this.lbPOSNO = new System.Windows.Forms.Label();
            this.lbGROUPNO = new System.Windows.Forms.Label();
            this.lbVNO = new System.Windows.Forms.Label();
            this.tbBRCODE = new System.Windows.Forms.TextBox();
            this.tbWKDATE = new System.Windows.Forms.TextBox();
            this.tbPOSNO = new System.Windows.Forms.TextBox();
            this.tbGROUPNO = new System.Windows.Forms.TextBox();
            this.tbVNO = new System.Windows.Forms.TextBox();
            this.btDELETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbBRCODE
            // 
            this.lbBRCODE.AutoSize = true;
            this.lbBRCODE.Location = new System.Drawing.Point(56, 49);
            this.lbBRCODE.Name = "lbBRCODE";
            this.lbBRCODE.Size = new System.Drawing.Size(55, 12);
            this.lbBRCODE.TabIndex = 0;
            this.lbBRCODE.Text = "BRCODE";
            // 
            // lbWKDATE
            // 
            this.lbWKDATE.AutoSize = true;
            this.lbWKDATE.Location = new System.Drawing.Point(56, 78);
            this.lbWKDATE.Name = "lbWKDATE";
            this.lbWKDATE.Size = new System.Drawing.Size(55, 12);
            this.lbWKDATE.TabIndex = 1;
            this.lbWKDATE.Text = "WKDATE";
            // 
            // lbPOSNO
            // 
            this.lbPOSNO.AutoSize = true;
            this.lbPOSNO.Location = new System.Drawing.Point(63, 105);
            this.lbPOSNO.Name = "lbPOSNO";
            this.lbPOSNO.Size = new System.Drawing.Size(48, 12);
            this.lbPOSNO.TabIndex = 2;
            this.lbPOSNO.Text = "POSNO";
            // 
            // lbGROUPNO
            // 
            this.lbGROUPNO.AutoSize = true;
            this.lbGROUPNO.Location = new System.Drawing.Point(46, 132);
            this.lbGROUPNO.Name = "lbGROUPNO";
            this.lbGROUPNO.Size = new System.Drawing.Size(65, 12);
            this.lbGROUPNO.TabIndex = 3;
            this.lbGROUPNO.Text = "GROUPNO";
            // 
            // lbVNO
            // 
            this.lbVNO.AutoSize = true;
            this.lbVNO.Location = new System.Drawing.Point(80, 159);
            this.lbVNO.Name = "lbVNO";
            this.lbVNO.Size = new System.Drawing.Size(31, 12);
            this.lbVNO.TabIndex = 4;
            this.lbVNO.Text = "VNO";
            // 
            // tbBRCODE
            // 
            this.tbBRCODE.Location = new System.Drawing.Point(117, 45);
            this.tbBRCODE.Name = "tbBRCODE";
            this.tbBRCODE.Size = new System.Drawing.Size(100, 21);
            this.tbBRCODE.TabIndex = 5;
            // 
            // tbWKDATE
            // 
            this.tbWKDATE.Location = new System.Drawing.Point(117, 74);
            this.tbWKDATE.Name = "tbWKDATE";
            this.tbWKDATE.Size = new System.Drawing.Size(100, 21);
            this.tbWKDATE.TabIndex = 6;
            // 
            // tbPOSNO
            // 
            this.tbPOSNO.Location = new System.Drawing.Point(117, 101);
            this.tbPOSNO.Name = "tbPOSNO";
            this.tbPOSNO.Size = new System.Drawing.Size(100, 21);
            this.tbPOSNO.TabIndex = 7;
            // 
            // tbGROUPNO
            // 
            this.tbGROUPNO.Location = new System.Drawing.Point(117, 128);
            this.tbGROUPNO.Name = "tbGROUPNO";
            this.tbGROUPNO.Size = new System.Drawing.Size(100, 21);
            this.tbGROUPNO.TabIndex = 8;
            // 
            // tbVNO
            // 
            this.tbVNO.Location = new System.Drawing.Point(117, 155);
            this.tbVNO.Name = "tbVNO";
            this.tbVNO.Size = new System.Drawing.Size(100, 21);
            this.tbVNO.TabIndex = 9;
            // 
            // btDELETE
            // 
            this.btDELETE.Location = new System.Drawing.Point(80, 199);
            this.btDELETE.Name = "btDELETE";
            this.btDELETE.Size = new System.Drawing.Size(124, 51);
            this.btDELETE.TabIndex = 10;
            this.btDELETE.Text = "DELETE";
            this.btDELETE.UseVisualStyleBackColor = true;
            this.btDELETE.Click += new System.EventHandler(this.btDELETE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "※ 신중하게 입력할 것!";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 163);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조건";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDELETE);
            this.Controls.Add(this.tbVNO);
            this.Controls.Add(this.tbGROUPNO);
            this.Controls.Add(this.tbPOSNO);
            this.Controls.Add(this.tbWKDATE);
            this.Controls.Add(this.tbBRCODE);
            this.Controls.Add(this.lbVNO);
            this.Controls.Add(this.lbGROUPNO);
            this.Controls.Add(this.lbPOSNO);
            this.Controls.Add(this.lbWKDATE);
            this.Controls.Add(this.lbBRCODE);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "POS DB DELETE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBRCODE;
        private System.Windows.Forms.Label lbWKDATE;
        private System.Windows.Forms.Label lbPOSNO;
        private System.Windows.Forms.Label lbGROUPNO;
        private System.Windows.Forms.Label lbVNO;
        private System.Windows.Forms.TextBox tbBRCODE;
        private System.Windows.Forms.TextBox tbWKDATE;
        private System.Windows.Forms.TextBox tbPOSNO;
        private System.Windows.Forms.TextBox tbGROUPNO;
        private System.Windows.Forms.TextBox tbVNO;
        private System.Windows.Forms.Button btDELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

