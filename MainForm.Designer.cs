/////////////////////////////////////////////
// MainForm.Designer.cs                    //
// Created by: Markus Lidrot, 2015-10-24   //
/////////////////////////////////////////////

namespace Assignment3
{
    /// <summary>
    /// This class handling gui compontens. It is autocreated by Visual studios.
    /// </summary>
    partial class MainForm
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
            this.boxFuel = new System.Windows.Forms.GroupBox();
            this.btnCalcFuel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmountFuel = new System.Windows.Forms.TextBox();
            this.textBoxPrevOdo = new System.Windows.Forms.TextBox();
            this.textBoxCurrentOdo = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAmountFuel = new System.Windows.Forms.Label();
            this.labelCurrentOdo = new System.Windows.Forms.Label();
            this.labelPrevOdo = new System.Windows.Forms.Label();
            this.boxFuelRes = new System.Windows.Forms.GroupBox();
            this.labelFuelResPrice = new System.Windows.Forms.Label();
            this.labelFuelResLiterToSwe = new System.Windows.Forms.Label();
            this.labelFuelResLiterToMetric = new System.Windows.Forms.Label();
            this.labelFuelResLiterToKm = new System.Windows.Forms.Label();
            this.labelFuelResKmToLiter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFuelConsLiterToSwe = new System.Windows.Forms.Label();
            this.labelFuelConsLiterToMetric = new System.Windows.Forms.Label();
            this.labelFuelConsLiterToKm = new System.Windows.Forms.Label();
            this.labelFuelConsKmToLiter = new System.Windows.Forms.Label();
            this.boxExtra = new System.Windows.Forms.GroupBox();
            this.btnCalcPower = new System.Windows.Forms.Button();
            this.labelProductStandby = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPowerResDiff = new System.Windows.Forms.Label();
            this.labelPowerResNew = new System.Windows.Forms.Label();
            this.labelPowerResOld = new System.Windows.Forms.Label();
            this.labelPowerDiff = new System.Windows.Forms.Label();
            this.labelPowerNewYearly = new System.Windows.Forms.Label();
            this.labelPowerOldYearly = new System.Windows.Forms.Label();
            this.labelCostPerKW = new System.Windows.Forms.Label();
            this.textBoxCostPerKW = new System.Windows.Forms.TextBox();
            this.comboBoxStandBy = new System.Windows.Forms.ComboBox();
            this.labelProductUsed = new System.Windows.Forms.Label();
            this.comboBoxUsed = new System.Windows.Forms.ComboBox();
            this.labelProductUsage = new System.Windows.Forms.Label();
            this.textBoxNewStandBy = new System.Windows.Forms.TextBox();
            this.labelStandbyNew = new System.Windows.Forms.Label();
            this.labelTurnOnNew = new System.Windows.Forms.Label();
            this.textBoxNewTurnedOn = new System.Windows.Forms.TextBox();
            this.textBoxOldStandBy = new System.Windows.Forms.TextBox();
            this.labelStandbyOld = new System.Windows.Forms.Label();
            this.labelTurnedOnOld = new System.Windows.Forms.Label();
            this.textBoxOldTurnedOn = new System.Windows.Forms.TextBox();
            this.labelPowerNewWatt = new System.Windows.Forms.Label();
            this.labelPowerOldWatt = new System.Windows.Forms.Label();
            this.boxBMR = new System.Windows.Forms.GroupBox();
            this.labelSelected = new System.Windows.Forms.Label();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnCalcBMR = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.listBoxBMR = new System.Windows.Forms.ListBox();
            this.boxActivity = new System.Windows.Forms.GroupBox();
            this.rbActivity5 = new System.Windows.Forms.RadioButton();
            this.rbActivity4 = new System.Windows.Forms.RadioButton();
            this.rbActivity3 = new System.Windows.Forms.RadioButton();
            this.rbActivity2 = new System.Windows.Forms.RadioButton();
            this.rbActivity1 = new System.Windows.Forms.RadioButton();
            this.boxFuel.SuspendLayout();
            this.boxFuelRes.SuspendLayout();
            this.boxExtra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.boxBMR.SuspendLayout();
            this.boxActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxFuel
            // 
            this.boxFuel.Controls.Add(this.btnCalcFuel);
            this.boxFuel.Controls.Add(this.textBoxPrice);
            this.boxFuel.Controls.Add(this.textBoxAmountFuel);
            this.boxFuel.Controls.Add(this.textBoxPrevOdo);
            this.boxFuel.Controls.Add(this.textBoxCurrentOdo);
            this.boxFuel.Controls.Add(this.labelPrice);
            this.boxFuel.Controls.Add(this.labelAmountFuel);
            this.boxFuel.Controls.Add(this.labelCurrentOdo);
            this.boxFuel.Controls.Add(this.labelPrevOdo);
            this.boxFuel.Controls.Add(this.boxFuelRes);
            this.boxFuel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFuel.Location = new System.Drawing.Point(13, 22);
            this.boxFuel.Name = "boxFuel";
            this.boxFuel.Size = new System.Drawing.Size(382, 345);
            this.boxFuel.TabIndex = 0;
            this.boxFuel.TabStop = false;
            this.boxFuel.Text = "Fuel";
            // 
            // btnCalcFuel
            // 
            this.btnCalcFuel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcFuel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcFuel.Location = new System.Drawing.Point(110, 142);
            this.btnCalcFuel.Name = "btnCalcFuel";
            this.btnCalcFuel.Size = new System.Drawing.Size(159, 30);
            this.btnCalcFuel.TabIndex = 10;
            this.btnCalcFuel.Text = "Calculate";
            this.btnCalcFuel.UseVisualStyleBackColor = false;
            this.btnCalcFuel.Click += new System.EventHandler(this.btnCalcFuel_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(254, 110);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(112, 26);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAmountFuel
            // 
            this.textBoxAmountFuel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmountFuel.Location = new System.Drawing.Point(254, 84);
            this.textBoxAmountFuel.Name = "textBoxAmountFuel";
            this.textBoxAmountFuel.Size = new System.Drawing.Size(112, 26);
            this.textBoxAmountFuel.TabIndex = 8;
            this.textBoxAmountFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPrevOdo
            // 
            this.textBoxPrevOdo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrevOdo.Location = new System.Drawing.Point(254, 58);
            this.textBoxPrevOdo.Name = "textBoxPrevOdo";
            this.textBoxPrevOdo.Size = new System.Drawing.Size(112, 26);
            this.textBoxPrevOdo.TabIndex = 7;
            this.textBoxPrevOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCurrentOdo
            // 
            this.textBoxCurrentOdo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentOdo.Location = new System.Drawing.Point(254, 32);
            this.textBoxCurrentOdo.Name = "textBoxCurrentOdo";
            this.textBoxCurrentOdo.Size = new System.Drawing.Size(112, 26);
            this.textBoxCurrentOdo.TabIndex = 6;
            this.textBoxCurrentOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(17, 114);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(105, 18);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price per liter";
            // 
            // labelAmountFuel
            // 
            this.labelAmountFuel.AutoSize = true;
            this.labelAmountFuel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountFuel.Location = new System.Drawing.Point(17, 88);
            this.labelAmountFuel.Name = "labelAmountFuel";
            this.labelAmountFuel.Size = new System.Drawing.Size(212, 18);
            this.labelAmountFuel.TabIndex = 4;
            this.labelAmountFuel.Text = "Amount of fuel tanked (liters)";
            // 
            // labelCurrentOdo
            // 
            this.labelCurrentOdo.AutoSize = true;
            this.labelCurrentOdo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOdo.Location = new System.Drawing.Point(17, 40);
            this.labelCurrentOdo.Name = "labelCurrentOdo";
            this.labelCurrentOdo.Size = new System.Drawing.Size(227, 18);
            this.labelCurrentOdo.TabIndex = 3;
            this.labelCurrentOdo.Text = "Current odometer reading (km)";
            // 
            // labelPrevOdo
            // 
            this.labelPrevOdo.AutoSize = true;
            this.labelPrevOdo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevOdo.Location = new System.Drawing.Point(17, 62);
            this.labelPrevOdo.Name = "labelPrevOdo";
            this.labelPrevOdo.Size = new System.Drawing.Size(236, 18);
            this.labelPrevOdo.TabIndex = 2;
            this.labelPrevOdo.Text = "Previous odometer reading (km)";
            // 
            // boxFuelRes
            // 
            this.boxFuelRes.Controls.Add(this.labelFuelResPrice);
            this.boxFuelRes.Controls.Add(this.labelFuelResLiterToSwe);
            this.boxFuelRes.Controls.Add(this.labelFuelResLiterToMetric);
            this.boxFuelRes.Controls.Add(this.labelFuelResLiterToKm);
            this.boxFuelRes.Controls.Add(this.labelFuelResKmToLiter);
            this.boxFuelRes.Controls.Add(this.label9);
            this.boxFuelRes.Controls.Add(this.labelFuelConsLiterToSwe);
            this.boxFuelRes.Controls.Add(this.labelFuelConsLiterToMetric);
            this.boxFuelRes.Controls.Add(this.labelFuelConsLiterToKm);
            this.boxFuelRes.Controls.Add(this.labelFuelConsKmToLiter);
            this.boxFuelRes.Location = new System.Drawing.Point(6, 176);
            this.boxFuelRes.Name = "boxFuelRes";
            this.boxFuelRes.Size = new System.Drawing.Size(370, 163);
            this.boxFuelRes.TabIndex = 0;
            this.boxFuelRes.TabStop = false;
            this.boxFuelRes.Text = "Results";
            // 
            // labelFuelResPrice
            // 
            this.labelFuelResPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelResPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelResPrice.Location = new System.Drawing.Point(280, 131);
            this.labelFuelResPrice.Name = "labelFuelResPrice";
            this.labelFuelResPrice.Size = new System.Drawing.Size(70, 19);
            this.labelFuelResPrice.TabIndex = 9;
            this.labelFuelResPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFuelResLiterToSwe
            // 
            this.labelFuelResLiterToSwe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelResLiterToSwe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelResLiterToSwe.Location = new System.Drawing.Point(280, 103);
            this.labelFuelResLiterToSwe.Name = "labelFuelResLiterToSwe";
            this.labelFuelResLiterToSwe.Size = new System.Drawing.Size(70, 19);
            this.labelFuelResLiterToSwe.TabIndex = 8;
            this.labelFuelResLiterToSwe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFuelResLiterToMetric
            // 
            this.labelFuelResLiterToMetric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelResLiterToMetric.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelResLiterToMetric.Location = new System.Drawing.Point(280, 74);
            this.labelFuelResLiterToMetric.Name = "labelFuelResLiterToMetric";
            this.labelFuelResLiterToMetric.Size = new System.Drawing.Size(70, 19);
            this.labelFuelResLiterToMetric.TabIndex = 7;
            this.labelFuelResLiterToMetric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFuelResLiterToKm
            // 
            this.labelFuelResLiterToKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelResLiterToKm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelResLiterToKm.Location = new System.Drawing.Point(281, 47);
            this.labelFuelResLiterToKm.Name = "labelFuelResLiterToKm";
            this.labelFuelResLiterToKm.Size = new System.Drawing.Size(70, 19);
            this.labelFuelResLiterToKm.TabIndex = 6;
            this.labelFuelResLiterToKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFuelResKmToLiter
            // 
            this.labelFuelResKmToLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFuelResKmToLiter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelResKmToLiter.Location = new System.Drawing.Point(281, 20);
            this.labelFuelResKmToLiter.Name = "labelFuelResKmToLiter";
            this.labelFuelResKmToLiter.Size = new System.Drawing.Size(70, 19);
            this.labelFuelResKmToLiter.TabIndex = 5;
            this.labelFuelResKmToLiter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cost per kilometer";
            // 
            // labelFuelConsLiterToSwe
            // 
            this.labelFuelConsLiterToSwe.AutoSize = true;
            this.labelFuelConsLiterToSwe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelConsLiterToSwe.Location = new System.Drawing.Point(11, 104);
            this.labelFuelConsLiterToSwe.Name = "labelFuelConsLiterToSwe";
            this.labelFuelConsLiterToSwe.Size = new System.Drawing.Size(238, 18);
            this.labelFuelConsLiterToSwe.TabIndex = 3;
            this.labelFuelConsLiterToSwe.Text = "Fuel consumtion (liter/ Swe mile)";
            // 
            // labelFuelConsLiterToMetric
            // 
            this.labelFuelConsLiterToMetric.AutoSize = true;
            this.labelFuelConsLiterToMetric.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelConsLiterToMetric.Location = new System.Drawing.Point(11, 74);
            this.labelFuelConsLiterToMetric.Name = "labelFuelConsLiterToMetric";
            this.labelFuelConsLiterToMetric.Size = new System.Drawing.Size(252, 18);
            this.labelFuelConsLiterToMetric.TabIndex = 2;
            this.labelFuelConsLiterToMetric.Text = "Fuel consumtion (liter/ metric mile)";
            // 
            // labelFuelConsLiterToKm
            // 
            this.labelFuelConsLiterToKm.AutoSize = true;
            this.labelFuelConsLiterToKm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelConsLiterToKm.Location = new System.Drawing.Point(11, 47);
            this.labelFuelConsLiterToKm.Name = "labelFuelConsLiterToKm";
            this.labelFuelConsLiterToKm.Size = new System.Drawing.Size(195, 18);
            this.labelFuelConsLiterToKm.TabIndex = 1;
            this.labelFuelConsLiterToKm.Text = "Fuel consumtion (liter/ km)";
            // 
            // labelFuelConsKmToLiter
            // 
            this.labelFuelConsKmToLiter.AutoSize = true;
            this.labelFuelConsKmToLiter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelConsKmToLiter.Location = new System.Drawing.Point(11, 20);
            this.labelFuelConsKmToLiter.Name = "labelFuelConsKmToLiter";
            this.labelFuelConsKmToLiter.Size = new System.Drawing.Size(195, 18);
            this.labelFuelConsKmToLiter.TabIndex = 0;
            this.labelFuelConsKmToLiter.Text = "Fuel consumtion (km/ liter)";
            // 
            // boxExtra
            // 
            this.boxExtra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxExtra.Controls.Add(this.btnCalcPower);
            this.boxExtra.Controls.Add(this.labelProductStandby);
            this.boxExtra.Controls.Add(this.groupBox1);
            this.boxExtra.Controls.Add(this.labelCostPerKW);
            this.boxExtra.Controls.Add(this.textBoxCostPerKW);
            this.boxExtra.Controls.Add(this.comboBoxStandBy);
            this.boxExtra.Controls.Add(this.labelProductUsed);
            this.boxExtra.Controls.Add(this.comboBoxUsed);
            this.boxExtra.Controls.Add(this.labelProductUsage);
            this.boxExtra.Controls.Add(this.textBoxNewStandBy);
            this.boxExtra.Controls.Add(this.labelStandbyNew);
            this.boxExtra.Controls.Add(this.labelTurnOnNew);
            this.boxExtra.Controls.Add(this.textBoxNewTurnedOn);
            this.boxExtra.Controls.Add(this.textBoxOldStandBy);
            this.boxExtra.Controls.Add(this.labelStandbyOld);
            this.boxExtra.Controls.Add(this.labelTurnedOnOld);
            this.boxExtra.Controls.Add(this.textBoxOldTurnedOn);
            this.boxExtra.Controls.Add(this.labelPowerNewWatt);
            this.boxExtra.Controls.Add(this.labelPowerOldWatt);
            this.boxExtra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxExtra.Location = new System.Drawing.Point(419, 22);
            this.boxExtra.Name = "boxExtra";
            this.boxExtra.Size = new System.Drawing.Size(477, 345);
            this.boxExtra.TabIndex = 1;
            this.boxExtra.TabStop = false;
            this.boxExtra.Text = "Power consumtion cost";
            // 
            // btnCalcPower
            // 
            this.btnCalcPower.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcPower.Location = new System.Drawing.Point(269, 216);
            this.btnCalcPower.Name = "btnCalcPower";
            this.btnCalcPower.Size = new System.Drawing.Size(158, 29);
            this.btnCalcPower.TabIndex = 19;
            this.btnCalcPower.Text = "Calculate";
            this.btnCalcPower.UseVisualStyleBackColor = false;
            this.btnCalcPower.Click += new System.EventHandler(this.btnCalcPower_Click);
            // 
            // labelProductStandby
            // 
            this.labelProductStandby.AutoSize = true;
            this.labelProductStandby.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelProductStandby.Location = new System.Drawing.Point(217, 184);
            this.labelProductStandby.Name = "labelProductStandby";
            this.labelProductStandby.Size = new System.Drawing.Size(124, 16);
            this.labelProductStandby.TabIndex = 18;
            this.labelProductStandby.Text = "Stand-by (hours)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPowerResDiff);
            this.groupBox1.Controls.Add(this.labelPowerResNew);
            this.groupBox1.Controls.Add(this.labelPowerResOld);
            this.groupBox1.Controls.Add(this.labelPowerDiff);
            this.groupBox1.Controls.Add(this.labelPowerNewYearly);
            this.groupBox1.Controls.Add(this.labelPowerOldYearly);
            this.groupBox1.Location = new System.Drawing.Point(7, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // labelPowerResDiff
            // 
            this.labelPowerResDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPowerResDiff.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerResDiff.Location = new System.Drawing.Point(208, 65);
            this.labelPowerResDiff.Name = "labelPowerResDiff";
            this.labelPowerResDiff.Size = new System.Drawing.Size(79, 16);
            this.labelPowerResDiff.TabIndex = 24;
            this.labelPowerResDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPowerResNew
            // 
            this.labelPowerResNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPowerResNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerResNew.Location = new System.Drawing.Point(208, 43);
            this.labelPowerResNew.Name = "labelPowerResNew";
            this.labelPowerResNew.Size = new System.Drawing.Size(79, 16);
            this.labelPowerResNew.TabIndex = 23;
            this.labelPowerResNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPowerResOld
            // 
            this.labelPowerResOld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPowerResOld.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerResOld.Location = new System.Drawing.Point(208, 22);
            this.labelPowerResOld.Name = "labelPowerResOld";
            this.labelPowerResOld.Size = new System.Drawing.Size(79, 16);
            this.labelPowerResOld.TabIndex = 22;
            this.labelPowerResOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPowerDiff
            // 
            this.labelPowerDiff.AutoSize = true;
            this.labelPowerDiff.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerDiff.Location = new System.Drawing.Point(13, 66);
            this.labelPowerDiff.Name = "labelPowerDiff";
            this.labelPowerDiff.Size = new System.Drawing.Size(133, 16);
            this.labelPowerDiff.TabIndex = 21;
            this.labelPowerDiff.Text = "Difference in cost";
            // 
            // labelPowerNewYearly
            // 
            this.labelPowerNewYearly.AutoSize = true;
            this.labelPowerNewYearly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerNewYearly.Location = new System.Drawing.Point(13, 43);
            this.labelPowerNewYearly.Name = "labelPowerNewYearly";
            this.labelPowerNewYearly.Size = new System.Drawing.Size(176, 16);
            this.labelPowerNewYearly.TabIndex = 20;
            this.labelPowerNewYearly.Text = "New product yearly cost";
            // 
            // labelPowerOldYearly
            // 
            this.labelPowerOldYearly.AutoSize = true;
            this.labelPowerOldYearly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPowerOldYearly.Location = new System.Drawing.Point(13, 22);
            this.labelPowerOldYearly.Name = "labelPowerOldYearly";
            this.labelPowerOldYearly.Size = new System.Drawing.Size(170, 16);
            this.labelPowerOldYearly.TabIndex = 19;
            this.labelPowerOldYearly.Text = "Old product yearly cost";
            // 
            // labelCostPerKW
            // 
            this.labelCostPerKW.AutoSize = true;
            this.labelCostPerKW.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelCostPerKW.Location = new System.Drawing.Point(20, 223);
            this.labelCostPerKW.Name = "labelCostPerKW";
            this.labelCostPerKW.Size = new System.Drawing.Size(127, 16);
            this.labelCostPerKW.TabIndex = 16;
            this.labelCostPerKW.Text = "Cost per kiloWatt";
            // 
            // textBoxCostPerKW
            // 
            this.textBoxCostPerKW.Location = new System.Drawing.Point(153, 218);
            this.textBoxCostPerKW.Name = "textBoxCostPerKW";
            this.textBoxCostPerKW.Size = new System.Drawing.Size(81, 26);
            this.textBoxCostPerKW.TabIndex = 15;
            this.textBoxCostPerKW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxStandBy
            // 
            this.comboBoxStandBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStandBy.FormattingEnabled = true;
            this.comboBoxStandBy.Location = new System.Drawing.Point(347, 180);
            this.comboBoxStandBy.Name = "comboBoxStandBy";
            this.comboBoxStandBy.Size = new System.Drawing.Size(80, 27);
            this.comboBoxStandBy.TabIndex = 14;
            this.comboBoxStandBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxStandBy_SelectedIndexChanged);
            // 
            // labelProductUsed
            // 
            this.labelProductUsed.AutoSize = true;
            this.labelProductUsed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelProductUsed.Location = new System.Drawing.Point(22, 184);
            this.labelProductUsed.Name = "labelProductUsed";
            this.labelProductUsed.Size = new System.Drawing.Size(99, 16);
            this.labelProductUsed.TabIndex = 13;
            this.labelProductUsed.Text = "Used (hours)";
            // 
            // comboBoxUsed
            // 
            this.comboBoxUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsed.FormattingEnabled = true;
            this.comboBoxUsed.Location = new System.Drawing.Point(126, 180);
            this.comboBoxUsed.Name = "comboBoxUsed";
            this.comboBoxUsed.Size = new System.Drawing.Size(80, 27);
            this.comboBoxUsed.TabIndex = 12;
            this.comboBoxUsed.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsed_SelectedIndexChanged);
            // 
            // labelProductUsage
            // 
            this.labelProductUsage.AutoSize = true;
            this.labelProductUsage.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductUsage.Location = new System.Drawing.Point(20, 154);
            this.labelProductUsage.Name = "labelProductUsage";
            this.labelProductUsage.Size = new System.Drawing.Size(295, 18);
            this.labelProductUsage.TabIndex = 11;
            this.labelProductUsage.Text = "Product usage every day (approximately)";
            // 
            // textBoxNewStandBy
            // 
            this.textBoxNewStandBy.Location = new System.Drawing.Point(286, 120);
            this.textBoxNewStandBy.Name = "textBoxNewStandBy";
            this.textBoxNewStandBy.Size = new System.Drawing.Size(81, 26);
            this.textBoxNewStandBy.TabIndex = 10;
            this.textBoxNewStandBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelStandbyNew
            // 
            this.labelStandbyNew.AutoSize = true;
            this.labelStandbyNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelStandbyNew.Location = new System.Drawing.Point(211, 125);
            this.labelStandbyNew.Name = "labelStandbyNew";
            this.labelStandbyNew.Size = new System.Drawing.Size(69, 16);
            this.labelStandbyNew.TabIndex = 9;
            this.labelStandbyNew.Text = "Stand-by";
            // 
            // labelTurnOnNew
            // 
            this.labelTurnOnNew.AutoSize = true;
            this.labelTurnOnNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTurnOnNew.Location = new System.Drawing.Point(19, 125);
            this.labelTurnOnNew.Name = "labelTurnOnNew";
            this.labelTurnOnNew.Size = new System.Drawing.Size(79, 16);
            this.labelTurnOnNew.TabIndex = 8;
            this.labelTurnOnNew.Text = "Turned on";
            // 
            // textBoxNewTurnedOn
            // 
            this.textBoxNewTurnedOn.Location = new System.Drawing.Point(104, 120);
            this.textBoxNewTurnedOn.Name = "textBoxNewTurnedOn";
            this.textBoxNewTurnedOn.Size = new System.Drawing.Size(81, 26);
            this.textBoxNewTurnedOn.TabIndex = 7;
            this.textBoxNewTurnedOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOldStandBy
            // 
            this.textBoxOldStandBy.Location = new System.Drawing.Point(286, 58);
            this.textBoxOldStandBy.Name = "textBoxOldStandBy";
            this.textBoxOldStandBy.Size = new System.Drawing.Size(81, 26);
            this.textBoxOldStandBy.TabIndex = 6;
            this.textBoxOldStandBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelStandbyOld
            // 
            this.labelStandbyOld.AutoSize = true;
            this.labelStandbyOld.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelStandbyOld.Location = new System.Drawing.Point(211, 63);
            this.labelStandbyOld.Name = "labelStandbyOld";
            this.labelStandbyOld.Size = new System.Drawing.Size(69, 16);
            this.labelStandbyOld.TabIndex = 5;
            this.labelStandbyOld.Text = "Stand-by";
            // 
            // labelTurnedOnOld
            // 
            this.labelTurnedOnOld.AutoSize = true;
            this.labelTurnedOnOld.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTurnedOnOld.Location = new System.Drawing.Point(19, 63);
            this.labelTurnedOnOld.Name = "labelTurnedOnOld";
            this.labelTurnedOnOld.Size = new System.Drawing.Size(79, 16);
            this.labelTurnedOnOld.TabIndex = 4;
            this.labelTurnedOnOld.Text = "Turned on";
            // 
            // textBoxOldTurnedOn
            // 
            this.textBoxOldTurnedOn.Location = new System.Drawing.Point(104, 58);
            this.textBoxOldTurnedOn.Name = "textBoxOldTurnedOn";
            this.textBoxOldTurnedOn.Size = new System.Drawing.Size(81, 26);
            this.textBoxOldTurnedOn.TabIndex = 2;
            this.textBoxOldTurnedOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPowerNewWatt
            // 
            this.labelPowerNewWatt.AutoSize = true;
            this.labelPowerNewWatt.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPowerNewWatt.Location = new System.Drawing.Point(17, 94);
            this.labelPowerNewWatt.Name = "labelPowerNewWatt";
            this.labelPowerNewWatt.Size = new System.Drawing.Size(268, 18);
            this.labelPowerNewWatt.TabIndex = 1;
            this.labelPowerNewWatt.Text = "New product consumtion (watt/ hour)";
            // 
            // labelPowerOldWatt
            // 
            this.labelPowerOldWatt.AutoSize = true;
            this.labelPowerOldWatt.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPowerOldWatt.Location = new System.Drawing.Point(19, 32);
            this.labelPowerOldWatt.Name = "labelPowerOldWatt";
            this.labelPowerOldWatt.Size = new System.Drawing.Size(262, 18);
            this.labelPowerOldWatt.TabIndex = 0;
            this.labelPowerOldWatt.Text = "Old product consumtion (watt/ hour)";
            // 
            // boxBMR
            // 
            this.boxBMR.Controls.Add(this.labelSelected);
            this.boxBMR.Controls.Add(this.btnUnselect);
            this.boxBMR.Controls.Add(this.btnCalcBMR);
            this.boxBMR.Controls.Add(this.textBoxWeight);
            this.boxBMR.Controls.Add(this.labelWeight);
            this.boxBMR.Controls.Add(this.textBoxHeight);
            this.boxBMR.Controls.Add(this.labelHeight);
            this.boxBMR.Controls.Add(this.textBoxAge);
            this.boxBMR.Controls.Add(this.labelAge);
            this.boxBMR.Controls.Add(this.rbMale);
            this.boxBMR.Controls.Add(this.rbFemale);
            this.boxBMR.Controls.Add(this.listBoxBMR);
            this.boxBMR.Controls.Add(this.boxActivity);
            this.boxBMR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBMR.Location = new System.Drawing.Point(13, 386);
            this.boxBMR.Name = "boxBMR";
            this.boxBMR.Size = new System.Drawing.Size(895, 354);
            this.boxBMR.TabIndex = 2;
            this.boxBMR.TabStop = false;
            this.boxBMR.Text = "BMR";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSelected.Location = new System.Drawing.Point(302, 321);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(119, 21);
            this.labelSelected.TabIndex = 15;
            this.labelSelected.Text = "Selected item:";
            // 
            // btnUnselect
            // 
            this.btnUnselect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUnselect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.Location = new System.Drawing.Point(778, 321);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(105, 24);
            this.btnUnselect.TabIndex = 14;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnCalcBMR
            // 
            this.btnCalcBMR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcBMR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcBMR.Location = new System.Drawing.Point(68, 318);
            this.btnCalcBMR.Name = "btnCalcBMR";
            this.btnCalcBMR.Size = new System.Drawing.Size(159, 30);
            this.btnCalcBMR.TabIndex = 11;
            this.btnCalcBMR.Text = "Calculate";
            this.btnCalcBMR.UseVisualStyleBackColor = false;
            this.btnCalcBMR.Click += new System.EventHandler(this.btnCalcBMR_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(168, 123);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(112, 26);
            this.textBoxWeight.TabIndex = 13;
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(17, 127);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(88, 18);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Weight (kg)";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(168, 94);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(112, 26);
            this.textBoxHeight.TabIndex = 12;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(17, 98);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(89, 18);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height (cm)";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(168, 66);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(112, 26);
            this.textBoxAge.TabIndex = 11;
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(17, 70);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 18);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(135, 25);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 23);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(20, 26);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(82, 23);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // listBoxBMR
            // 
            this.listBoxBMR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBMR.FormattingEnabled = true;
            this.listBoxBMR.ItemHeight = 19;
            this.listBoxBMR.Location = new System.Drawing.Point(302, 26);
            this.listBoxBMR.Name = "listBoxBMR";
            this.listBoxBMR.Size = new System.Drawing.Size(581, 270);
            this.listBoxBMR.TabIndex = 1;
            this.listBoxBMR.SelectedIndexChanged += new System.EventHandler(this.listBoxBMR_SelectedIndexChanged);
            // 
            // boxActivity
            // 
            this.boxActivity.Controls.Add(this.rbActivity5);
            this.boxActivity.Controls.Add(this.rbActivity4);
            this.boxActivity.Controls.Add(this.rbActivity3);
            this.boxActivity.Controls.Add(this.rbActivity2);
            this.boxActivity.Controls.Add(this.rbActivity1);
            this.boxActivity.Location = new System.Drawing.Point(6, 155);
            this.boxActivity.Name = "boxActivity";
            this.boxActivity.Size = new System.Drawing.Size(274, 160);
            this.boxActivity.TabIndex = 0;
            this.boxActivity.TabStop = false;
            this.boxActivity.Text = "Activity level per week";
            // 
            // rbActivity5
            // 
            this.rbActivity5.AutoSize = true;
            this.rbActivity5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivity5.Location = new System.Drawing.Point(6, 129);
            this.rbActivity5.Name = "rbActivity5";
            this.rbActivity5.Size = new System.Drawing.Size(249, 20);
            this.rbActivity5.TabIndex = 18;
            this.rbActivity5.TabStop = true;
            this.rbActivity5.Text = "Extra active, hard excersises or job";
            this.rbActivity5.UseVisualStyleBackColor = true;
            this.rbActivity5.CheckedChanged += new System.EventHandler(this.rbActivity5_CheckedChanged);
            // 
            // rbActivity4
            // 
            this.rbActivity4.AutoSize = true;
            this.rbActivity4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivity4.Location = new System.Drawing.Point(6, 103);
            this.rbActivity4.Name = "rbActivity4";
            this.rbActivity4.Size = new System.Drawing.Size(180, 20);
            this.rbActivity4.TabIndex = 17;
            this.rbActivity4.TabStop = true;
            this.rbActivity4.Text = "Very active (6 to 7 times)";
            this.rbActivity4.UseVisualStyleBackColor = true;
            this.rbActivity4.CheckedChanged += new System.EventHandler(this.rbActivity4_CheckedChanged);
            // 
            // rbActivity3
            // 
            this.rbActivity3.AutoSize = true;
            this.rbActivity3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivity3.Location = new System.Drawing.Point(6, 77);
            this.rbActivity3.Name = "rbActivity3";
            this.rbActivity3.Size = new System.Drawing.Size(223, 20);
            this.rbActivity3.TabIndex = 16;
            this.rbActivity3.TabStop = true;
            this.rbActivity3.Text = "Moderately active (3 to 5 times)";
            this.rbActivity3.UseVisualStyleBackColor = true;
            this.rbActivity3.CheckedChanged += new System.EventHandler(this.rbActivity3_CheckedChanged);
            // 
            // rbActivity2
            // 
            this.rbActivity2.AutoSize = true;
            this.rbActivity2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivity2.Location = new System.Drawing.Point(6, 51);
            this.rbActivity2.Name = "rbActivity2";
            this.rbActivity2.Size = new System.Drawing.Size(195, 20);
            this.rbActivity2.TabIndex = 15;
            this.rbActivity2.TabStop = true;
            this.rbActivity2.Text = "Lightly active (1 to 3 times)";
            this.rbActivity2.UseVisualStyleBackColor = true;
            this.rbActivity2.CheckedChanged += new System.EventHandler(this.rbActivity2_CheckedChanged);
            // 
            // rbActivity1
            // 
            this.rbActivity1.AutoSize = true;
            this.rbActivity1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivity1.Location = new System.Drawing.Point(6, 25);
            this.rbActivity1.Name = "rbActivity1";
            this.rbActivity1.Size = new System.Drawing.Size(233, 20);
            this.rbActivity1.TabIndex = 14;
            this.rbActivity1.TabStop = true;
            this.rbActivity1.Text = "Sedentary (little or no excercise)";
            this.rbActivity1.UseVisualStyleBackColor = true;
            this.rbActivity1.CheckedChanged += new System.EventHandler(this.rbActivity1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 752);
            this.Controls.Add(this.boxBMR);
            this.Controls.Add(this.boxExtra);
            this.Controls.Add(this.boxFuel);
            this.Name = "MainForm";
            this.Text = "Calculators";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.boxFuel.ResumeLayout(false);
            this.boxFuel.PerformLayout();
            this.boxFuelRes.ResumeLayout(false);
            this.boxFuelRes.PerformLayout();
            this.boxExtra.ResumeLayout(false);
            this.boxExtra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.boxBMR.ResumeLayout(false);
            this.boxBMR.PerformLayout();
            this.boxActivity.ResumeLayout(false);
            this.boxActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxFuel;
        private System.Windows.Forms.GroupBox boxExtra;
        private System.Windows.Forms.GroupBox boxBMR;
        private System.Windows.Forms.Label labelPrevOdo;
        private System.Windows.Forms.GroupBox boxFuelRes;
        private System.Windows.Forms.GroupBox boxActivity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAmountFuel;
        private System.Windows.Forms.TextBox textBoxPrevOdo;
        private System.Windows.Forms.TextBox textBoxCurrentOdo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAmountFuel;
        private System.Windows.Forms.Label labelCurrentOdo;
        private System.Windows.Forms.Button btnCalcFuel;
        private System.Windows.Forms.Label labelFuelConsKmToLiter;
        private System.Windows.Forms.Label labelFuelResPrice;
        private System.Windows.Forms.Label labelFuelResLiterToSwe;
        private System.Windows.Forms.Label labelFuelResLiterToMetric;
        private System.Windows.Forms.Label labelFuelResLiterToKm;
        private System.Windows.Forms.Label labelFuelResKmToLiter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFuelConsLiterToSwe;
        private System.Windows.Forms.Label labelFuelConsLiterToMetric;
        private System.Windows.Forms.Label labelFuelConsLiterToKm;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ListBox listBoxBMR;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.RadioButton rbActivity5;
        private System.Windows.Forms.RadioButton rbActivity4;
        private System.Windows.Forms.RadioButton rbActivity3;
        private System.Windows.Forms.RadioButton rbActivity2;
        private System.Windows.Forms.RadioButton rbActivity1;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnCalcBMR;
        private System.Windows.Forms.Label labelPowerNewWatt;
        private System.Windows.Forms.Label labelPowerOldWatt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCostPerKW;
        private System.Windows.Forms.TextBox textBoxCostPerKW;
        private System.Windows.Forms.ComboBox comboBoxStandBy;
        private System.Windows.Forms.Label labelProductUsed;
        private System.Windows.Forms.ComboBox comboBoxUsed;
        private System.Windows.Forms.Label labelProductUsage;
        private System.Windows.Forms.TextBox textBoxNewStandBy;
        private System.Windows.Forms.Label labelStandbyNew;
        private System.Windows.Forms.Label labelTurnOnNew;
        private System.Windows.Forms.TextBox textBoxNewTurnedOn;
        private System.Windows.Forms.TextBox textBoxOldStandBy;
        private System.Windows.Forms.Label labelStandbyOld;
        private System.Windows.Forms.Label labelTurnedOnOld;
        private System.Windows.Forms.TextBox textBoxOldTurnedOn;
        private System.Windows.Forms.Label labelProductStandby;
        private System.Windows.Forms.Label labelPowerResDiff;
        private System.Windows.Forms.Label labelPowerResNew;
        private System.Windows.Forms.Label labelPowerResOld;
        private System.Windows.Forms.Label labelPowerDiff;
        private System.Windows.Forms.Label labelPowerNewYearly;
        private System.Windows.Forms.Label labelPowerOldYearly;
        private System.Windows.Forms.Button btnCalcPower;
    }
}

