using System;
using System.Windows.Forms;
namespace BudgetTrackerMain
{
    partial class formProfileManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            #region Profile Selection Controls
            this.DrawGrid();
            #endregion

            #region Main Menu Formatting
            int menuMainWidth = 40;
            int menuMainHeight = 20;
            int menuSubWidth = 100;
            int menuSubHeight = 20;

            this.menuFileAddProfile = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuFileAddProfile",
                Size = new System.Drawing.Size(menuSubWidth, menuSubHeight),
                Text = "Add Profile"
            };
            this.menuFileAddProfile.Click += new EventHandler(this.menuFileAddProfile_Click);

            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuFileClose",
                Size = new System.Drawing.Size(menuSubWidth, menuSubHeight),
                Text = "Close"
            };
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);

            this.menuMainFile = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuMainFile",
                Size = new System.Drawing.Size(menuMainWidth, menuMainHeight),
                Text = "File"
            };
            this.menuMainFile.DropDownItems.AddRange
                (
                    new System.Windows.Forms.ToolStripItem[]
                    {
                        this.menuFileAddProfile,
                        this.menuFileClose
                    }
                );

            this.menuMain = new System.Windows.Forms.MenuStrip()
            {
                Name = "menuMain",
                Text = "Main Menu",
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(800, 24),
                BackColor = System.Drawing.Color.WhiteSmoke,
                TabIndex = 0,
                Visible = true
            };
            this.menuMain.Items.AddRange
                (
                    new System.Windows.Forms.ToolStripItem[]
                    {
                        this.menuMainFile
                    }
                );
            #endregion

            #region Button Formatting
            var buttonSize = new System.Drawing.Size(90, 40);
            int buttonXPos = 20;
            int buttonYPos = 50;
            int buttonYSpacing = 40;

            this.buttonAddProfile = new Button()
            {
                Name = "buttonAddProfile",
                Text = "Add Profile",
                Location = new System.Drawing.Point(buttonXPos, buttonYPos),
                Size = buttonSize
            };
            this.buttonAddProfile.Click += new EventHandler(this.buttonAddProfile_Click);

            this.buttonEditProfile = new Button()
            {
                Name = "buttonEditProfile",
                Text = "Edit Profile",
                Location = new System.Drawing.Point(buttonXPos, buttonYPos + buttonYSpacing),
                Size = buttonSize
            };
            this.buttonEditProfile.Click += new EventHandler(this.buttonEditProfile_Click);
            #endregion // Button Formatting

            #region Form Formatting
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Name = "formProfileManagement";
            this.Text = "Profile Management";
            this.BackColor = System.Drawing.Color.White;

            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.gridProfiles);
            this.Controls.Add(this.buttonAddProfile);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.buttonRemoveProfile);

            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }

        private void ButtonAddProfile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Call Controls
        private System.Windows.Forms.MenuStrip menuMain;

        private System.Windows.Forms.ToolStripMenuItem menuMainFile;

        private System.Windows.Forms.ToolStripMenuItem menuFileAddProfile;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;

        private Button buttonAddProfile;
        private Button buttonEditProfile;
        private Button buttonRemoveProfile;

        private Label labelProfiles;
        private DataGridView gridProfiles;
        #endregion

        #endregion
    }
}