using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    public class ChoiceMachine
    {
        private int itsRareLevel;
        private int itsCost;
        private int itsRareProbability;
        private int itsCostIncreasePercent;
        private List<int> itsMobIdList;
        private Random itsRandomGenerator;

        public ChoiceMachine(int rareLevel, int cost, int probability, int costIncrase)
        {
            itsRareLevel = rareLevel;
            itsCost = cost;
            itsRareProbability = probability;
            itsCostIncreasePercent = costIncrase;
            itsMobIdList = new List<int>();
            itsRandomGenerator = new Random();
        }

        public int RareLevel
        {
            get
            {
                return itsRareLevel;
            }

            set
            {
                itsRareLevel = value;
            }
        }

        public void AddMobIdList(List<int> inputList)
        {
            itsMobIdList.AddRange(inputList);
        }

        public void AddMobId(int id)
        {
            itsMobIdList.Add(id);
        }

        public int getRandomMobId()
        {
            int mobId = 0;
            int size = itsMobIdList.Count;
            if(size > 0)
            {
                int selectIdx = itsRandomGenerator.Next(0, size);
                mobId = itsMobIdList[selectIdx];
            }

            return mobId;
        }

        public bool BuyRandomMob(Player buyer)
        {
            if(buyer == null) return false;

            int mobCnt  = buyer.MobCnt;
            int mobCost = itsCost + mobCnt * itsCostIncreasePercent;
            int mobId = getRandomMobId();

            if (buyer.Coin >= mobCost)
            {
                buyer.Coin -= mobCost;
                buyer.AddMobId(mobId);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
