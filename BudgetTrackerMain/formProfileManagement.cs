using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackerMain
{
    public partial class formProfileManagement : Form
    {
        public formProfileManagement()
        {
            InitializeComponent();
        }

        // File Menu Buttons

        private void menuFileAddProfile_Click(object sender, EventArgs e)
        {
            Form formAddProfile = new formAddProfile();
            formAddProfile.ShowDialog();
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
            (
                "Are you sure you want to exit?",
                "Exit Program",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
