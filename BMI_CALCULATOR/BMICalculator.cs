using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_CALCULATOR
{
    public partial class BMICalculator : Form
    {
        public string CaculationType { get; set; }
        public BMICalculator()
        {
            InitializeComponent();
            this.CaculationType = MetricRadioButton.Text;
        }

 

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height cm";
            MyWightLabel.Text = "My Weight kg";
            this.CaculationType = MetricRadioButton.Text;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height inch";
            MyWightLabel.Text = "My Weight pound";
            this.CaculationType = ImperialRadioButton.Text;
        }

        private void HeightInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void WeightInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            BMICalculatorModel bmiCalculator = new BMICalculatorModel();
            bmiCalculator.MyHeight =Convert.ToDouble(HeightInputTextBox.Text);
            bmiCalculator.MyWeight = Convert.ToDouble(WeightInputTextBox.Text);

            BMIOutputTextBox.Text = bmiCalculator.BMIScale();
            BMIResultTextBox.Text = bmiCalculator.BMIResult();
        }

        private double _bmiResult()
        {
            return 0;
        }

        private double _bmiScale()
        {
            return 0;
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            BMIOutputTextBox.ForeColor = BMIOutputTextBox.ForeColor;
        }
    }
}
