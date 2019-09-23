using System;
namespace BudgetTrackerMain
{
    partial class formBudgetTracker
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
        private void InitializeComponent()
        {
            #region Control Creation
            this.menuMain = new System.Windows.Forms.MenuStrip();

            this.menuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();

            this.menuMainIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncomeEdit = new System.Windows.Forms.ToolStripMenuItem();

            this.menuMainExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpenseEdit = new System.Windows.Forms.ToolStripMenuItem();

            this.menuMainBudget = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBudgetDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBudgetEdit = new System.Windows.Forms.ToolStripMenuItem();

            this.menuMain.SuspendLayout();

            this.groupboxDashboard = new System.Windows.Forms.GroupBox();

            this.groupboxIncome = new System.Windows.Forms.GroupBox();
            this.labelGross = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textGrossYear = new System.Windows.Forms.TextBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textGrossMonth = new System.Windows.Forms.TextBox();
            this.labelWeek = new System.Windows.Forms.Label();
            this.textGrossWeek = new System.Windows.Forms.TextBox();

            this.labelFederal = new System.Windows.Forms.Label();
            this.textFederalYear = new System.Windows.Forms.TextBox();
            this.textFederalMonth = new System.Windows.Forms.TextBox();
            this.textFederalWeek = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textStateYear = new System.Windows.Forms.TextBox();
            this.textStateMonth = new System.Windows.Forms.TextBox();
            this.textStateWeek = new System.Windows.Forms.TextBox();
            this.labelSocSec = new System.Windows.Forms.Label();
            this.textSocSecYear = new System.Windows.Forms.TextBox();
            this.textSocSecMonth = new System.Windows.Forms.TextBox();
            this.textSocSecWeek = new System.Windows.Forms.TextBox();
            this.labelMedicare = new System.Windows.Forms.Label();
            this.textMedicareYear = new System.Windows.Forms.TextBox();
            this.textMedicareMonth = new System.Windows.Forms.TextBox();
            this.textMedicareWeek = new System.Windows.Forms.TextBox();
            this.labelTotalTax = new System.Windows.Forms.Label();
            this.textTotalTaxYear = new System.Windows.Forms.TextBox();
            this.textTotalTaxMonth = new System.Windows.Forms.TextBox();
            this.textTotalTaxWeek = new System.Windows.Forms.TextBox();
            this.labelIncomePostTax = new System.Windows.Forms.Label();
            this.textIncomePostTaxYear = new System.Windows.Forms.TextBox();
            this.textIncomePostTaxMonth = new System.Windows.Forms.TextBox();
            this.textIncomePostTaxWeek = new System.Windows.Forms.TextBox();

            this.groupboxExpenses = new System.Windows.Forms.GroupBox();

            this.groupboxBudget = new System.Windows.Forms.GroupBox();


            this.SuspendLayout();
            #endregion

            // formBudgetTracker
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.MainMenuStrip = this.menuMain;
            this.Name = "formBudgetTracker";
            this.Text = "BudgetTracker";
            this.BackColor = System.Drawing.Color.White;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.groupboxDashboard);
            this.Controls.Add(this.groupboxIncome);
            this.Controls.Add(this.groupboxExpenses);
            this.Controls.Add(this.groupboxBudget);

            #region Main Menu Formatting
            int menuMainWidth = 40;
            int menuMainHeight = 20;
            int menuSubWidth = 100;
            int menuSubHeight = 20;

