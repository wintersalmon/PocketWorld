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
        private PlayerDBConnectManager playerDbConn;
        private LoginForm myLoginFrm;

        public PocketWorld()
        {
            InitializeComponent();

            myLoginFrm = new LoginForm();

            if( myLoginFrm.ShowDialog(this) == DialogResult.Yes)
            {
                playerDbConn = myLoginFrm.DbConnector;
            }

            UpdateScreen();
        }

        private void PocketWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnIncCoin_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            playerDbConn.UpgradeIncomeLevel();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            if (playerDbConn.isPlayerLoaded() == false) return;
            lblOutputCoin.Text = playerDbConn.GetPlayer().Coin.ToString();
            lblOutputIncome.Text = playerDbConn.GetPlayer().IncomeLevel.ToString();
            lblOutputNextIncomeCost.Text = playerDbConn.GetCurPlayerIncomeUpgradeCost().ToString();
            lblOutputNextIncomeValue.Text = (playerDbConn.GetPlayer().IncomeLevel + 1).ToString();

            pocketmonPanel.Controls.Clear();
            libraryPanel.Controls.Clear();
            foreach (Pocketmon pocketmon in playerDbConn.GetPocketmonList())
            {
                pocketmon.ReLoadContents();
                if(pocketmon.PocketmonStatus == 0)
                {
                    libraryPanel.Controls.Add(pocketmon);
                }
                else
                {
                    pocketmonPanel.Controls.Add(pocketmon);
                }
            }

            choiceMachinePanel.Controls.Clear();
            foreach (ChoiceMachine machine in playerDbConn.GetChoiceMachineList())
            {
                machine.ReLoadContents();
                choiceMachinePanel.Controls.Add(machine);
            }
        }

        private void btnDrawMob_Click(object sender, EventArgs e)
        {
            //choiceMachineFrm.ShowDialog(this);
        }

        private void PocketWorld_FormClosing(object sender, FormClosingEventArgs e)
        {
            playerDbConn.SavePlayer();
        }

        private void btnIncreaseCoin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                playerDbConn.GetPlayer().IncreaseCoin();
                UpdateScreen();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (myLoginFrm.ShowDialog(this) == DialogResult.Yes)
            {
                playerDbConn = myLoginFrm.DbConnector;
            }
        }
    }
}
