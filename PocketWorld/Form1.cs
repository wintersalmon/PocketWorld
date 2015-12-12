using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private Mob myTestMob;
        public PocketWorld()
        {
            InitializeComponent();
            itsPlayer = null;
           
            itsChoiceMachineList = new List<ChoiceMachine>();

            for (int i=0, cost = 100; i<6; i++, cost *= cost)
            {
                //itsChoiceMachineList.Add(new ChoiceMachine(i + 1, cost, 5, 30));
            }
            
            itsCoinManager = new CoinIncomeManager(itsPlayer);

            choiceMachineFrm = new ChoiceMachineForm(6);
            choiceMachineFrm.ItsPlayer = itsPlayer;

            for(int i=0; i< itsChoiceMachineList.Count; i++)
            {
                choiceMachineFrm.SetChoiceMachine(i, itsChoiceMachineList[i]);
            }

            for (int mIdx = 0; mIdx < itsChoiceMachineList.Count; mIdx++)
            {
                for (int count = 1 ; count < 10; count++)
                {
                    //itsChoiceMachineList[mIdx].AddMobId(count);
                }
            }

            UpdateScreen();
        }

        private void PocketWorld_Load(object sender, EventArgs e)
        {
            PlayerDBConnectManager db = new PlayerDBConnectManager();

            if (db.initConnectionWithPlayer("salmonjoon", "1234") == true)
            {
                MessageBox.Show(db.GetPlayer().Id + "," + db.GetPlayer().Pw + "," + db.GetPlayer().Coin + "," + db.GetPlayer().IncomeLevel);

                String idListStr = "";
                foreach (ChoiceMachine machine in db.GetChoiceMachineList()) {
                    foreach (int id in machine.NormalMonIdArray)
                    {
                        idListStr += id + ", ";
                    }
                    MessageBox.Show(idListStr);
                }
            }
        }

        private void btnIncCoin_Click(object sender, EventArgs e)
        {
            itsCoinManager.GainIncome();
            UpdateScreen();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            //itsCoinManager.UpgradeIncome(itsPlayer.Income * 2);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            /*
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
            */
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            lblIncomeResult.Text = "";
            myTestMob = new Mob(1, "my", 0, 0, 0, "Hello");

            mainPanel.Controls.Add(myTestMob);
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
