using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 /*   
 *Author: Md Mamunur Rahman   
 * Student ID: 300872772    
 *   
 * Date last modified: July 26, 2016   
 * Description: This program calculate Body Mass Index(BMI)    
 *    
 * Version: 0.0.1 - added form properties  
 */ 

namespace BMI_CALCULATOR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
