using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    public class ChoiceMachine
    {
        private int machineId;
        private int rankNormal;
        private int rankRare;
        private int chanceRare;
        private int startCost;
        private double costIncMultiplier;
        private int[] normalMonIdArray;
        private int[] rareMonIdArray;
        private Random randUnit;

        ChoiceMachine()
        {
            normalMonIdArray = null;
            rareMonIdArray = null;
            randUnit = new Random();
        }

        public int SpinForRandomMonId()
        {
            int selectedMonId = -1;

 
            if (normalMonIdArray != null && randUnit.Next(0, ChanceRare) > 0)
            {
                int index = randUnit.Next(0, normalMonIdArray.Length);
                selectedMonId = normalMonIdArray[index];
            }
            else if(rareMonIdArray != null)
            {
                int index = randUnit.Next(0, rareMonIdArray.Length);
                selectedMonId = rareMonIdArray[index];
            }

            return selectedMonId;
        }
        public int CalculateSpinCost(int monCnt)
        {
            double cost = startCost;
            for (int i = 0; i < monCnt; i++)
            {
                cost *= costIncMultiplier;
            }

            int resultCost = (int) cost;


            return resultCost;
        }

        public int MachineId
        {
            get
            {
                return machineId;
            }

            set
            {
                machineId = value;
            }
        }

        public int RankNormal
        {
            get
            {
                return rankNormal;
            }

            set
            {
                rankNormal = value;
            }
        }

        public int RankRare
        {
            get
            {
                return rankRare;
            }

            set
            {
                rankRare = value;
            }
        }

        public int ChanceRare
        {
            get
            {
                return chanceRare;
            }

            set
            {
                chanceRare = value;
            }
        }

        public int StartCost
        {
            get
            {
                return startCost;
            }

            set
            {
                startCost = value;
            }
        }

        public double CostIncMultiplier
        {
            get
            {
                return costIncMultiplier;
            }

            set
            {
                costIncMultiplier = value;
            }
        }

        public int[] NormalMonIdArray
        {
            get
            {
                return normalMonIdArray;
            }

            set
            {
                normalMonIdArray = value;
            }
        }

        public int[] RareMonIdArray
        {
            get
            {
                return rareMonIdArray;
            }

            set
            {
                rareMonIdArray = value;
            }
        }
        
    }
}
