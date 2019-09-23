using System;
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
            #region Control Creation
            this.SuspendLayout();
            #endregion

            #region Form Formatting
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Name = "formProfileManagement";
            this.Text = "Profile Management";
            this.BackColor = System.Drawing.Color.White;

            #endregion

            #region Main Menu Formatting
            this.menuMain = new System.Windows.Forms.MenuStrip()
            {
                Name = "menuMain",
                Text = "Main Menu",
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(800, 24),
                BackColor = System.Drawing.Color.White,
                TabIndex = 0,
                Visible = true
            };
            this.Controls.Add(menuMain);
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }

        #region Call Controls
        private System.Windows.Forms.MenuStrip menuMain;
        #endregion

        #endregion
    }
}