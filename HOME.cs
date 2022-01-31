using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareProject
{
    public partial class HOME : Form
    {
        
        public HOME()
        {
            InitializeComponent();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            if (LOGIN.account == 0)
            {
                btManagement.Enabled = false;
                btSwitchAccount.Text = "[STAFF] " + LOGIN.userName;
            }
            else
            if(LOGIN.account == 1)
            {
                btManagement.Enabled = true; //Là quản lý thì sẽ được dùng Management
                btSwitchAccount.Text = "[ADMIN] " + LOGIN.userName;
            }
        }

        private void btSwitchAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN form = new LOGIN();
            form.ShowDialog();
        }

        private void btShop_MouseHover(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.White;
            bt.BackColor = Color.Black;

        }

        private void btShop_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.Black;
            bt.BackColor = Color.LavenderBlush;
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            PAYMENT form = new PAYMENT();
            form.ShowDialog();
            this.Show();
        }

        private void btNewPets_Click(object sender, EventArgs e)
        {
            this.Hide();
            PETINFORMATION form = new PETINFORMATION();
            form.ShowDialog();
            this.Show();
        }

        private void btStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            STOCK form = new STOCK();
            form.ShowDialog();
            this.Show();
        }

        private void btManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            MANAGEMENT form = new MANAGEMENT();
            form.ShowDialog();
            this.Show();
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            BILLHISTORY form = new BILLHISTORY();
            form.ShowDialog();
            this.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
    }
}
