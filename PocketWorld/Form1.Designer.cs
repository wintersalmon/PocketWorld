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
            this.btnDrawMob = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnOpenLibary = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutputCoin = new System.Windows.Forms.Label();
            this.lblOutputIncome = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblOutputUserMobIdLIst = new System.Windows.Forms.Label();
            this.lblIncomeResult = new System.Windows.Forms.Label();
            this.lblNextIncomeCost = new System.Windows.Forms.Label();
            this.lblNextIncomeValue = new System.Windows.Forms.Label();
            this.lblOutputNextIncomeCost = new System.Windows.Forms.Label();
            this.lblOutputNextIncomeValue = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrawMob
            // 
            this.btnDrawMob.AutoSize = true;
            this.btnDrawMob.Location = new System.Drawing.Point(673, 10);
            this.btnDrawMob.Name = "btnDrawMob";
            this.btnDrawMob.Size = new System.Drawing.Size(79, 46);
            this.btnDrawMob.TabIndex = 1;
            this.btnDrawMob.Text = "포캣몬 뽑기";
            this.btnDrawMob.UseVisualStyleBackColor = true;
            this.btnDrawMob.Click += new System.EventHandler(this.btnDrawMob_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.AutoSize = true;
            this.btnUpgrade.Location = new System.Drawing.Point(511, 10);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 46);
            this.btnUpgrade.TabIndex = 2;
            this.btnUpgrade.Text = "업그레이드";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // btnOpenLibary
            // 
            this.btnOpenLibary.AutoSize = true;
            this.btnOpenLibary.Location = new System.Drawing.Point(592, 10);
            this.btnOpenLibary.Name = "btnOpenLibary";
            this.btnOpenLibary.Size = new System.Drawing.Size(75, 46);
            this.btnOpenLibary.TabIndex = 3;
            this.btnOpenLibary.Text = "도감열기";
            this.btnOpenLibary.UseVisualStyleBackColor = true;
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblCoin.Location = new System.Drawing.Point(3, 10);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(85, 19);
            this.lblCoin.TabIndex = 5;
            this.lblCoin.Text = "보유코인";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblIncome.Location = new System.Drawing.Point(94, 10);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(85, 19);
            this.lblIncome.TabIndex = 6;
            this.lblIncome.Text = "클릭수입";
            // 
            // lblOutputCoin
            // 
            this.lblOutputCoin.AutoSize = true;
            this.lblOutputCoin.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblOutputCoin.Location = new System.Drawing.Point(69, 34);
            this.lblOutputCoin.Name = "lblOutputCoin";
            this.lblOutputCoin.Size = new System.Drawing.Size(19, 19);
            this.lblOutputCoin.TabIndex = 7;
            this.lblOutputCoin.Text = "0";
            // 
            // lblOutputIncome
            // 
            this.lblOutputIncome.AutoSize = true;
            this.lblOutputIncome.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblOutputIncome.Location = new System.Drawing.Point(160, 34);
            this.lblOutputIncome.Name = "lblOutputIncome";
            this.lblOutputIncome.Size = new System.Drawing.Size(19, 19);
            this.lblOutputIncome.TabIndex = 8;
            this.lblOutputIncome.Text = "0";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.lblOutputUserMobIdLIst);
            this.mainPanel.Controls.Add(this.lblIncomeResult);
            this.mainPanel.Location = new System.Drawing.Point(12, 143);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 400);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // lblOutputUserMobIdLIst
            // 
            this.lblOutputUserMobIdLIst.AutoSize = true;
            this.lblOutputUserMobIdLIst.Location = new System.Drawing.Point(5, 18);
            this.lblOutputUserMobIdLIst.Name = "lblOutputUserMobIdLIst";
            this.lblOutputUserMobIdLIst.Size = new System.Drawing.Size(40, 12);
            this.lblOutputUserMobIdLIst.TabIndex = 1;
            this.lblOutputUserMobIdLIst.Text = "MobId";
            // 
            // lblIncomeResult
            // 
            this.lblIncomeResult.AutoSize = true;
            this.lblIncomeResult.Font = new System.Drawing.Font("Gulim", 15F);
            this.lblIncomeResult.Location = new System.Drawing.Point(94, 80);
            this.lblIncomeResult.Name = "lblIncomeResult";
            this.lblIncomeResult.Size = new System.Drawing.Size(30, 20);
            this.lblIncomeResult.TabIndex = 0;
            this.lblIncomeResult.Text = "...";
            // 
            // lblNextIncomeCost
            // 
            this.lblNextIncomeCost.AutoSize = true;
            this.lblNextIncomeCost.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblNextIncomeCost.Location = new System.Drawing.Point(185, 10);
            this.lblNextIncomeCost.Name = "lblNextIncomeCost";
            this.lblNextIncomeCost.Size = new System.Drawing.Size(148, 19);
            this.lblNextIncomeCost.TabIndex = 9;
            this.lblNextIncomeCost.Text = "업그레이드 가격";
            // 
            // lblNextIncomeValue
            // 
            this.lblNextIncomeValue.AutoSize = true;
            this.lblNextIncomeValue.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblNextIncomeValue.Location = new System.Drawing.Point(339, 10);
            this.lblNextIncomeValue.Name = "lblNextIncomeValue";
            this.lblNextIncomeValue.Size = new System.Drawing.Size(167, 19);
            this.lblNextIncomeValue.TabIndex = 10;
            this.lblNextIncomeValue.Text = "업그레이드 증가량";
            // 
            // lblOutputNextIncomeCost
            // 
            this.lblOutputNextIncomeCost.AutoSize = true;
            this.lblOutputNextIncomeCost.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblOutputNextIncomeCost.Location = new System.Drawing.Point(278, 34);
            this.lblOutputNextIncomeCost.Name = "lblOutputNextIncomeCost";
            this.lblOutputNextIncomeCost.Size = new System.Drawing.Size(19, 19);
            this.lblOutputNextIncomeCost.TabIndex = 11;
            this.lblOutputNextIncomeCost.Text = "0";
            // 
            // lblOutputNextIncomeValue
            // 
            this.lblOutputNextIncomeValue.AutoSize = true;
            this.lblOutputNextIncomeValue.Font = new System.Drawing.Font("Gulim", 14F);
            this.lblOutputNextIncomeValue.Location = new System.Drawing.Point(451, 34);
            this.lblOutputNextIncomeValue.Name = "lblOutputNextIncomeValue";
            this.lblOutputNextIncomeValue.Size = new System.Drawing.Size(19, 19);
            this.lblOutputNextIncomeValue.TabIndex = 12;
            this.lblOutputNextIncomeValue.Text = "0";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnOpenLibary);
            this.menuPanel.Controls.Add(this.btnUpgrade);
            this.menuPanel.Controls.Add(this.btnDrawMob);
            this.menuPanel.Controls.Add(this.lblNextIncomeValue);
            this.menuPanel.Controls.Add(this.lblNextIncomeCost);
            this.menuPanel.Controls.Add(this.lblOutputIncome);
            this.menuPanel.Controls.Add(this.lblOutputNextIncomeValue);
            this.menuPanel.Controls.Add(this.lblCoin);
            this.menuPanel.Controls.Add(this.lblIncome);
            this.menuPanel.Controls.Add(this.lblOutputNextIncomeCost);
            this.menuPanel.Controls.Add(this.lblOutputCoin);
            this.menuPanel.Location = new System.Drawing.Point(12, 67);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(760, 70);
            this.menuPanel.TabIndex = 12;
            // 
            // PocketWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "PocketWorld";
            this.Text = "PocketWorld";
            this.Load += new System.EventHandler(this.PocketWorld_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawMob;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnOpenLibary;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutputCoin;
        private System.Windows.Forms.Label lblOutputIncome;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblIncomeResult;
        private System.Windows.Forms.Label lblNextIncomeCost;
        private System.Windows.Forms.Label lblNextIncomeValue;
        private System.Windows.Forms.Label lblOutputNextIncomeCost;
        private System.Windows.Forms.Label lblOutputNextIncomeValue;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label lblOutputUserMobIdLIst;
    }
}

