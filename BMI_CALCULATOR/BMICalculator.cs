using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*   
*Author: Md Mamunur Rahman   
* Student ID: 300872772    
*   
* Date last modified: July 29, 2016   
* Description: This program calculates Body Mass Index(BMI)    
*    
* Version: 0.0.4 - added all comments  
*/
namespace BMI_CALCULATOR
{
    /**  
     * <summary>  
     * This is the partial BMICalculator class for running BMICalculator form.  
     * </summary>  
     *   
     * @class Splash  
     */
    public partial class BMICalculator : Form
    {
        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property named CaculationType
        * </summary>
        * 
        * @property {string} CaculationType 
        *
        * 
        */

        public string CaculationType { get; set; }

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that calls system generated method inside and initialize value.
        * </summary>
        * 
        * @constructor BMICalculator 
        * 
        */

        public BMICalculator()
        {
            InitializeComponent();
            this.CaculationType = MetricRadioButton.Text;
        }


        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the privte method for CheckedChanged event of MetricRadioButton
        * </summary>
        * 
        * @method MetricRadioButton_CheckedChanged
        * @returns {void} 
        * 
        */

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height cm";
            MyWightLabel.Text = "My Weight kg";
            this.CaculationType = MetricRadioButton.Text;
        }
        /**
       * <summary>
       * This is the privte method for CheckedChanged event of ImperialRadioButton
       * </summary>
       * 
       * @method ImperialRadioButton_CheckedChanged
       * @returns {void} 
       * 
       */

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height inch";
            MyWightLabel.Text = "My Weight pound";
            this.CaculationType = ImperialRadioButton.Text;
        }
        /**
       * <summary>
       * This is the privte method for KeyPress event of HeightInputTextBox
       * </summary>
       * 
       * @method HeightInputTextBox_KeyPress
       * @returns {void} 
       * 
       */

        private void HeightInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }
        /**
         * <summary>
         * This is the privte method for KeyPress event of WeightInputTextBox
         * </summary>
         * 
         * @method WeightInputTextBox_KeyPress
         * @returns {void} 
         * 
         */
        private void WeightInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            BMIOutputTextBox.Text = "";
            BMIResultTextBox.Text = "";

            BMICalculatorModel bmiCalculator = new BMICalculatorModel();
            bmiCalculator.MyHeight = Convert.ToDouble(HeightInputTextBox.Text);
            bmiCalculator.MyWeight = Convert.ToDouble(WeightInputTextBox.Text);
            bmiCalculator.CalculationType = this.CaculationType;

            BMIOutputTextBox.Text = bmiCalculator.BMIScale();
            BMIResultTextBox.Text = bmiCalculator.BMIResult();


        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
        /**
        * <summary>
        * This is the privte method for Click event of ExitButton_Click
        * </summary>
        * 
        * @method ExitButton_Click
        * @returns {void} 
        * 
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BMIOutputTextBox.Text = "";
            BMIResultTextBox.Text = "";
            HeightInputTextBox.Text = "";
            WeightInputTextBox.Text = "";
            this.CaculationType = MetricRadioButton.Text;
            MetricRadioButton.Checked = true;
        }
    }
}
