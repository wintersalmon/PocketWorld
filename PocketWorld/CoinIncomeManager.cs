using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    class CoinIncomeManager
    {
        private Player itsPlayer;
        private int itsUpgradeCostMultiplier;
        private int itsUpgradeIncomeAdder;

        public CoinIncomeManager()
        {
            itsUpgradeCostMultiplier = 100;
            itsUpgradeIncomeAdder = 1;
            itsPlayer = null;
        }

        public CoinIncomeManager(Player _player)
        {
            itsUpgradeCostMultiplier = 100;
            itsUpgradeIncomeAdder = 1;
            itsPlayer = _player;
        }

        internal Player ItsPlayer
        {
            get { return itsPlayer; }
            set { itsPlayer = value; }
        }

        protected bool hasPlayer() {return itsPlayer != null ? true : false;}

        public void GainIncome()
        {
            if (hasPlayer())
            {
                itsPlayer.GainIncome();
            }
        }

        public void UpgradeIncome(int upValue)
        {
            if (hasPlayer())
            {
                int upgradeCost = getNextUpgradeCost();
                int upgradeIncome = getNextUpgradeIncome();
                if (itsPlayer.Coin >= upgradeCost)
                {
                    itsPlayer.IncomeLevel += 1;
                    itsPlayer.Coin -= upgradeCost;
                    itsPlayer.Income = upgradeIncome;
                }
            }
        }

        public int getCurIncome()
        {
            if (hasPlayer())
            {
                return itsPlayer.Income;
            }
            return 0;
        }

        public int getNextUpgradeCost()
        {
            if (hasPlayer())
            {
                return itsPlayer.IncomeLevel * itsUpgradeCostMultiplier;
            }
            return 0;
        }

        public int getNextUpgradeIncome()
        {
            if (hasPlayer())
            {
                return itsPlayer.IncomeLevel + itsUpgradeIncomeAdder;
            }
            return 0;
        }
    }
}
