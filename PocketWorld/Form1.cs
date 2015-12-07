using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketWorld
{
    public partial class PocketWorld : Form
    {
        private Player itsPlayer;
        private CoinIncomeManager itsCoinManager;
        private List<ChoiceMachine> itsChoiceMachineList;

        private ChoiceMachineForm choiceMachineFrm;


        public PocketWorld()
        {
            InitializeComponent();
            itsPlayer = new Player();

            itsPlayer.ItsId = "Salmonjoon"; 
            itsPlayer.ItsPw = "1234";
            itsPlayer.Coin = 100;
            itsPlayer.Income = 1;
            itsPlayer.IncomeLevel = 1;

            itsPlayer.getMobIdList().Add(10);
            itsPlayer.getMobIdList().Add(11);
            itsPlayer.getMobIdList().Add(12);

            itsCoinManager = new CoinIncomeManager(itsPlayer);
            itsChoiceMachineList = new List<ChoiceMachine>();

            choiceMachineFrm = new ChoiceMachineForm(itsPlayer, itsChoiceMachineList);

            UpdateScreen();
        }

        private void PocketWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnIncCoin_Click(object sender, EventArgs e)
        {
            itsCoinManager.GainIncome();
            UpdateScreen();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            itsCoinManager.UpgradeIncome(itsPlayer.Income * 2);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            lblOutputCoin.Text = itsPlayer.Coin.ToString();
            lblOutputIncome.Text = itsPlayer.Income.ToString();
            lblOutputNextIncomeCost.Text = itsCoinManager.getNextUpgradeCost().ToString();
            lblOutputNextIncomeValue.Text = itsCoinManager.getNextUpgradeIncome().ToString();


            String strUserMobId = "";
            List<int> mobIdList = itsPlayer.getMobIdList();
            
            if (mobIdList == null) return;

            for (int i = 0; i < mobIdList.Count; i++)
            {
                strUserMobId += mobIdList[i].ToString() + ", ";
            }
            lblOutputUserMobIdLIst.Text = strUserMobId;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            lblIncomeResult.Text = "";
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = e.Location;
            pos.X += 10;
            pos.Y -= 10;
            lblIncomeResult.Location = pos;

            lblIncomeResult.Text = "+" + itsCoinManager.getCurIncome().ToString();

            itsCoinManager.GainIncome();
            UpdateScreen();
        }

        private void btnDrawMob_Click(object sender, EventArgs e)
        {
            choiceMachineFrm.ShowDialog(this);
        }
    }
}
