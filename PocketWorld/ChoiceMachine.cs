using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    public class ChoiceMachine : ChoiceMachineViewBox
    {
        private int machineId;
        private int rankNormal;
        private int rankRare;
        private int chanceRare;
        private int startCost;
        private int costIncMultiplier;
        private List<int> normalMonIdArray;
        private List<int> rareMonIdArray;
        private Random randUnit;

        public ChoiceMachine()
        {
            NormalMonIdArray = new List<int>();
            RareMonIdArray = new List<int>();
            randUnit = new Random();
        }

        public void initContent()
        {
            this.lblMachineId.Text = machineId.ToString();
            this.lblChoiceCost.Text = startCost.ToString();
            this.lblNormalRank.Text = rankNormal.ToString();
            this.lblRareRank.Text = rankRare.ToString();

            this.mainPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(GetImageURLStr());
        }

        public void ReloadCostLabel(String costStr)
        {
            this.lblChoiceCost.Text = costStr;
        }

        public string GetImageURLStr()
        {
            return "choiceMachine" + this.machineId;
        }

        public int SpinForRandomMonId()
        {
            int selectedMonId = -1;

 
            if (NormalMonIdArray != null && randUnit.Next(0, ChanceRare) > 0)
            {
                int index = randUnit.Next(0, NormalMonIdArray.Count);
                selectedMonId = NormalMonIdArray[index];
            }
            else if(RareMonIdArray != null)
            {
                int index = randUnit.Next(0, RareMonIdArray.Count);
                selectedMonId = RareMonIdArray[index];
            }

            return selectedMonId;
        }
        public int CalculateSpinCost(int monCnt)
        {
            int price = -1;

            price = StartCost + (monCnt * CostIncMultiplier);

            return price;
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

        public int CostIncMultiplier
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

        public List<int> NormalMonIdArray
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

        public List<int> RareMonIdArray
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
