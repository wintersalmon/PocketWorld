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

            InitScreen();
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
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (playerDbConn.isPlayerLoaded() == false) return;
            lblOutputCoin.Text = playerDbConn.GetPlayer().Coin.ToString();
            lblOutputIncome.Text = playerDbConn.GetPlayer().IncomeLevel.ToString();
            lblOutputNextIncomeCost.Text = playerDbConn.GetCurPlayerIncomeUpgradeCost().ToString();
            lblOutputNextIncomeValue.Text = (playerDbConn.GetPlayer().IncomeLevel + 1).ToString();
        }

        private void InitScreen()
        {
            if (playerDbConn.isPlayerLoaded() == false) return;

            choiceMachinePanel.Controls.Clear();
            foreach (ChoiceMachine machine in playerDbConn.GetChoiceMachineList())
            {
                machine.initContent();
                choiceMachinePanel.Controls.Add(machine);
            }

            UpdateLabels();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            if (playerDbConn.isPlayerLoaded() == false) return;

            UpdateLabels();

            pocketmonPanel.Controls.Clear();
            libraryPanel.Controls.Clear();
            foreach (Pocketmon pocketmon in playerDbConn.GetPocketmonList())
            {
                pocketmon.ReLoadContents();
                if (pocketmon.PocketmonStatus == 0)
                {
                    libraryPanel.Controls.Add(pocketmon);
                }
                else
                {
                    pocketmonPanel.Controls.Add(pocketmon);
                }
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
                UpdateLabels();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (myLoginFrm.ShowDialog(this) == DialogResult.Yes)
            {
                playerDbConn = myLoginFrm.DbConnector;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private void choiceMachinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOutputIncome_Click(object sender, EventArgs e)
        {

        }

        private void lblIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnIncreaseCoin_Click(object sender, EventArgs e)
        {
        }
    }
}
