using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    class Player
    {
        private String itsId;
        private String itsPw;
        private int itsCurCoin;
        private int itsIncome;

        public String ItsId
        {
            get { return itsId; }
            set { itsId = value; }
        }

        public String ItsPw
        {
            get { return itsPw; }
            set { itsPw = value; }
        }

        public int CurCoin
        {
            get { return itsCurCoin; }
            set { itsCurCoin = value; }
        }

        public int CurIncome
        {
            get { return itsIncome; }
            set { itsIncome = value; }
        }

        public void GainIncome() { itsCurCoin += itsIncome; }
        public void IncreaseCoin(int inc) {itsCurCoin += inc;}
        public void DecreaseCoin(int dec) {itsCurCoin -= dec;}

        public void IncreaseIncome(int inc) { itsIncome += inc; }
        public void DecreaseIncome(int dec) { itsIncome -= dec; }
    }

}
