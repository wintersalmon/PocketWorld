using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PocketWorld
{
    class ChoiceMachine
    {
        private int itsRareLevel;
        private int itsCost;
        private int itsRareProbability;
        private int itsCostIncreasePercent;
        private List<int> itsMobIdList;

        ChoiceMachine(int rareLevel, int cost, int probability, int costIncrase)
        {
            itsRareLevel = rareLevel;
            itsCost = cost;
            itsRareProbability = probability;
            itsCostIncreasePercent = costIncrase;
            itsMobIdList = new List<int>();
        }

        void AddMobIdList(List<int> inputList)
        {
            itsMobIdList.AddRange(inputList);
        }

        void AddMobId(int id)
        {
            itsMobIdList.Add(id);
        }

        private int getRandomMobId()
        {
            int mobId = 0;

            // caculate random mob id

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
