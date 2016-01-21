/////////////////////////////////////////////
// Mainform.cs                             //
// Created by: Markus Lidrot, 2015-10-24   //
/////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// The class controlls the GUI. Three differnt calculators are used
    /// and they all exist as independent classes whitout knowledge of this class.  
    /// User input and output is handled by this class.
    /// </summary>
    public partial class MainForm : Form
    {
        //Declare and create an instance of the FuelCalculator
        private FuelCalculator carMilage = new FuelCalculator();

        //Declare and create an instance of the CalorieCalculator
        private CalorieCalculator bmrCalc = new CalorieCalculator();

        //Declare and create an instance of the PowerConsumtion
        private PowerConsumtion powerCons = new PowerConsumtion();

        /// <summary>
        /// The constructor for this class. It initialzes all components and the GUI.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            IntitializeGUI();
        }

        /// <summary>
        /// Makes sure all textboxes, labels and the listbox are empty at start and that
        /// comboboxes are set to the value 0 and the radiobuttons are activated. 
        /// </summary>
        private void IntitializeGUI()
        {
            //Intialize FuelBox components
            textBoxCurrentOdo.Text = String.Empty;
            textBoxPrevOdo.Text = String.Empty;
            textBoxAmountFuel.Text = String.Empty;
            textBoxPrice.Text = String.Empty;
            //Intialize FuelBox result components
            clearFuel();
            //Intialize BMRBox components
            rbFemale.Checked = true;
            textBoxAge.Text = String.Empty;
            textBoxHeight.Text = String.Empty;
            textBoxWeight.Text = String.Empty;
            rbActivity1.Checked = true;
            clearBMR();
            //Intialize Power consumtion cost components
            textBoxOldTurnedOn.Text = String.Empty;
            textBoxOldStandBy.Text = String.Empty;
            textBoxNewTurnedOn.Text = String.Empty;
            textBoxNewStandBy.Text = String.Empty;
            textBoxCostPerKW.Text = String.Empty;
            clearPower();
            fillComboBoxes();

        }

        /// <summary>
        /// Method is used to clear the fuel result labels
        /// </summary>
        private void clearFuel()
        {
            labelFuelResKmToLiter.Text = String.Empty;
            labelFuelResLiterToKm.Text = String.Empty;
            labelFuelResLiterToMetric.Text = String.Empty;
            labelFuelResLiterToSwe.Text = String.Empty;
            labelFuelResPrice.Text = String.Empty;
        }

        /// <summary>
        /// Method is used to clear the BMR listbx
        /// </summary>
        private void clearBMR()
        {
            listBoxBMR.Items.Clear();
        }

        /// <summary>
        /// Method is used to clear the power consumtion result labels
        /// </summary>
        private void clearPower()
        {
            labelPowerResOld.Text = String.Empty;
            labelPowerResNew.Text = String.Empty;
            labelPowerResDiff.Text = String.Empty;
        }

        /// <summary>
        /// The method is used to read user input for the fuel calculator and check if the input is correct
        /// If it's not the user get's an error message with specifik information
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputFuel()
        {
            if (!ReadCurrReading())
            {
                showError("Not a valid current odometer reading input." +
                " It must be a number.\nBe sure to use the correct decimal sign ( , or .)",
                "Current odometer reading");
                return false;
            }

            if (!ReadPrevReading())
            {
                showError("Not a valid previous odometer reading input." +
                " It must be a number.\nBe sure to use the correct decimal sign ( , or .)",
                "Prevoius odometer reading");
                return false;
            }

            if (!ReadFuelAmount())
            {
                showError("Not a valid fuel amount input. It must be an number." +
                "\nBe sure to use the correct decimal sign ( , or .)",
                "Fuel amount");
                return false;
            }

            if (!ReadUnitPrice())
            {
                showError("Not a valid price input. Price must be an number." +
                "\nBe sure to use the correct decimal sign ( , or .)",
                "Price per liter");
                return false;
            }

            if (!carMilage.ValidateOdometerValue())
            {
                showError("Previous odometer reading can't be higher or equal to current odometer reading!",
                "Previous odometer reading");
                return false;
            }

            if(!carMilage.noNegativeValues())
            {
                showError("All values must be positive or zero, except for 'Amount of fuel' that must be positive." , "Fuel calculation");
                return false;
            }

            return true;
        }

        /// <summary>
        /// The method is used to read user input for the BMR calculator and check if the input is correct
        /// If it's not the user get's an error message with specifik information
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputBMR()
        {
            if (!ReadInputAge())
            {
                showError("Not a valid age input. Age must be an integer.", "Age");
                return false;
            }
            if (!ReadInputHeight())
            {
                showError("Not a valid height input. Height must be an number.\nBe sure to use the correct decimal sign ( , or .)",
                "Height");
                return false;
            }
            if (!ReadInputWeight())
            {
                showError("Not a valid weight input. Weight must be an number.\nBe sure to use the correct decimal sign ( , or .)",
                "Weight");
                return false;
            }
            if (!bmrCalc.noNegativeValues())
            {
                showError("All values must be positive or zero. No negative values allowed!", "BMR calculation");
                return false;
            }

            return true;
        }

        /// <summary>
        /// The method is used to read user input for the power consumtion calculator and check if the input is correct
        /// If it's not the user get's an error message with specifik information
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputPower()
        {
            if (!ReadOldTurnedOn())
            {
                showError("Not a valid input for Old product consumtion: Turned on." +
                "\nIt must be an integer!",
                "Old product consumtion: Turned on");
                return false;
            }

            if (!ReadOldStandby())
            {
                showError("Not a valid input for Old product consumtion: Stand-by." +
                "\nIt must be an integer!",
                "Old product consumtion: Stand-by");
                return false;
            }

            if (!ReadNewTurnedOn())
            {
                showError("Not a valid input for New product consumtion: Turned on." +
                "\nIt must be an integer!",
                "New product consumtion: Turned on");
                return false;
            }

            if (!ReadNewStandby())
            {
                showError("Not a valid input for New product consumtion: Stand-by." +
                "\nIt must be an integer!",
                "New product consumtion: Stand-by");
                return false;
            }

            if (!ReadCostPerKW())
            {
                showError("Not a valid price input. Cost must be an number." +
                "\nBe sure to use the correct decimal sign ( , or .)",
                "Cost per kW");
                return false;
            }

            if (!powerCons.noNegativeValues())
            {
                showError("All values must be positive or zero. No negative values allowed!", "Power consumtion cost");
                return false;
            }

            if (!powerCons.hourCount())
            {
                showError("The combined time can only be 24 hours.", "Product usage every day");
                return false;
            }

            return true;
        }

        /// <summary>
        /// The method tries to parse user input from textBoxCurrentOdo.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadCurrReading()
        {
            double value = 0;
            if (double.TryParse(textBoxCurrentOdo.Text, out value))
            {
                carMilage.SetCurrentReading(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxPrevOdo.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadPrevReading()
        {
            double value = 0;
            if (double.TryParse(textBoxPrevOdo.Text, out value))
            {
                carMilage.SetPreviousReading(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxAmountFuel.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadFuelAmount()
        {
            double value = 0;
            if (double.TryParse(textBoxAmountFuel.Text, out value))
            {
                carMilage.SetFuelAmount(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxPrice.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadUnitPrice()
        {
            double value = 0;
            if (double.TryParse(textBoxPrice.Text, out value))
            {
                carMilage.SetUnitPrice(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxAge.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputAge()
        {
            int value = 0;
            if (int.TryParse(textBoxAge.Text, out value))
            {
                bmrCalc.SetAge(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxHeight.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputHeight()
        {
            double value = 0;
            if (double.TryParse(textBoxHeight.Text, out value))
            {
                bmrCalc.SetHeight(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxWeight.
        /// If succesful it uses set method in the FuelCalculator objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadInputWeight()
        {
            double value = 0;
            if (double.TryParse(textBoxWeight.Text, out value))
            {
                bmrCalc.SetWeight(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxOldTurnedOn.
        /// If succesful it uses set method in the PowerConsumtion objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadOldTurnedOn()
        {
            int value = 0;
            if (int.TryParse(textBoxOldTurnedOn.Text, out value))
            {
                powerCons.setOldConsumptionOn(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxOldStandBy.
        /// If succesful it uses set method in the PowerConsumtion objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadOldStandby()
        {
            int value = 0;
            if (int.TryParse(textBoxOldStandBy.Text, out value))
            {
                powerCons.setOldConsumptionStandby(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxNewTurnedOn.
        /// If succesful it uses set method in the PowerConsumtion objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadNewTurnedOn()
        {
            int value = 0;
            if (int.TryParse(textBoxNewTurnedOn.Text, out value))
            {
                powerCons.setNewConsumptionOn(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxNewStandBy.
        /// If succesful it uses set method in the PowerConsumtion objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadNewStandby()
        {
            int value = 0;
            if (int.TryParse(textBoxNewStandBy.Text, out value))
            {
                powerCons.setNewConsumptionStandby(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method tries to parse user input from textBoxOldTurnedOn.
        /// If succesful it uses set method in the PowerConsumtion objekt to give
        /// one of the objekts instance variable a new value.
        /// </summary>
        /// <returns>A boolean</returns>
        private bool ReadCostPerKW()
        {
            double value = 0;
            if (double.TryParse(textBoxCostPerKW.Text, out value))
            {
                powerCons.setCost(value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method is used to print lines in the listBox with values calculated
        /// by the CalorieCalculator objekt.
        /// </summary>
        private void UpdateGUIBMR()
        {
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Your BMR (calories/ day)", bmrCalc.CalcBasMetabolicRateBMR()));
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Calories to maintain your weight)", bmrCalc.MaintainWeightCalories()));
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Calories to lose 0,5 kg per week", bmrCalc.LoseOrGainWeightCalories(0.5, true)));
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Calories to lose 1 kg per week", bmrCalc.LoseOrGainWeightCalories(1, true)));
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Calories to gain 0,5 kg per week", bmrCalc.LoseOrGainWeightCalories(0.5, false)));
            listBoxBMR.Items.Add(String.Format("{0,-50}{1,-7:0.0}", "Calories to gain 1 kg per week", bmrCalc.LoseOrGainWeightCalories(1, false)));
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add("Losing more than a 1000 calories a day is to be avoided!");
        }

        /// <summary>
        /// The method is used to add values to the Fuel result labels from calculations
        /// made by the FuelCalculator objekt. 
        /// </summary>
        private void UpdateGUIFuel()
        {
            labelFuelResKmToLiter.Text     = String.Format("{0:0.00}", carMilage.CalcConsumtionKilometerPerLiter());
            labelFuelResLiterToKm.Text     = String.Format("{0:0.00}", carMilage.CalcFuelConsumtionPerKm());
            labelFuelResLiterToMetric.Text = String.Format("{0:0.00}", carMilage.CalcConsumtionPerMetric());
            labelFuelResLiterToSwe.Text    = String.Format("{0:0.00}", carMilage.CalcFuelConsumtionPerSweMile());
            labelFuelResPrice.Text         = String.Format("{0:0.00}", carMilage.CalcCostPerKm());
        }

        /// <summary>
        /// The method is used to add values to the Power Consumtion result labels from calculations
        /// made by the PowerConsumtion objekt. 
        /// </summary>
        private void UpdateGUIPower()
        {
            labelPowerResOld.Text = String.Format("{0:0.00}", powerCons.oldProductYearlyCost());
            labelPowerResNew.Text = String.Format("{0:0.00}", powerCons.newProductYearlyCost());
            labelPowerResDiff.Text = String.Format("{0:0.00}", powerCons.differenceCost());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// If "Male" is selected the gender variable in CalorieCalculator objekt
        /// is set to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetGender(false);
        }

        /// <summary>
        /// If "Female" is selected the gender variable in CalorieCalculator objekt
        /// is set to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetGender(true);
        }

        /// <summary>
        /// Refers to the calculate button in Fuel calculator box.
        /// When pushed it initiates an if/else that calles the ReadInputFuel method.
        /// If it returns true the method UpdateGUIFuel is called and the result is presented.
        /// But if ReadInputFuel is false the result is not presented and the labels are cleared. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcFuel_Click(object sender, EventArgs e)
        {
            if (ReadInputFuel())
            {
                UpdateGUIFuel();
            }
            else
            {
                clearFuel();
            }
        }

        /// <summary>
        /// Refers to the calculate button in BMR calculator box.
        /// When pushed it initiates an if/else that calles the ReadInputBMR method.
        /// If it returns true the method UpdateGUIBMR is called and the result is presented.
        /// But if ReadInputBMR is false the result is not presented and the labels are cleared. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {
            if(ReadInputBMR())
            {
                clearBMR();
                UpdateGUIBMR();
            }
            else
            {
                clearBMR();
            }
        }

        /// <summary>
        /// Refers to the calculate button in Power consumtion calculator box.
        /// When pushed it initiates an if/else that calles the ReadInputPower method.
        /// If it returns true the method UpdateGUIPower is called and the result is presented.
        /// But if ReadInputPower is false the result is not presented and the labels are cleared. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcPower_Click(object sender, EventArgs e)
        {
            if (ReadInputPower())
            {
                UpdateGUIPower();
            }
            else
            {
                clearPower();
            }
        }

        /// <summary>
        /// The method is used to fill the comboBoxes used with the values 0-24.
        /// </summary>
        private void fillComboBoxes()
        {
            for (int i = 0; i < 25; i++)
            {
                comboBoxUsed.Items.Add(i);
                comboBoxStandBy.Items.Add(i);
            }
            comboBoxUsed.SelectedIndex = 0;
            comboBoxStandBy.SelectedIndex = 0;
        }

        /// <summary>
        /// The method is used to create a warning message popup. It takes to parameters
        /// and use adds them to the popup.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private void showError(string first, string second)
        {
            MessageBox.Show(first, "Error: " + second, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// When the unselect button is pushed the selected row in the listBox
        /// is removed. It the updates the label labelSelected to the default value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            listBoxBMR.Items.Remove(listBoxBMR.SelectedItem);
            labelSelected.Text = "Selected item:";
        }

        /// <summary>
        /// ActivityLevel variable in the FuelCalculator objekt is set to 0;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActivity1_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(0);
        }

        /// <summary>
        /// ActivityLevel variable in the FuelCalculator objekt is set to 1;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActivity2_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(1);
        }

        /// <summary>
        /// ActivityLevel variable in the FuelCalculator objekt is set to 2;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActivity3_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(2);
        }

        /// <summary>
        /// ActivityLevel variable in the FuelCalculator objekt is set to 3;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActivity4_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(3);
        }

        /// <summary>
        /// ActivityLevel variable in the FuelCalculator objekt is set to 4;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActivity5_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.SetActivityLevel(4);
        }

        /// <summary>
        /// Updates the labelSelcted label when a row i selected in the listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxBMR_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelected.Text = "Selected item: " + listBoxBMR.SelectedIndex;
        }

        /// <summary>
        /// When a value is selected in the comboBox comboBoxUsed the value is
        /// saved to the correlating instance variable in the PowerConsumtion objekt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(comboBoxUsed.Text);
            powerCons.setUsageOn(i);
        }

        /// <summary>
        /// When a value is selected in the comboBox comboBoxStandBy the value is
        /// saved to the correlating instance variable in the PowerConsumtion objekt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStandBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = int.Parse(comboBoxStandBy.Text);
            powerCons.setUsageStandby(i);
        }
    }
}
