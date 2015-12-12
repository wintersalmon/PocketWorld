namespace PocketWorld
{
    public class Player
    {
        private string id;
        private string pw;
        private int coin;
        private int incomeLevel;

        public void IncreaseCoin()
        {
            IncreaseCoin(incomeLevel);
        }

        public void IncreaseCoin(int _inc_coin)
        {
            this.coin += _inc_coin;
        }

        public void DecreaseCoin(int _dec_coin)
        {
            this.coin -= _dec_coin;
        }

        public void UpgradeIncomeLevel(int _inc_level)
        {
            this.incomeLevel += _inc_level;
        }

        public void DowngradeIncomeLevel(int _dec_level)
        {
            this.incomeLevel -= _dec_level;
        }
        
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Pw
        {
            get
            {
                return pw;
            }

            set
            {
                pw = value;
            }
        }

        public int Coin
        {
            get
            {
                return coin;
            }

            set
            {
                coin = value;
            }
        }

        public int IncomeLevel
        {
            get
            {
                return incomeLevel;
            }

            set
            {
                incomeLevel = value;
            }
        }
    }

}
