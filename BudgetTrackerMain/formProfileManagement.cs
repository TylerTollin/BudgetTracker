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

        #region Menu File Buttons
        private void menuFileAddProfile_Click(object sender, EventArgs e)
        {
            OpenAddProfileForm("add");
        }

        private void formAddProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("formAddProfile was closed");
            GetProfiles();
            gridProfiles.Update();
            gridProfiles.Refresh();
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
                Dispose();
            }
        }
        #endregion

        #region Button Event Handlers
        private void buttonAddProfile_Click(object sender, EventArgs e)
        {
            OpenAddProfileForm("add");
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            int profileID = 0;
            string firstName = null;
            string lastName = null;
            string state = null;
            float yearlySalary = 0.0f;
            string company = null;
            string jobTitle = null;
            string notes = null;
            if (gridProfiles.SelectedRows.Count == 1)
            {
                profileID = Int16.Parse(gridProfiles.SelectedCells[0].Value.ToString());
                firstName = gridProfiles.SelectedCells[1].Value.ToString();
                lastName = gridProfiles.SelectedCells[2].Value.ToString();
                company = gridProfiles.SelectedCells[3].Value.ToString();
                jobTitle = gridProfiles.SelectedCells[4].Value.ToString();
                yearlySalary = float.Parse(gridProfiles.SelectedCells[5].Value.ToString());
                state = gridProfiles.SelectedCells[6].Value.ToString();
                notes = gridProfiles.SelectedCells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a single record to edit.");
            }
            OpenAddProfileForm
                (
                    "edit",
                    profileID,
                    firstName,
                    lastName,
                    state,
                    yearlySalary,
                    company,
                    jobTitle,
                    notes
                );
        }

        private void buttonRemoveProfile_Click(object sender, EventArgs e)
        {
            int profileID = 0;
            string firstName = null;
            string lastName = null;
            if (gridProfiles.SelectedRows.Count == 1)
            {
                profileID = Int16.Parse(gridProfiles.SelectedCells[0].Value.ToString());
                firstName = gridProfiles.SelectedCells[1].Value.ToString();
                lastName = gridProfiles.SelectedCells[2].Value.ToString();

                var result = MessageBox.Show
                    (
                        "Are you sure you want to delete the profile for " + firstName + " " + lastName + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo
                    );
                if (result == DialogResult.Yes)
                {
                    Database.DeleteProfile(profileID);
                    GetProfiles();
                }
            }
            else
            {
                MessageBox.Show("Please select a single record to remove.");
            }
        }
        #endregion

        public void GetProfiles()
        {
            gridProfiles.DataSource = null;
            System.Data.DataTable profiles = Database.RetrieveProfiles();
            gridProfiles.DataSource = profiles;
            Console.WriteLine("Profiles retrieved");
        }

        private void DrawGrid()
        {
            var gridLocation = new System.Drawing.Point(200, 50);
            var gridSize = new System.Drawing.Size(550, 500);

            this.gridProfiles = new DataGridView()
            {
                Name = "gridProfiles",
                Location = gridLocation,
                Size = gridSize,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowDrop = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            Console.WriteLine("Grid drawn");
            GetProfiles();
        }
        private void OpenAddProfileForm
            (
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
            Form formAddProfile = new formAddProfile
                (
                    _type,
                    _profileID,
                    _firstName,
                    _lastName,
                    _state,
                    _yearlySalary,
                    _company,
                    _jobTitle,
                    _notes
                );
            formAddProfile.FormClosed += new FormClosedEventHandler(formAddProfile_FormClosed);
            formAddProfile.ShowDialog();
        }
    }

}
