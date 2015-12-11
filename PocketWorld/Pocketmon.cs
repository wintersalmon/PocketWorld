namespace PocketWorld
{
    class Pocketmon
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

        public string GetImageURLStr()
        {
            if(this.MonId > 0)
            {
                return "_" + this.monId;
            }
            else
            {
                return "_error";
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