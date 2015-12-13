using System.Drawing;

namespace PocketWorld
{
    class Pocketmon : PocketmonViewBox
    {
        private int pocketmonId;
        private int monId;
        private string playerId;
        private int pocketmonStatus;
        private string monName;
        private int rank;
        private int gainCoin;
        private string gainCoinExplanation;
        private string monExplanation;

        public void ReLoadContents()
        {
            this.lblName.Text = MonName;
            this.lblRank.Text = Rank.ToString();
            this.lblGainCoin.Text = GainCoin.ToString();
            this.lblGainCoinExplanation.Text = GainCoinExplanation;
            this.lblMonExplanation.Text = MonExplanation;
            
            if(this.pocketmonStatus == 0)
            {
                this.btnLoad.Visible = true;
                this.btnSave.Visible = false;
                this.pictureOutputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                this.btnLoad.Visible = false;
                this.btnSave.Visible = true;
                this.pictureOutputBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            }
            
            this.pictureOutputBox.Image = (Image) Properties.Resources.ResourceManager.GetObject(GetImageURLStr());
            this.pictureOutputBox.Invalidate();
        }

        public string GetImageURLStr()
        {
            if(this.pocketmonStatus == 0)
            {
                return "lib" + this.monId;
            }
            else
            {
                return "mon" + this.monId;
            }
        }

        public int PocketmonId
        {
            get
            {
                return pocketmonId;
            }

            set
            {
                pocketmonId = value;
            }
        }

        public int MonId
        {
            get
            {
                return monId;
            }

            set
            {
                monId = value;
            }
        }

        public string PlayerId
        {
            get
            {
                return playerId;
            }

            set
            {
                playerId = value;
            }
        }

        public int PocketmonStatus
        {
            get
            {
                return pocketmonStatus;
            }

            set
            {
                pocketmonStatus = value;
            }
        }

        public string MonName
        {
            get
            {
                return monName;
            }

            set
            {
                monName = value;
            }
        }

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }

        public int GainCoin
        {
            get
            {
                return gainCoin;
            }

            set
            {
                gainCoin = value;
            }
        }

        public string GainCoinExplanation
        {
            get
            {
                return gainCoinExplanation;
            }

            set
            {
                gainCoinExplanation = value;
            }
        }

        public string MonExplanation
        {
            get
            {
                return monExplanation;
            }

            set
            {
                monExplanation = value;
            }
        }
    }
}