using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMI_CALCULATOR
{
    public class BMICalculatorModel
    {
        private string _calculationType;
        private double _myHeight;
        private double _myWeight;

        public BMICalculatorModel()
        {
            this.MyWeight = 0;
            this.MyHeight = 0;
            this.CalculationType = "Metric";
        }

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