            // menuMain
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Main Menu";
            this.menuMain.BackColor = System.Drawing.Color.White;
            this.menuMain.Items.AddRange
            (
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuMainFile,
                    this.menuMainIncome,
                    this.menuMainExpense,
                    this.menuMainBudget
                }
            );
            
            // menuMainFile
            this.menuMainFile.Name = "menuMainFile";
            this.menuMainFile.Size = new System.Drawing.Size(menuMainWidth, menuMainHeight);
            this.menuMainFile.Text = "File";
            this.menuMainFile.DropDownItems.AddRange
            (
                new System.Windows.Forms.ToolStripItem[]
                {
                        this.menuFileDashboard,
                        this.menuFileSave,
                        this.menuFileClose
                }
            );
                #region File Options
                // menuFileDashboard
                this.menuFileDashboard.Name = "menuFileDashboard";
                this.menuFileDashboard.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuFileDashboard.Text = "Dashboard";
                this.menuFileDashboard.Click += new System.EventHandler(this.menuFileDashboard_Click);

                // menuFileSave
                this.menuFileSave.Name = "menuFileSave";
                this.menuFileSave.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuFileSave.Text = "Save";
                this.menuFileSave.Click += new System.EventHandler(this.menuIncomeEdit_Click);

                // menuFileClose
                this.menuFileClose.Name = "menuFileClose";
                this.menuFileClose.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuFileClose.Text = "Close";
                this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
                #endregion

            // menuMainIncome
            this.menuMainIncome.Name = "menuMainIncome";
            this.menuMainIncome.Size = new System.Drawing.Size(menuMainWidth, menuMainHeight);
            this.menuMainIncome.Text = "Income";
            this.menuMainIncome.DropDownItems.AddRange
            (
                new System.Windows.Forms.ToolStripItem[]
                {
                        this.menuIncomeDetails,
                        this.menuIncomeEdit
                }
            );
                #region Income Options
                // menuIncomeDetails
                this.menuIncomeDetails.Name = "menuIncomeDetails";
                this.menuIncomeDetails.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuIncomeDetails.Text = "Details";
                this.menuIncomeDetails.Click += new System.EventHandler(this.menuIncomeDetails_Click);

                // menuIncomeEdit
                this.menuIncomeEdit.Name = "menuIncomeEdit";
                this.menuIncomeEdit.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuIncomeEdit.Text = "Edit";
                this.menuIncomeEdit.Click += new System.EventHandler(menuIncomeEdit_Click);
                #endregion

            // menuMainExpense
            this.menuMainExpense.Name = "menuMainExpense";
            this.menuMainExpense.Size = new System.Drawing.Size(menuMainWidth, menuMainHeight);
            this.menuMainExpense.Text = "Expense";
            this.menuMainExpense.DropDownItems.AddRange
            (
                new System.Windows.Forms.ToolStripItem[]
                {
                        this.menuExpenseDetails,
                        this.menuExpenseEdit
                }
            );
                #region Expense Options
                // menuExpenseDetails
                this.menuExpenseDetails.Name = "menuExpenseDetails";
                this.menuExpenseDetails.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuExpenseDetails.Text = "Details";
                this.menuExpenseDetails.Click += new System.EventHandler(menuExpenseDetails_Click);

                // menuExpenseEdit
                this.menuExpenseEdit.Name = "menuExpenseEdit";
                this.menuExpenseEdit.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuExpenseEdit.Text = "Edit";
                this.menuExpenseEdit.Click += new System.EventHandler(menuExpenseEdit_Click);
                #endregion

            // menuMainBudget
            this.menuMainBudget.Name = "menuMainBudget";
            this.menuMainBudget.Size = new System.Drawing.Size(menuMainWidth, menuMainHeight);
            this.menuMainBudget.Text = "Budgeting";
            this.menuMainBudget.DropDownItems.AddRange
            (
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuBudgetDetails,
                    this.menuBudgetEdit
                }
            );
                #region Budgeting Options
                // menuBudgetDetails
                this.menuBudgetDetails.Name = "menuBudgetDetails";
                this.menuBudgetDetails.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuBudgetDetails.Text = "Details";
                this.menuBudgetDetails.Click += new System.EventHandler(menuBudgetDetails_Click);

                // menuBudgetEdit
                this.menuBudgetEdit.Name = "menuBudgetEdit";
                this.menuBudgetEdit.Size = new System.Drawing.Size(menuSubWidth, menuSubHeight);
                this.menuBudgetEdit.Text = "Edit";
                this.menuBudgetEdit.Click += new System.EventHandler(menuBudgetEdit_Click);
                #endregion

            #endregion

            #region Group Box Formatting
            // Group Box Common Variables
            var groupboxStartPoint = new System.Drawing.Point(50, 50);
            var groupboxSize = new System.Drawing.Size(700, 700);

            var labelRowSize = new System.Drawing.Size(125, 20);
            var labelColumnSize = new System.Drawing.Size(50, 20);
            var textLoc1C = 150;
            var textLoc2C = 300;
            var textLoc3C = 450;
            var textLoc1R = 50;
            var textLoc2R = 100;
            var textLoc3R = 150;
            var textLoc4R = 200;
            var textLoc5R = 250;
            var textLoc6R = 300;
            var textLoc7R = 350;

            #region Group Box Dashboard Formatting
            this.groupboxDashboard.Location = groupboxStartPoint;
            this.groupboxDashboard.Size = groupboxSize;
            this.groupboxDashboard.Name = "groupboxDashboard";
            this.groupboxDashboard.Text = "Dashboard";
            this.groupboxDashboard.Visible = true;
            #endregion

            #region Group Box Income Formatting
            this.groupboxIncome.Location = groupboxStartPoint;
            this.groupboxIncome.Size = groupboxSize;
            this.groupboxIncome.Name = "groupboxIncome";
            this.groupboxIncome.Text = "Income Details";
            this.groupboxIncome.Visible = false;

            this.labelGross.Location = new System.Drawing.Point(25, 50);
            this.labelGross.Size = labelRowSize;
            this.labelGross.Font = new System.Drawing.Font("Microsoft Sand Serif", 8, System.Drawing.FontStyle.Bold);
            this.labelGross.Name = "labelGross";
            this.labelGross.Text = "Gross Income";
            this.groupboxIncome.Controls.Add(labelGross);

            this.labelFederal.Location = new System.Drawing.Point(25, 100);
            this.labelFederal.Size = labelRowSize;
            this.labelFederal.Name = "labelFederal";
            this.labelFederal.Text = "Federal Income Tax";
            this.groupboxIncome.Controls.Add(labelFederal);

            this.labelState.Location = new System.Drawing.Point(25, 150);
            this.labelState.Size = labelRowSize;
            this.labelState.Name = "labelState";
            this.labelState.Text = "State Income Tax";
            this.groupboxIncome.Controls.Add(labelState);

            this.labelSocSec.Location = new System.Drawing.Point(25, 200);
            this.labelSocSec.Size = labelRowSize;
            this.labelSocSec.Name = "labelSocSec";
            this.labelSocSec.Text = "Social Security";
            this.groupboxIncome.Controls.Add(labelSocSec);

            this.labelMedicare.Location = new System.Drawing.Point(25, 250);
            this.labelMedicare.Size = labelRowSize;
            this.labelMedicare.Name = "labelMedicare";
            this.labelMedicare.Text = "Medicare";
            this.groupboxIncome.Controls.Add(labelMedicare);

            this.labelTotalTax.Location = new System.Drawing.Point(25, 300);
            this.labelTotalTax.Size = labelRowSize;
            this.labelTotalTax.Name = "labelTotalTax";
            this.labelTotalTax.Text = "Total Tax";
            this.groupboxIncome.Controls.Add(labelTotalTax);

            this.labelIncomePostTax.Location = new System.Drawing.Point(25, 350);
            this.labelIncomePostTax.Size = labelRowSize;
            this.labelIncomePostTax.Font = new System.Drawing.Font("Microsoft Sand Serif", 8, System.Drawing.FontStyle.Bold);
            this.labelIncomePostTax.Name = "labelIncomePostTax";
            this.labelIncomePostTax.Text = "Post-Tax Income";
            this.groupboxIncome.Controls.Add(labelIncomePostTax);

            this.labelYear.Location = new System.Drawing.Point(150, 25);
            this.labelYear.Size = labelColumnSize;
            this.labelYear.Name = "labelYear";
            this.labelYear.Text = "Yearly";
            this.groupboxIncome.Controls.Add(labelYear);

            this.labelMonth.Location = new System.Drawing.Point(300, 25);
            this.labelMonth.Size = labelColumnSize;
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Text = "Monthly";
            this.groupboxIncome.Controls.Add(labelMonth);

            this.labelWeek.Location = new System.Drawing.Point(450, 25);
            this.labelWeek.Size = labelColumnSize;
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Text = "Weekly";
            this.groupboxIncome.Controls.Add(labelWeek);

            IncomeCalculations GrossIncome = new IncomeCalculations();

            this.textGrossYear.Location = new System.Drawing.Point(textLoc1C, textLoc1R);
            this.textGrossYear.Size = new System.Drawing.Size(100, 20);
            this.textGrossYear.ReadOnly = true;
            this.textGrossYear.Name = "textGrossYear";
            this.textGrossYear.Text = "$ " + GrossIncome.YearlyGrossIncome().ToString();
            this.groupboxIncome.Controls.Add(textGrossYear);

            this.textGrossMonth.Location = new System.Drawing.Point(textLoc2C, textLoc1R);
            this.textGrossMonth.Size = new System.Drawing.Size(100, 20);
            this.textGrossMonth.ReadOnly = true;
            this.textGrossMonth.Name = "textGrossMonth";
            this.textGrossMonth.Text = "$ " + GrossIncome.MonthlyGrossIncome().ToString();
            this.groupboxIncome.Controls.Add(textGrossMonth);

            this.textGrossWeek.Location = new System.Drawing.Point(textLoc3C, textLoc1R);
            this.textGrossWeek.Size = new System.Drawing.Size(100, 20);
            this.textGrossWeek.ReadOnly = true;
            this.textGrossWeek.Name = "textGrossWeek";
            this.textGrossWeek.Text = "$ " + GrossIncome.WeeklyGrossIncome().ToString();
            this.groupboxIncome.Controls.Add(textGrossWeek);

            TaxCalculations TaxCalculations = new TaxCalculations();

            this.textFederalYear.Location = new System.Drawing.Point(textLoc1C, textLoc2R);
            this.textFederalYear.Size = new System.Drawing.Size(100, 20);
            this.textFederalYear.ReadOnly = true;
            this.textFederalYear.Name = "textFederalYear";
            this.textFederalYear.Text = "$ " + TaxCalculations.YearlyFederalIncome().ToString();
            this.groupboxIncome.Controls.Add(textFederalYear);

            this.textFederalMonth.Location = new System.Drawing.Point(textLoc2C, textLoc2R);
            this.textFederalMonth.Size = new System.Drawing.Size(100, 20);
            this.textFederalMonth.ReadOnly = true;
            this.textFederalMonth.Name = "textFederalMonth";
            this.textFederalMonth.Text = "$ " + TaxCalculations.MonthlyFederalIncome().ToString();
            this.groupboxIncome.Controls.Add(textFederalMonth);

            this.textFederalWeek.Location = new System.Drawing.Point(textLoc3C, textLoc2R);
            this.textFederalWeek.Size = new System.Drawing.Size(100, 20);
            this.textFederalWeek.ReadOnly = true;
            this.textFederalWeek.Name = "textFederalWeek";
            this.textFederalWeek.Text = "$ " + TaxCalculations.WeeklyFederalIncome().ToString();
            this.groupboxIncome.Controls.Add(textFederalWeek);

            this.textStateYear.Location = new System.Drawing.Point(textLoc1C, textLoc3R);
            this.textStateYear.Size = new System.Drawing.Size(100, 20);
            this.textStateYear.ReadOnly = true;
            this.textStateYear.Name = "textStateYear";
            this.textStateYear.Text = "$ " + TaxCalculations.YearlyStateIncome().ToString();
            this.groupboxIncome.Controls.Add(textStateYear);

            this.textStateMonth.Location = new System.Drawing.Point(textLoc2C, textLoc3R);
            this.textStateMonth.Size = new System.Drawing.Size(100, 20);
            this.textStateMonth.ReadOnly = true;
            this.textStateMonth.Name = "textStateMonth";
            this.textStateMonth.Text = "$ " + TaxCalculations.MonthlyStateIncome().ToString();
            this.groupboxIncome.Controls.Add(textStateMonth);

            this.textStateWeek.Location = new System.Drawing.Point(textLoc3C, textLoc3R);
            this.textStateWeek.Size = new System.Drawing.Size(100, 20);
            this.textStateWeek.ReadOnly = true;
            this.textStateWeek.Name = "textStateWeek";
            this.textStateWeek.Text = "$ " + TaxCalculations.WeeklyStateIncome().ToString();
            this.groupboxIncome.Controls.Add(textStateWeek);

            this.textSocSecYear.Location = new System.Drawing.Point(textLoc1C, textLoc4R);
            this.textSocSecYear.Size = new System.Drawing.Size(100, 20);
            this.textSocSecYear.ReadOnly = true;
            this.textSocSecYear.Name = "textSocSecYear";
            this.textSocSecYear.Text = "$ " + TaxCalculations.YearlySocSec().ToString();
            this.groupboxIncome.Controls.Add(textSocSecYear);

            this.textSocSecMonth.Location = new System.Drawing.Point(textLoc2C, textLoc4R);
            this.textSocSecMonth.Size = new System.Drawing.Size(100, 20);
            this.textSocSecMonth.ReadOnly = true;
            this.textSocSecMonth.Name = "textSocSecMonth";
            this.textSocSecMonth.Text = "$ " + TaxCalculations.MonthlySocSec().ToString();
            this.groupboxIncome.Controls.Add(textSocSecMonth);

            this.textSocSecWeek.Location = new System.Drawing.Point(textLoc3C, textLoc4R);
            this.textSocSecWeek.Size = new System.Drawing.Size(100, 20);
            this.textSocSecWeek.ReadOnly = true;
            this.textSocSecWeek.Name = "textSocSecWeek";
            this.textSocSecWeek.Text = "$ " + TaxCalculations.WeeklySocSec().ToString();
            this.groupboxIncome.Controls.Add(textSocSecWeek);

            this.textMedicareYear.Location = new System.Drawing.Point(textLoc1C, textLoc5R);
            this.textMedicareYear.Size = new System.Drawing.Size(100, 20);
            this.textMedicareYear.ReadOnly = true;
            this.textMedicareYear.Name = "textMedicareYear";
            this.textMedicareYear.Text = "$ " + TaxCalculations.YearlyMedicare().ToString();
            this.groupboxIncome.Controls.Add(textMedicareYear);

            this.textMedicareMonth.Location = new System.Drawing.Point(textLoc2C, textLoc5R);
            this.textMedicareMonth.Size = new System.Drawing.Size(100, 20);
            this.textMedicareMonth.ReadOnly = true;
            this.textMedicareMonth.Name = "textMedicareMonth";
            this.textMedicareMonth.Text = "$ " + TaxCalculations.MonthlyMedicare().ToString();
            this.groupboxIncome.Controls.Add(textMedicareMonth);

            this.textMedicareWeek.Location = new System.Drawing.Point(textLoc3C, textLoc5R);
            this.textMedicareWeek.Size = new System.Drawing.Size(100, 20);
            this.textMedicareWeek.ReadOnly = true;
            this.textMedicareWeek.Name = "textMedicareWeek";
            this.textMedicareWeek.Text = "$ " + TaxCalculations.WeeklyMedicare().ToString();
            this.groupboxIncome.Controls.Add(textMedicareWeek);

            this.textTotalTaxYear.Location = new System.Drawing.Point(textLoc1C, textLoc6R);
            this.textTotalTaxYear.Size = new System.Drawing.Size(100, 20);
            this.textTotalTaxYear.ReadOnly = true;
            this.textTotalTaxYear.Name = "textTotalTaxYear";
            this.textTotalTaxYear.Text = "$ " + TaxCalculations.YearlyTotalTax().ToString();
            this.groupboxIncome.Controls.Add(textTotalTaxYear);

            this.textTotalTaxMonth.Location = new System.Drawing.Point(textLoc2C, textLoc6R);
            this.textTotalTaxMonth.Size = new System.Drawing.Size(100, 20);
            this.textTotalTaxMonth.ReadOnly = true;
            this.textTotalTaxMonth.Name = "textTotalTaxMonth";
            this.textTotalTaxMonth.Text = "$ " + TaxCalculations.MonthlyTotalTax().ToString();
            this.groupboxIncome.Controls.Add(textTotalTaxMonth);

            this.textTotalTaxWeek.Location = new System.Drawing.Point(textLoc3C, textLoc6R);
            this.textTotalTaxWeek.Size = new System.Drawing.Size(100, 20);
            this.textTotalTaxWeek.ReadOnly = true;
            this.textTotalTaxWeek.Name = "textTotalTaxWeek";
            this.textTotalTaxWeek.Text = "$ " + TaxCalculations.WeeklyTotalTax().ToString();
            this.groupboxIncome.Controls.Add(textTotalTaxWeek);

            this.textIncomePostTaxYear.Location = new System.Drawing.Point(textLoc1C, textLoc7R);
            this.textIncomePostTaxYear.Size = new System.Drawing.Size(100, 20);
            this.textIncomePostTaxYear.ReadOnly = true;
            this.textIncomePostTaxYear.Name = "textPostTaxYear";
            this.textIncomePostTaxYear.Text = "$ " + TaxCalculations.YearlyPostTaxIncome().ToString();
            this.groupboxIncome.Controls.Add(textIncomePostTaxYear);

            this.textIncomePostTaxMonth.Location = new System.Drawing.Point(textLoc2C, textLoc7R);
            this.textIncomePostTaxMonth.Size = new System.Drawing.Size(100, 20);
            this.textIncomePostTaxMonth.ReadOnly = true;
            this.textIncomePostTaxMonth.Name = "textPostTaxMonth";
            this.textIncomePostTaxMonth.Text = "$ " + TaxCalculations.MonthlyPostTaxIncome().ToString();
            this.groupboxIncome.Controls.Add(textIncomePostTaxMonth);

            this.textIncomePostTaxWeek.Location = new System.Drawing.Point(textLoc3C, textLoc7R);
            this.textIncomePostTaxWeek.Size = new System.Drawing.Size(100, 20);
            this.textIncomePostTaxWeek.ReadOnly = true;
            this.textIncomePostTaxWeek.Name = "textPostTaxWeek";
            this.textIncomePostTaxWeek.Text = "$ " + TaxCalculations.WeeklyPostTaxIncome().ToString();
            this.groupboxIncome.Controls.Add(textIncomePostTaxWeek);

            #endregion

            #region Group Box Expenses Formatting
            this.groupboxExpenses.Location = groupboxStartPoint;
            this.groupboxExpenses.Size = groupboxSize;
            this.groupboxExpenses.Name = "groupboxExpenses";
            this.groupboxExpenses.Text = "Expense Details";
            this.groupboxExpenses.Visible = false;
            #endregion

            #region Group Box Budget Formatting
            this.groupboxBudget.Location = groupboxStartPoint;
            this.groupboxBudget.Size = groupboxSize;
            this.groupboxBudget.Name = "groupboxBudget";
            this.groupboxBudget.Text = "Budget Details";
            this.groupboxBudget.Visible = false;
            #endregion

            #endregion
        }
        #endregion

        #region Menu Controls
        // Main Menu Controls
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainFile;
        private System.Windows.Forms.ToolStripMenuItem menuMainIncome;
        private System.Windows.Forms.ToolStripMenuItem menuMainExpense;
        private System.Windows.Forms.ToolStripMenuItem menuMainBudget;

        // File Menu Controls
        private System.Windows.Forms.ToolStripMenuItem menuFileDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;

        // Income Menu Controls
        private System.Windows.Forms.ToolStripMenuItem menuIncomeDetails;
        private System.Windows.Forms.ToolStripMenuItem menuIncomeEdit;

        // Expense Menu Controls
        private System.Windows.Forms.ToolStripMenuItem menuExpenseDetails;
        private System.Windows.Forms.ToolStripMenuItem menuExpenseEdit;

        // Budget Menu Controls
        private System.Windows.Forms.ToolStripMenuItem menuBudgetDetails;
        private System.Windows.Forms.ToolStripMenuItem menuBudgetEdit;
        #endregion

        #region Group Box Controls
        private System.Windows.Forms.GroupBox groupboxDashboard;
        private System.Windows.Forms.GroupBox groupboxIncome;
        private System.Windows.Forms.GroupBox groupboxExpenses;
        private System.Windows.Forms.GroupBox groupboxBudget;

        #region groupboxIncome Controls
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelWeek;

        private System.Windows.Forms.Label labelGross;
        private System.Windows.Forms.TextBox textGrossYear;
        private System.Windows.Forms.TextBox textGrossMonth;
        private System.Windows.Forms.TextBox textGrossWeek;

        private System.Windows.Forms.Label labelFederal;
        private System.Windows.Forms.TextBox textFederalYear;
        private System.Windows.Forms.TextBox textFederalMonth;
        private System.Windows.Forms.TextBox textFederalWeek;

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textStateYear;
        private System.Windows.Forms.TextBox textStateMonth;
        private System.Windows.Forms.TextBox textStateWeek;

        private System.Windows.Forms.Label labelSocSec;
        private System.Windows.Forms.TextBox textSocSecYear;
        private System.Windows.Forms.TextBox textSocSecMonth;
        private System.Windows.Forms.TextBox textSocSecWeek;

        private System.Windows.Forms.Label labelMedicare;
        private System.Windows.Forms.TextBox textMedicareYear;
        private System.Windows.Forms.TextBox textMedicareMonth;
        private System.Windows.Forms.TextBox textMedicareWeek;

        private System.Windows.Forms.Label labelTotalTax;
        private System.Windows.Forms.TextBox textTotalTaxYear;
        private System.Windows.Forms.TextBox textTotalTaxMonth;
        private System.Windows.Forms.TextBox textTotalTaxWeek;

        private System.Windows.Forms.Label labelIncomePostTax;
        private System.Windows.Forms.TextBox textIncomePostTaxYear;
        private System.Windows.Forms.TextBox textIncomePostTaxMonth;
        private System.Windows.Forms.TextBox textIncomePostTaxWeek;
        #endregion

        #region groupboxExpenses Controls

        #endregion

        #region groupboxBudget Controls

        #endregion

        #endregion
    }
}

