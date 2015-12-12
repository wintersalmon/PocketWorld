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
    public partial class LoginForm : Form
    {
        private PlayerDBConnectManager dbConnector;
        public LoginForm()
        {
            InitializeComponent();
            dbConnector = new PlayerDBConnectManager();
        }

        internal PlayerDBConnectManager DbConnector
        {
            get
            {
                return dbConnector;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(DbConnector.isPlayerLoaded())
            {
                DbConnector.SavePlayer();
            }

            String id = textBoxUserId.Text;
            String pw = textBoxUserPw.Text;

            if( DbConnector.initConnectionWithPlayer(id, pw) )
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                lblResult.Text = "로그인 실패!!!";
            }
        }
    }
}
