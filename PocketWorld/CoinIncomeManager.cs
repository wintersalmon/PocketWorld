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

        public CoinIncomeManager()
        {
            itsPlayer = null;
        }

        public CoinIncomeManager(Player _player)
        {
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
            else
            {
                return;
            }
        }

        public void UpgradeIncome(int upValue)
        {
            if (hasPlayer())
            {
                int newUpValue = itsPlayer.CurIncome + upValue;
                itsPlayer.CurIncome = newUpValue;
            }
            else
            {
                return;
            }
        }
    }
}
