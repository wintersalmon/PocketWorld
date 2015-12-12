namespace PocketWorld
{
    partial class PocketmonViewBox
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
            this.pictureOutputBox = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblGainCoin = new System.Windows.Forms.Label();
            this.lblGainCoinExplanation = new System.Windows.Forms.Label();
            this.lblMonExplanation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOutputBox
            // 
            this.pictureOutputBox.ErrorImage = null;
            this.pictureOutputBox.InitialImage = null;
            this.pictureOutputBox.Location = new System.Drawing.Point(0, 3);
            this.pictureOutputBox.Name = "pictureOutputBox";
            this.pictureOutputBox.Size = new System.Drawing.Size(150, 177);
            this.pictureOutputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOutputBox.TabIndex = 0;
            this.pictureOutputBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(52, 183);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(29, 12);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "rank";
            // 
            // lblGainCoin
            // 
            this.lblGainCoin.AutoSize = true;
            this.lblGainCoin.Location = new System.Drawing.Point(93, 183);
            this.lblGainCoin.Name = "lblGainCoin";
            this.lblGainCoin.Size = new System.Drawing.Size(57, 12);
            this.lblGainCoin.TabIndex = 3;
            this.lblGainCoin.Text = "GainCoin";
            // 
            // lblGainCoinExplanation
            // 
            this.lblGainCoinExplanation.AutoSize = true;
            this.lblGainCoinExplanation.Location = new System.Drawing.Point(3, 199);
            this.lblGainCoinExplanation.Name = "lblGainCoinExplanation";
            this.lblGainCoinExplanation.Size = new System.Drawing.Size(123, 12);
            this.lblGainCoinExplanation.TabIndex = 4;
            this.lblGainCoinExplanation.Text = "GainCoinExplanation";
            // 
            // lblMonExplanation
            // 
            this.lblMonExplanation.AutoSize = true;
            this.lblMonExplanation.Location = new System.Drawing.Point(3, 215);
            this.lblMonExplanation.Name = "lblMonExplanation";
            this.lblMonExplanation.Size = new System.Drawing.Size(96, 12);
            this.lblMonExplanation.TabIndex = 5;
            this.lblMonExplanation.Text = "MonExplanation";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(83, 230);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // PocketmonViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMonExplanation);
            this.Controls.Add(this.lblGainCoinExplanation);
            this.Controls.Add(this.lblGainCoin);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureOutputBox);
            this.Name = "PocketmonViewBox";
            this.Size = new System.Drawing.Size(150, 259);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblName;
        protected System.Windows.Forms.Label lblRank;
        protected System.Windows.Forms.Label lblGainCoin;
        protected System.Windows.Forms.Label lblGainCoinExplanation;
        protected System.Windows.Forms.Label lblMonExplanation;
        protected System.Windows.Forms.PictureBox pictureOutputBox;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnLoad;
    }
}
