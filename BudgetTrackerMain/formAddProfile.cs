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
    public partial class formAddProfile : Form
    {
        public formAddProfile
            (
                string _firstName = null,
                string _lastName = null,
                string _state = null,
                float _yearlySalary = 0.0f,
                string _company = null,
                string _jobTitle = null,
                string _notes = null
            )
        {
            InitializeComponent();
        }

        #region Menu Controls
        private void menuFileClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
                (
                    "Are you sure you want to exit? Unsaved changes will be lost.",
                    "Exit Window",
                    MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion // Menu Controls

        #region Button Controls
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var ConfirmInput = MessageBox.Show
                (
                    "Are you sure you want to save this profile?",
                    "Profile Confirmation",
                    MessageBoxButtons.YesNo
                );
            if (ConfirmInput == DialogResult.Yes)
            {
                try
                {
                    Database.InsertProfile
                    (
                        inputFirstName.Text,
                        inputLastName.Text,
                        inputState.Text,
                        float.Parse(inputGrossYrlySalary.Text),
                        inputCompany.Text,
                        inputJobTitle.Text,
                        inputNotes.Text
                    );
                    MessageBox.Show
                        (
                            "The profile was added!",
                            "Add Complete",
                            MessageBoxButtons.OK
                        );
                    this.Dispose();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputFirstName.Clear();
            inputLastName.Clear();
            inputCompany.Clear();
            inputJobTitle.Clear();
            inputGrossYrlySalary.Clear();

            inputFirstName.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
                (
                    "Are you sure you want to exit? Unsaved changes will be lost.",
                    "Exit Window",
                    MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion // Button Controls
    }
}
