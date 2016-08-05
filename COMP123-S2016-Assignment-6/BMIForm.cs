using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment_6
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            double height;
            double weight;
            double bmi;

            
            try
            {
                if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
                {                   
                    MessageBox.Show("Fields can not be empty, please fill it out");

                    if ((HeightTextBox.Text == "") || (HeightTextBox.Text == "" && WeightTextBox.Text == ""))
                    {
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Focus();
                    }
                        
                }

                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                if ((height <= 0 || weight <= 0) || (height <= 0) || (weight <= 0))
                {
                    MessageBox.Show("Numbers can not be less or equal to 0");

                    if ((height <= 0) || (height <= 0 && weight <= 0))
                    {
                        HeightTextBox.Clear();
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Clear();
                        WeightTextBox.Focus();
                    }

                }

                else {

                    if (ImperialRadioButton.Checked == true)
                    {
                        bmi = ((weight * 703)) / ((height * height));
                        ResultTextBox.Text = Convert.ToString(bmi);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (bmi < 18.5)
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((bmi > 18.5) && (bmi < 24.9))
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((bmi > 25) && (bmi < 29.9))
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (bmi > 30)
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Obese");
                        }

                    }

                    if (MetricRadioButton.Checked == true)
                    {
                        bmi = (weight / (height * height));
                        ResultTextBox.Text = Convert.ToString(bmi);
                        HeightTextBox.Enabled = false;
                        WeightTextBox.Enabled = false;

                        if (bmi < 18.5)
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Underweight");
                        }

                        if ((bmi > 18.5) && (bmi < 24.9))
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Normal");
                        }

                        if ((bmi > 25) && (bmi < 29.9))
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Overweight");
                        }

                        if (bmi > 30)
                        {
                            ResultInfoTextBox.Text = Convert.ToString("Obese");
                        }
                    }




                }
            }
            catch (Exception)
            {
                MessageBox.Show("Press OK to continue");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            //CLEAR
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            ResultTextBox.Text = "";
            ResultInfoTextBox.Clear();

            //ENABLE TEXTBOXES
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }
    }
}
