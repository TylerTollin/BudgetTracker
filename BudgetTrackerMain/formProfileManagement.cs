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
            OpenAddProfileForm();
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
            OpenAddProfileForm();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            string firstName = null;
            if (gridProfiles.SelectedRows.Count == 1)
            {
                //DataGridViewRow row = this.gridProfiles.Rows[d.RowIndex];
                //firstName = row.Cells["First Name"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Please select a single record.");
            }
            OpenAddProfileForm(firstName);
            
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
            this.GetProfiles();
        }
        private void OpenAddProfileForm
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
            Form formAddProfile = new formAddProfile();
            formAddProfile.FormClosed += new FormClosedEventHandler(formAddProfile_FormClosed);
            formAddProfile.ShowDialog();
        }
    }

}
