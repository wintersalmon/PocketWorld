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

        public PocketWorld()
        {
            InitializeComponent();
            itsPlayer = new Player();

            itsPlayer.ItsId = "Salmonjoon";
            itsPlayer.ItsPw = "1234";
            itsPlayer.CurCoin = 0;
            itsPlayer.CurIncome = 1;

            itsCoinManager = new CoinIncomeManager(itsPlayer);
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
            itsCoinManager.UpgradeIncome(itsPlayer.CurIncome * 2);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            lblOutputCoin.Text = itsPlayer.CurCoin.ToString();
            lblOutputIncome.Text = itsPlayer.CurIncome.ToString();
        }
    }
}
