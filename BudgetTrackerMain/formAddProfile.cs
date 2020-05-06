using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackerMain
{
    public partial class formAddProfile : Form
    {
        string type = null;
        int profileID = 0;
        public formAddProfile
            (
                // TODO: update type is not working
                string _type = "add",
                int _profileID = 0,
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
            type = _type;
            profileID = _profileID;
            inputFirstName.Text = _firstName;
            inputLastName.Text = _lastName;
            inputState.Text = _state;
            inputGrossYrlySalary.Text = _yearlySalary.ToString();
            inputCompany.Text = _company;
            inputJobTitle.Text = _jobTitle;
            inputNotes.Text = _notes;
            Console.WriteLine(_type);
            Console.WriteLine(type);
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
                if (type == "add")
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
                else if (type == "edit")
                {
                    try
                    {
                        Database.UpdateProfile
                        (
                            profileID,
                            inputFirstName.Text,
                            inputLastName.Text,
                            inputState.Text,
                            float.Parse(inputGrossYrlySalary.Text),
                            inputCompany.Text,
                            inputJobTitle.Text,
                            inputNotes.Text
                        );
                        Console.WriteLine("Profile being updated: " + profileID.ToString());
                        MessageBox.Show
                            (
                                "The profile was updated!",
                                "Update Complete",
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
