namespace PocketWorld
{
    partial class PocketWorld
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncCoin = new System.Windows.Forms.Button();
            this.btnDrawMob = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnOpenLibary = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutputCoin = new System.Windows.Forms.Label();
            this.lblOutputIncome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncCoin
            // 
            this.btnIncCoin.Location = new System.Drawing.Point(306, 478);
            this.btnIncCoin.Name = "btnIncCoin";
            this.btnIncCoin.Size = new System.Drawing.Size(176, 72);
            this.btnIncCoin.TabIndex = 0;
            this.btnIncCoin.Text = "돈벌기";
            this.btnIncCoin.UseVisualStyleBackColor = true;
            this.btnIncCoin.Click += new System.EventHandler(this.btnIncCoin_Click);
            // 
            // btnDrawMob
            // 
            this.btnDrawMob.Location = new System.Drawing.Point(692, 12);
            this.btnDrawMob.Name = "btnDrawMob";
            this.btnDrawMob.Size = new System.Drawing.Size(80, 60);
            this.btnDrawMob.TabIndex = 1;
            this.btnDrawMob.Text = "포캣몬 뽑기";
            this.btnDrawMob.UseVisualStyleBackColor = true;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(520, 12);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(80, 60);
            this.btnUpgrade.TabIndex = 2;
            this.btnUpgrade.Text = "업그레이드";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // btnOpenLibary
            // 
            this.btnOpenLibary.Location = new System.Drawing.Point(606, 12);
            this.btnOpenLibary.Name = "btnOpenLibary";
            this.btnOpenLibary.Size = new System.Drawing.Size(80, 60);
            this.btnOpenLibary.TabIndex = 3;
            this.btnOpenLibary.Text = "도감열기";
            this.btnOpenLibary.UseVisualStyleBackColor = true;
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Location = new System.Drawing.Point(12, 12);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(97, 12);
            this.lblCoin.TabIndex = 5;
            this.lblCoin.Text = "현재 코인 보유량";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(115, 12);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(53, 12);
            this.lblIncome.TabIndex = 6;
            this.lblIncome.Text = "초당수입";
            // 
            // lblOutputCoin
            // 
            this.lblOutputCoin.AutoSize = true;
            this.lblOutputCoin.Location = new System.Drawing.Point(98, 36);
            this.lblOutputCoin.Name = "lblOutputCoin";
            this.lblOutputCoin.Size = new System.Drawing.Size(11, 12);
            this.lblOutputCoin.TabIndex = 7;
            this.lblOutputCoin.Text = "0";
            // 
            // lblOutputIncome
            // 
            this.lblOutputIncome.AutoSize = true;
            this.lblOutputIncome.Location = new System.Drawing.Point(157, 36);
            this.lblOutputIncome.Name = "lblOutputIncome";
            this.lblOutputIncome.Size = new System.Drawing.Size(11, 12);
            this.lblOutputIncome.TabIndex = 8;
            this.lblOutputIncome.Text = "0";
            // 
            // PocketWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblOutputIncome);
            this.Controls.Add(this.lblOutputCoin);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.btnOpenLibary);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnDrawMob);
            this.Controls.Add(this.btnIncCoin);
            this.Name = "PocketWorld";
            this.Text = "PocketWorld";
            this.Load += new System.EventHandler(this.PocketWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncCoin;
        private System.Windows.Forms.Button btnDrawMob;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnOpenLibary;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutputCoin;
        private System.Windows.Forms.Label lblOutputIncome;
    }
}

