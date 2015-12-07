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
    public partial class ChoiceMachineForm : Form
    {
        private Player itsPlayer;
        private ChoiceMachine [] itsMachineArr;

        public ChoiceMachineForm(int size)
        {
            InitializeComponent();
            this.ItsPlayer = ItsPlayer;
            itsMachineArr = new ChoiceMachine[size];
        }

        public Player ItsPlayer
        {
            get
            {
                return itsPlayer;
            }

            set
            {
                itsPlayer = value;
            }
        }

        public void SetChoiceMachine(int idx, ChoiceMachine machine)
        {
            if (idx < 0 || idx >= itsMachineArr.Length) return;
            itsMachineArr[idx] = machine;
        }

        private void ChoiceMachineForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMachineLv01_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[0].getRandomMobId().ToString();
        }

        private void btnMachineLv02_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[1].getRandomMobId().ToString();
        }

        private void btnMachineLv03_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[2].getRandomMobId().ToString();
        }

        private void btnMachineLv04_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[3].getRandomMobId().ToString();
        }

        private void btnMachineLv05_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[4].getRandomMobId().ToString();
        }

        private void btnMachineLv06_Click(object sender, EventArgs e)
        {
            lblOutResult.Text = itsMachineArr[5].getRandomMobId().ToString();
        }
    }
}
