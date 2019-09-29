using System;
using System.Windows.Forms;
namespace BudgetTrackerMain
{
    partial class formAddProfile
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
            #region User Entry Formatting
            int inputBoxLeftAlign = 20;
            int inputBoxRow1 = 60;
            int inputBoxRow2 = 100;
            int inputBoxRow3 = 140;
            int inputBoxRow4 = 180;
            int inputBoxRow5 = 220;
            int inputBoxRow6 = 260;
            int inputBoxRow7 = 300;
            int inputBoxWidth = 235;
            int inputBoxHeight = 20;
            int labelWidth = 200;
            int labelHeight = 15;
            var fontLabel = new System.Drawing.Font("Microsoft Sand Serif", 8, System.Drawing.FontStyle.Bold);

            this.labelFirstName = new Label()
            {
                Name = "labelFirstName",
                Text = "First Name:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow1 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputFirstName = new TextBox()
            {
                Name = "inputFirstName",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow1),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 0
            };

            this.labelLastName = new Label()
            {
                Name = "labelLastName",
                Text = "Last Name:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow2 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputLastName = new TextBox()
            {
                Name = "inputLastName",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow2),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 1
            };

            this.labelCompany = new Label()
            {
                Name = "labelCompany",
                Text = "Company:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow3 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputCompany = new TextBox()
            {
                Name = "inputCompany",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow3),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 2
            };

            this.labelJobTitle = new Label()
            {
                Name = "labelJobTitle",
                Text = "Job Title:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow4 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputJobTitle = new TextBox()
            {
                Name = "inputJobTitle",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow4),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 3
            };

            this.labelGrossYrlySalary = new Label()
            {
                Name = "labelGrossYrlySalary",
                Text = "Gross Yearly Salary:",
                Font = fontLabel,
                Location  = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow5 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputGrossYrlySalary = new TextBox()
            {
                Name = "inputGrossYrlySalary",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow5),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 4
            };

            this.labelState = new Label()
            {
                Name = "labelState",
                Text = "State:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow6 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputState = new TextBox()
            {
                Name = "inputState",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow6),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 5
            };

            this.labelNotes = new Label()
            {
                Name = "labelNotes",
                Text = "Notes:",
                Font = fontLabel,
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow7 - 15),
                Size = new System.Drawing.Size(labelWidth, labelHeight)
            };

            this.inputNotes = new TextBox()
            {
                Name = "inputNotes",
                Location = new System.Drawing.Point(inputBoxLeftAlign, inputBoxRow7),
                Size = new System.Drawing.Size(inputBoxWidth, inputBoxHeight),
                BorderStyle = BorderStyle.FixedSingle,
                TabIndex = 6
            };
            #endregion // User Entry Formatting

            #region Main Menu Formatting
            int menuMainWidth = 40;
            int menuMainHeight = 20;
            int menuSubWidth = 100;
            int menuSubHeight = 20;

            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuFileSave",
                Size = new System.Drawing.Size(menuSubWidth, menuSubHeight),
                Text = "Save"
            };

            this.menuFileClear = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuFileClear",
                Size = new System.Drawing.Size(menuSubWidth, menuSubHeight),
                Text = "Clear"
            };

            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem()
            {
                Name = "menuFileClose",
                Size = new System.Drawing.Size(menuSubWidth, menuSubHeight),
                Text = "Close"
            };
            this.menuFileClose.Click += new EventHandler(this.menuFileClose_Click);

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
                        this.menuFileSave,
                        this.menuFileClear,
                        this.menuFileClose
                    }
                );

            this.menuMain = new System.Windows.Forms.MenuStrip()
            {
                Name = "menuMain",
                Text = "Main Menu",
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(400, 24),
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
            #endregion // Main Menu formatting

            #region Button Formatting
            var buttonSize = new System.Drawing.Size(75, 30);
            int buttonLeftCol1 = 20;
            int buttonLeftCol2 = 100;
            int buttonLeftCol3 = 180;
            int buttonTop = 350;

            this.buttonSave = new Button()
            {
                Name = "buttonSave",
                Text = "Save",
                Location = new System.Drawing.Point(buttonLeftCol1, buttonTop),
                Size = buttonSize
            };
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            this.buttonClear = new Button()
            {
                Name = "buttonClear",
                Text = "Clear",
                Location = new System.Drawing.Point(buttonLeftCol2, buttonTop),
                Size = buttonSize
            };
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);

            this.buttonCancel = new Button()
            {
                Name = "buttonCancel",
                Text = "Cancel",
                Location = new System.Drawing.Point(buttonLeftCol3, buttonTop),
                Size = buttonSize
            };
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            #endregion

            #region Form Settings
            this.SuspendLayout();
            this.Name = "formAddProfile";
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 400);
            this.Text = "Add Profile";
            this.BackColor = System.Drawing.Color.White;

            this.Controls.Add(this.menuMain);

            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.inputCompany);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.inputJobTitle);
            this.Controls.Add(this.labelGrossYrlySalary);
            this.Controls.Add(this.inputGrossYrlySalary);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.inputState);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.inputNotes);

            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion // Form Settings
        }

        #region Call Controls
        
        #region Menu Controls
        private MenuStrip menuMain;

        private ToolStripMenuItem menuMainFile;

        private ToolStripMenuItem menuFileClear;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileClose;
        #endregion

        #region Input Labels
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelCompany;
        private Label labelJobTitle;
        private Label labelGrossYrlySalary;
        private Label labelState;
        private Label labelNotes;
        #endregion // Input Labels

        #region Input Controls
        private TextBox inputFirstName;
        private TextBox inputLastName;
        private TextBox inputCompany;
        private TextBox inputJobTitle;
        private TextBox inputGrossYrlySalary;
        private TextBox inputState;
        private TextBox inputNotes;
        #endregion // Input Controls

        #region Button Controls
        private Button buttonSave;
        private Button buttonClear;
        private Button buttonCancel;
        #endregion

        #endregion // Call Controls

        #endregion // Form Code
    }
}