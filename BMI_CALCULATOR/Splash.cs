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
* Date last modified: July 28, 2016   
* Description: This program calculates Body Mass Index(BMI)    
*    
* Version: 0.0.4 - added all comments   
*/
namespace BMI_CALCULATOR
{
    /**  
     * <summary>  
     * This is the partial Splash class for running Splash form.  
     * </summary>  
     *   
     * @class Splash  
     */
    public partial class Splash : Form
    {
        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that calls system generated method inside.
        * </summary>
        * 
        * @constructor Splash 
        * 
        */

        public Splash()
        {
            InitializeComponent();
        }

        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a privte method that handles looping and intervel of timer
        * </summary>
        * 
        * @method SplashTimer_Tick
        * @returns {void}
        * 
        */

        private void SplashTimer_Tick(object sender, EventArgs e)
        {

            SplashProgressBar.PerformStep();
            if (SplashProgressBar.Value >= SplashProgressBar.Maximum)
            {
                SplashTimer.Enabled = false;

                this.Hide();
                BMICalculator bmiCalculator = new BMICalculator();
                bmiCalculator.ShowDialog();
                this.Close();

            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
