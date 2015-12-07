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
        private List<ChoiceMachine> itsMachineList;
        private Player itsPlayer;

        public ChoiceMachineForm(Player player, List<ChoiceMachine> machineList)
        {
            InitializeComponent();
            itsPlayer = player;
            itsMachineList = machineList;
        }
    }
}
