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
        private ChoiceMachine itsMachine;
        private Player itsPlayer;
        private List<ChoiceMachine> itsChoiceMachineList;

        public ChoiceMachineForm(Player itsPlayer, List<ChoiceMachine> itsChoiceMachineList)
        {
            // TODO: Complete member initialization
            this.itsPlayer = itsPlayer;
            this.itsChoiceMachineList = itsChoiceMachineList;
        }
    }
}
