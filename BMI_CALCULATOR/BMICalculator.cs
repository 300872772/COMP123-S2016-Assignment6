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
        public string CalculatorState { get; set; }
        public BMICalculator()
        {
            InitializeComponent();
            this.CalculatorState = MetricRadioButton.Text;
        }

 

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height cm";
            MyWightLabel.Text = "My Weight kg";
            this.CalculatorState = MetricRadioButton.Text;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height inch";
            MyWightLabel.Text = "My Weight pound";
            this.CalculatorState = ImperialRadioButton.Text;
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
            if (this.CalculatorState==MetricRadioButton.Text)
            {
                MessageBox.Show(MetricRadioButton.Text);
            }

            if (this.CalculatorState == ImperialRadioButton.Text)
            {
                MessageBox.Show(ImperialRadioButton.Text);
            }
        }

        private double _bmiResult()
        {
            return 0;
        }

        private double _bmiScale()
        {
            return 0;
        }
    }
}
