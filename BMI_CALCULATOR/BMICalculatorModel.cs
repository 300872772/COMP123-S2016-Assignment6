using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
     * This is the BMICalculatorModel class for calculating BMI data.  
     * </summary>  
     *   
     * @class BMICalculatorModel  
     */
    public class BMICalculatorModel
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _calculationType;
        private double _myHeight;
        private double _myWeight;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property named CaculationType which carries value of _calculationType field
        * </summary>
        * 
        * @property {string} CaculationType 
        *
        * 
        */
        public string CalculationType
        {
            get
            {
                return this._calculationType;
            }

            set
            {
                this._calculationType = value;
            }
        }

        /**
        * <summary>
        * This is a property named MyHeight which carries value of _myHeight field
        * </summary>
        * 
        * @property {string} MyHeight 
        *
        * 
        */
        public double MyHeight
        {
            get
            {
                return this._myHeight;
            }

            set
            {
                this._myHeight = value;
            }
        }

        /**
         * <summary>
         * This is a property named MyWeight which carries value of _myWeight field
         * </summary>
         * 
         * @property {string} MyWeight 
         *
         * 
         */
        public double MyWeight
        {
            get
            {
               return this._myWeight;
            }

            set
            {
                this._myWeight = value;
            }
        }

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor BMICalculatorModel that initialize value of properties.
        * </summary>
        * 
        * @constructor BMICalculatorModel 
        * 
        */
        public BMICalculatorModel()
        {
            this.MyWeight = 0;
            this.MyHeight = 0;
            this.CalculationType = "Metric";
        }

        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the privte method _bmiCalculation which calculate BMI Value
        * </summary>
        * 
        * @method _bmiCalculation
        * @returns {double} 
        * 
        */
        private double _bmiCalculation()
        {
            double BMIValue = 0;

            if (this.CalculationType == "Metric")
            {
                BMIValue = (this.MyWeight / ((this.MyHeight / 100) * (this.MyHeight / 100)));

            }
            else if (this.CalculationType == "Imperial")
            {
                BMIValue = ((this.MyWeight * 703) / (this.MyHeight * this.MyHeight / 100));
            }

            return BMIValue;
        }

        /**
         * <summary>
         * This is the public method BMIScale which return BMI scale value
         * </summary>
         * 
         * @method _bmiCalculation
         * @returns {string} 
         * 
         */
        public string BMIScale()
        {
            double BMIValue = _bmiCalculation();
            string BMIScale = "";
            if (BMIValue<18.5)
            {
                BMIScale = "Underweight";
            }
            else if(BMIValue>=18.5 && BMIValue <=24.9)
            {
                BMIScale = "Normal";
            }
            else if (BMIValue >= 25 && BMIValue <= 29.9)
            {
                BMIScale = "Overwight";
            }
            else if (BMIValue >= 30)
            {
                BMIScale = "Obese";
            }

            return BMIScale;
        }

        /**
         * <summary>
         * This is the public method BMIResult which return BMI result
         * </summary>
         * 
         * @method BMIResult
         * @returns {double} 
         * 
         */
        public string BMIResult()
        {
            double BMIValue = _bmiCalculation();
            string BMIResult = "";
            if (BMIValue < 18.5)
            {
                BMIResult = "Less than 18.5";
            }
            else if (BMIValue >= 18.5 && BMIValue <= 24.9)
            {
                BMIResult = "Between 18.5 and 24.9";
            }
            else if (BMIValue >= 25 && BMIValue <= 29.9)
            {
                BMIResult = "Between 25 and 29.9";
            }
            else if (BMIValue >= 30)
            {
                BMIResult = "30 or greater";
            }

            return BMIResult;
        }
    }
}