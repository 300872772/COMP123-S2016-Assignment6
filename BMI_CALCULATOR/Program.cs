using System;
using System.Collections.Generic;
using System.Linq;
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
     * This is the driver class for running starting form.  
     * </summary>  
     *   
     * @class Program  
     */

    static class Program
    {
        //MAIN MATHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        /** 
        * <summary> 
        * The main method for driver class Program 
        * </summary> 
        * @method Main  
        * @returns {void} 
        */

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
