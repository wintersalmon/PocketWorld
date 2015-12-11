using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    public class Mob : System.Windows.Forms.PictureBox
    {
        private int itsId;
        private String itsName;
        private int itsRare;
        private int itsColor;
        private int itsGainMoney;
        private String itsGainMoneyExplain;
        private String itsImageIdStr;

        public Mob(int _itsId, String _itsName, int _itsRare, int _itsColor, int _itsGainmoney, String _itsGainMoneyExplain)
        {
            this.itsId = _itsId;
            this.itsName = _itsName;
            this.itsRare = _itsRare;
            this.itsColor = _itsColor;
            this.itsGainMoney = _itsGainmoney;
            this.itsGainMoneyExplain = _itsGainMoneyExplain;

            itsImageIdStr = "_" + itsId;
            SetImage((Image)Properties.Resources.ResourceManager.GetObject(itsImageIdStr));
        }

        private void SetImage(System.Drawing.Image img)
        {
            this.Image = img;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }


        public int ItsId
        {
            get { return itsId; }
            set { itsId = value; }
        }
        public String ItsName
        {
            get { return itsName; }
            set { itsName = value; }
        }
        public int ItsRare
        {
            get { return itsRare; }
            set { itsRare = value; }
        }
        public int ItsColor
        {
            get { return itsColor; }
            set { itsColor = value; }
        }
        public int ItsGainMoney
        {
            get { return itsGainMoney; }
            set { itsGainMoney = value; }
        }
        public String ItsGainMoneyExplain
        {
            get { return itsGainMoneyExplain; }
            set { itsGainMoneyExplain = value; }
        }

    }
}