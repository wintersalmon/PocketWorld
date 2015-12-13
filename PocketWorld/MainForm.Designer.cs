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
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutputCoin = new System.Windows.Forms.Label();
            this.lblOutputIncome = new System.Windows.Forms.Label();
            this.lblNextIncomeCost = new System.Windows.Forms.Label();
            this.lblNextIncomeValue = new System.Windows.Forms.Label();
            this.lblOutputNextIncomeCost = new System.Windows.Forms.Label();
            this.lblOutputNextIncomeValue = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnIncreaseCoin = new System.Windows.Forms.Button();
            this.choiceMachinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pocketmonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTabPanel = new System.Windows.Forms.TabControl();
            this.PocketmonListPage = new System.Windows.Forms.TabPage();
            this.libraryPage = new System.Windows.Forms.TabPage();
            this.libraryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChoiceMachinePage = new System.Windows.Forms.TabPage();
            this.menuPanel.SuspendLayout();
            this.mainTabPanel.SuspendLayout();
            this.PocketmonListPage.SuspendLayout();
            this.libraryPage.SuspendLayout();
            this.ChoiceMachinePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.AutoSize = true;
            this.btnUpgrade.BackgroundImage = global::PocketWorld.Properties.Resources.btnImageUpgrade;
            this.btnUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpgrade.Location = new System.Drawing.Point(320, 28);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 46);
            this.btnUpgrade.TabIndex = 2;
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Font = new System.Drawing.Font("굴림", 14F);
            this.lblCoin.Location = new System.Drawing.Point(3, 10);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(85, 19);
            this.lblCoin.TabIndex = 5;
            this.lblCoin.Text = "보유코인";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("굴림", 14F);
            this.lblIncome.Location = new System.Drawing.Point(3, 36);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(85, 19);
            this.lblIncome.TabIndex = 6;
            this.lblIncome.Text = "클릭수입";
            this.lblIncome.Click += new System.EventHandler(this.lblIncome_Click);
            // 
            // lblOutputCoin
            // 
            this.lblOutputCoin.AutoSize = true;
            this.lblOutputCoin.Font = new System.Drawing.Font("굴림", 14F);
            this.lblOutputCoin.Location = new System.Drawing.Point(94, 10);
            this.lblOutputCoin.Name = "lblOutputCoin";
            this.lblOutputCoin.Size = new System.Drawing.Size(19, 19);
            this.lblOutputCoin.TabIndex = 7;
            this.lblOutputCoin.Text = "0";
            // 
            // lblOutputIncome
            // 
            this.lblOutputIncome.AutoSize = true;
            this.lblOutputIncome.Font = new System.Drawing.Font("굴림", 14F);
            this.lblOutputIncome.Location = new System.Drawing.Point(94, 39);
            this.lblOutputIncome.Name = "lblOutputIncome";
            this.lblOutputIncome.Size = new System.Drawing.Size(19, 19);
            this.lblOutputIncome.TabIndex = 8;
            this.lblOutputIncome.Text = "0";
            this.lblOutputIncome.Click += new System.EventHandler(this.lblOutputIncome_Click);
            // 
            // lblNextIncomeCost
            // 
            this.lblNextIncomeCost.AutoSize = true;
            this.lblNextIncomeCost.Font = new System.Drawing.Font("굴림", 14F);
            this.lblNextIncomeCost.Location = new System.Drawing.Point(3, 78);
            this.lblNextIncomeCost.Name = "lblNextIncomeCost";
            this.lblNextIncomeCost.Size = new System.Drawing.Size(148, 19);
            this.lblNextIncomeCost.TabIndex = 9;
            this.lblNextIncomeCost.Text = "업그레이드 가격";
            // 
            // lblNextIncomeValue
            // 
            this.lblNextIncomeValue.AutoSize = true;
            this.lblNextIncomeValue.Font = new System.Drawing.Font("굴림", 14F);
            this.lblNextIncomeValue.Location = new System.Drawing.Point(3, 55);
            this.lblNextIncomeValue.Name = "lblNextIncomeValue";
            this.lblNextIncomeValue.Size = new System.Drawing.Size(167, 19);
            this.lblNextIncomeValue.TabIndex = 10;
            this.lblNextIncomeValue.Text = "업그레이드 증가량";
            // 
            // lblOutputNextIncomeCost
            // 
            this.lblOutputNextIncomeCost.AutoSize = true;
            this.lblOutputNextIncomeCost.Font = new System.Drawing.Font("굴림", 14F);
            this.lblOutputNextIncomeCost.Location = new System.Drawing.Point(176, 78);
            this.lblOutputNextIncomeCost.Name = "lblOutputNextIncomeCost";
            this.lblOutputNextIncomeCost.Size = new System.Drawing.Size(19, 19);
            this.lblOutputNextIncomeCost.TabIndex = 11;
            this.lblOutputNextIncomeCost.Text = "0";
            // 
            // lblOutputNextIncomeValue
            // 
            this.lblOutputNextIncomeValue.AutoSize = true;
            this.lblOutputNextIncomeValue.Font = new System.Drawing.Font("굴림", 14F);
            this.lblOutputNextIncomeValue.Location = new System.Drawing.Point(176, 55);
            this.lblOutputNextIncomeValue.Name = "lblOutputNextIncomeValue";
            this.lblOutputNextIncomeValue.Size = new System.Drawing.Size(19, 19);
            this.lblOutputNextIncomeValue.TabIndex = 12;
            this.lblOutputNextIncomeValue.Text = "0";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.btnRefresh);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Controls.Add(this.btnIncreaseCoin);
            this.menuPanel.Controls.Add(this.btnUpgrade);
            this.menuPanel.Controls.Add(this.lblNextIncomeValue);
            this.menuPanel.Controls.Add(this.lblNextIncomeCost);
            this.menuPanel.Controls.Add(this.lblOutputIncome);
            this.menuPanel.Controls.Add(this.lblOutputNextIncomeValue);
            this.menuPanel.Controls.Add(this.lblCoin);
            this.menuPanel.Controls.Add(this.lblIncome);
            this.menuPanel.Controls.Add(this.lblOutputNextIncomeCost);
            this.menuPanel.Controls.Add(this.lblOutputCoin);
            this.menuPanel.Location = new System.Drawing.Point(482, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(565, 116);
            this.menuPanel.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::PocketWorld.Properties.Resources.btnImageRefresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(486, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 46);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::PocketWorld.Properties.Resources.btnImageChangeUser;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(401, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 46);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnIncreaseCoin
            // 
            this.btnIncreaseCoin.BackgroundImage = global::PocketWorld.Properties.Resources.btnImageCoin;
            this.btnIncreaseCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseCoin.Location = new System.Drawing.Point(235, 28);
            this.btnIncreaseCoin.Name = "btnIncreaseCoin";
            this.btnIncreaseCoin.Size = new System.Drawing.Size(79, 46);
            this.btnIncreaseCoin.TabIndex = 15;
            this.btnIncreaseCoin.UseVisualStyleBackColor = true;
            this.btnIncreaseCoin.Click += new System.EventHandler(this.btnIncreaseCoin_Click);
            this.btnIncreaseCoin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIncreaseCoin_MouseClick);
            // 
            // choiceMachinePanel
            // 
            this.choiceMachinePanel.AutoScroll = true;
            this.choiceMachinePanel.BackgroundImage = global::PocketWorld.Properties.Resources.PT3;
            this.choiceMachinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choiceMachinePanel.Location = new System.Drawing.Point(3, 3);
            this.choiceMachinePanel.Name = "choiceMachinePanel";
            this.choiceMachinePanel.Size = new System.Drawing.Size(1017, 495);
            this.choiceMachinePanel.TabIndex = 13;
            this.choiceMachinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.choiceMachinePanel_Paint);
            // 
            // pocketmonPanel
            // 
            this.pocketmonPanel.AutoScroll = true;
            this.pocketmonPanel.BackColor = System.Drawing.Color.Transparent;
            this.pocketmonPanel.BackgroundImage = global::PocketWorld.Properties.Resources.PT4;
            this.pocketmonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pocketmonPanel.Location = new System.Drawing.Point(3, 3);
            this.pocketmonPanel.Name = "pocketmonPanel";
            this.pocketmonPanel.Size = new System.Drawing.Size(1017, 495);
            this.pocketmonPanel.TabIndex = 14;
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Controls.Add(this.PocketmonListPage);
            this.mainTabPanel.Controls.Add(this.libraryPage);
            this.mainTabPanel.Controls.Add(this.ChoiceMachinePage);
            this.mainTabPanel.Location = new System.Drawing.Point(16, 112);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.SelectedIndex = 0;
            this.mainTabPanel.Size = new System.Drawing.Size(1031, 527);
            this.mainTabPanel.TabIndex = 15;
            // 
            // PocketmonListPage
            // 
            this.PocketmonListPage.Controls.Add(this.pocketmonPanel);
            this.PocketmonListPage.Location = new System.Drawing.Point(4, 22);
            this.PocketmonListPage.Name = "PocketmonListPage";
            this.PocketmonListPage.Padding = new System.Windows.Forms.Padding(3);
            this.PocketmonListPage.Size = new System.Drawing.Size(1023, 501);
            this.PocketmonListPage.TabIndex = 0;
            this.PocketmonListPage.Text = "포켓몬";
            this.PocketmonListPage.UseVisualStyleBackColor = true;
            // 
            // libraryPage
            // 
            this.libraryPage.Controls.Add(this.libraryPanel);
            this.libraryPage.Location = new System.Drawing.Point(4, 22);
            this.libraryPage.Name = "libraryPage";
            this.libraryPage.Padding = new System.Windows.Forms.Padding(3);
            this.libraryPage.Size = new System.Drawing.Size(1023, 501);
            this.libraryPage.TabIndex = 1;
            this.libraryPage.Text = "도감";
            this.libraryPage.UseVisualStyleBackColor = true;
            // 
            // libraryPanel
            // 
            this.libraryPanel.AutoScroll = true;
            this.libraryPanel.BackgroundImage = global::PocketWorld.Properties.Resources.PT2;
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(3, 3);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1017, 495);
            this.libraryPanel.TabIndex = 0;
            // 
            // ChoiceMachinePage
            // 
            this.ChoiceMachinePage.Controls.Add(this.choiceMachinePanel);
            this.ChoiceMachinePage.Location = new System.Drawing.Point(4, 22);
            this.ChoiceMachinePage.Name = "ChoiceMachinePage";
            this.ChoiceMachinePage.Padding = new System.Windows.Forms.Padding(3);
            this.ChoiceMachinePage.Size = new System.Drawing.Size(1023, 501);
            this.ChoiceMachinePage.TabIndex = 2;
            this.ChoiceMachinePage.Text = "뽑기 머신";
            this.ChoiceMachinePage.UseVisualStyleBackColor = true;
            // 
            // PocketWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PocketWorld.Properties.Resources.backgroundSlot;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 650);
            this.Controls.Add(this.mainTabPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "PocketWorld";
            this.Text = "PocketWorld";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PocketWorld_FormClosing);
            this.Load += new System.EventHandler(this.PocketWorld_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.mainTabPanel.ResumeLayout(false);
            this.PocketmonListPage.ResumeLayout(false);
            this.libraryPage.ResumeLayout(false);
            this.ChoiceMachinePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutputCoin;
        private System.Windows.Forms.Label lblOutputIncome;
        private System.Windows.Forms.Label lblNextIncomeCost;
        private System.Windows.Forms.Label lblNextIncomeValue;
        private System.Windows.Forms.Label lblOutputNextIncomeCost;
        private System.Windows.Forms.Label lblOutputNextIncomeValue;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnIncreaseCoin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.FlowLayoutPanel libraryPanel;
        public System.Windows.Forms.FlowLayoutPanel pocketmonPanel;
        public System.Windows.Forms.FlowLayoutPanel choiceMachinePanel;
        public System.Windows.Forms.TabControl mainTabPanel;
        public System.Windows.Forms.TabPage ChoiceMachinePage;
        public System.Windows.Forms.TabPage libraryPage;
        public System.Windows.Forms.TabPage PocketmonListPage;
    }
}

