using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PocketWorld
{
    public class Player
    {
        private String itsId;
        private String itsPw;
        private int itsCoin;
        private int itsIncome;
        private int itsIncomeLevel;
        private int itsMobCnt;
        private List<int> itsMobIdList;

        public Player()
        {
            itsMobIdList = new List<int>();
        }

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

        public int Coin
        {
            get { return itsCoin; }
            set { itsCoin = value; }
        }

        public int Income
        {
            get { return itsIncome; }
            set { itsIncome = value; }
        }

        public int IncomeLevel
        {
            get { return itsIncomeLevel; }
            set { itsIncomeLevel = value; }
        }

        public int MobCnt
        {
            get { return itsMobCnt; }
            set { itsMobCnt = value; }
        }

        public void AddMobId(int id) { itsMobIdList.Add(id); }
        public List<int> getMobIdList() { return itsMobIdList; }
        
        public void GainIncome() { itsCoin += itsIncome; }
        public void IncreaseCoin(int inc) {itsCoin += inc;}
        public void DecreaseCoin(int dec) {itsCoin -= dec;}

        public void IncreaseIncome(int inc) { itsIncome += inc; }
        public void DecreaseIncome(int dec) { itsIncome -= dec; }
    }

}
