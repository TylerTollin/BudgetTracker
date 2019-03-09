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
    public partial class formBudgetTracker : Form
    {
        public formBudgetTracker()
        {
            InitializeComponent();
        }

        // File Menu Buttons
        private void menuFileDashboard_Click(object sender, EventArgs e)
        {
            this.groupboxIncome.Visible = false;
            this.groupboxExpenses.Visible = false;
            this.groupboxBudget.Visible = false;
            this.groupboxDashboard.Visible = true;
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            //TODO
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

        // Income Menu Buttons
        private void menuIncomeDetails_Click(object sender, EventArgs e)
        {
            this.groupboxDashboard.Visible = false;
            this.groupboxExpenses.Visible = false;
            this.groupboxBudget.Visible = false;
            this.groupboxIncome.Visible = true;
        }

        private void menuIncomeEdit_Click(object sender, EventArgs e)
        {
            //TODO
        }

        // Expense Menu Buttons
        private void menuExpenseDetails_Click(object sender, EventArgs e)
        {
            this.groupboxDashboard.Visible = false;
            this.groupboxIncome.Visible = false;
            this.groupboxBudget.Visible = false;
            this.groupboxExpenses.Visible = true;
        }

        private void menuExpenseEdit_Click(object sender, EventArgs e)
        {

        }

        // Budget Menu Buttons
        private void menuBudgetDetails_Click(object sender, EventArgs e)
        {
            this.groupboxDashboard.Visible = false;
            this.groupboxIncome.Visible = false;
            this.groupboxExpenses.Visible = false;
            this.groupboxBudget.Visible = true;
        }

        private void menuBudgetEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
