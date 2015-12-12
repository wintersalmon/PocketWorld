namespace PocketWorld
{
    partial class ChoiceMachineViewBox
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChoiceCost = new System.Windows.Forms.Label();
            this.lblMachineId = new System.Windows.Forms.Label();
            this.lblInformCost = new System.Windows.Forms.Label();
            this.lblInformId = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblInformNormal = new System.Windows.Forms.Label();
            this.lblNormalRank = new System.Windows.Forms.Label();
            this.lblInformRare = new System.Windows.Forms.Label();
            this.lblRareRank = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoiceCost
            // 
            this.lblChoiceCost.AutoSize = true;
            this.lblChoiceCost.Location = new System.Drawing.Point(159, 51);
            this.lblChoiceCost.Name = "lblChoiceCost";
            this.lblChoiceCost.Size = new System.Drawing.Size(11, 12);
            this.lblChoiceCost.TabIndex = 1;
            this.lblChoiceCost.Text = "0";
            // 
            // lblMachineId
            // 
            this.lblMachineId.AutoSize = true;
            this.lblMachineId.Location = new System.Drawing.Point(159, 15);
            this.lblMachineId.Name = "lblMachineId";
            this.lblMachineId.Size = new System.Drawing.Size(11, 12);
            this.lblMachineId.TabIndex = 2;
            this.lblMachineId.Text = "0";
            // 
            // lblInformCost
            // 
            this.lblInformCost.AutoSize = true;
            this.lblInformCost.Location = new System.Drawing.Point(159, 39);
            this.lblInformCost.Name = "lblInformCost";
            this.lblInformCost.Size = new System.Drawing.Size(71, 12);
            this.lblInformCost.TabIndex = 3;
            this.lblInformCost.Text = "ChoiceCost";
            // 
            // lblInformId
            // 
            this.lblInformId.AutoSize = true;
            this.lblInformId.Location = new System.Drawing.Point(159, 3);
            this.lblInformId.Name = "lblInformId";
            this.lblInformId.Size = new System.Drawing.Size(64, 12);
            this.lblInformId.TabIndex = 4;
            this.lblInformId.Text = "MachineId";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(161, 157);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(86, 23);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "뽑기";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // lblInformNormal
            // 
            this.lblInformNormal.AutoSize = true;
            this.lblInformNormal.Location = new System.Drawing.Point(159, 75);
            this.lblInformNormal.Name = "lblInformNormal";
            this.lblInformNormal.Size = new System.Drawing.Size(74, 12);
            this.lblInformNormal.TabIndex = 7;
            this.lblInformNormal.Text = "NormalRank";
            // 
            // lblNormalRank
            // 
            this.lblNormalRank.AutoSize = true;
            this.lblNormalRank.Location = new System.Drawing.Point(159, 87);
            this.lblNormalRank.Name = "lblNormalRank";
            this.lblNormalRank.Size = new System.Drawing.Size(11, 12);
            this.lblNormalRank.TabIndex = 6;
            this.lblNormalRank.Text = "0";
            // 
            // lblInformRare
            // 
            this.lblInformRare.AutoSize = true;
            this.lblInformRare.Location = new System.Drawing.Point(159, 113);
            this.lblInformRare.Name = "lblInformRare";
            this.lblInformRare.Size = new System.Drawing.Size(59, 12);
            this.lblInformRare.TabIndex = 9;
            this.lblInformRare.Text = "RareRank";
            // 
            // lblRareRank
            // 
            this.lblRareRank.AutoSize = true;
            this.lblRareRank.Location = new System.Drawing.Point(159, 125);
            this.lblRareRank.Name = "lblRareRank";
            this.lblRareRank.Size = new System.Drawing.Size(11, 12);
            this.lblRareRank.TabIndex = 8;
            this.lblRareRank.Text = "0";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.ErrorImage = global::PocketWorld.Properties.Resources.choiceMachine1;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(150, 177);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // ChoiceMachineViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInformRare);
            this.Controls.Add(this.lblRareRank);
            this.Controls.Add(this.lblInformNormal);
            this.Controls.Add(this.lblNormalRank);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblInformId);
            this.Controls.Add(this.lblInformCost);
            this.Controls.Add(this.lblMachineId);
            this.Controls.Add(this.lblChoiceCost);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "ChoiceMachineViewBox";
            this.Size = new System.Drawing.Size(250, 180);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblRareRank;
        protected System.Windows.Forms.Label lblInformRare;
        protected System.Windows.Forms.Label lblNormalRank;
        protected System.Windows.Forms.Label lblInformNormal;
        protected System.Windows.Forms.Label lblInformId;
        protected System.Windows.Forms.Label lblInformCost;
        protected System.Windows.Forms.Label lblMachineId;
        protected System.Windows.Forms.Label lblChoiceCost;
        protected System.Windows.Forms.PictureBox mainPictureBox;
        public System.Windows.Forms.Button btnHit;
    }
}
