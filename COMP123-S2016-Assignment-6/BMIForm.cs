using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Assignment #6
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 08.05.2016
 * Submitted to : Tom Tsiliopoulos
 * GitHub link : https://github.com/mirsakiyev/COMP123-S2016_Assignment-6
 *
 */
namespace COMP123_S2016_Assignment_6
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        // SUBMIT BUTTON
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //initialize variables
            double height;
            double weight;
            double bmi;

            // try catch block
            try
            {
                // Fields cannot be empty, checking it
                if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
                {                   
                    MessageBox.Show("Fields can not be empty, please fill them out");

                    if ((HeightTextBox.Text == "") || (HeightTextBox.Text == "" && WeightTextBox.Text == ""))
                    {
                        HeightTextBox.Focus();
                    }
                    else
                    {
                        WeightTextBox.Focus();
                    }                    
                }

                try
                {
                    height = Convert.ToDouble(HeightTextBox.Text);
                    weight = Convert.ToDouble(WeightTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please type numbers");
                    HeightTextBox.Clear();
                    WeightTextBox.Clear();
                    HeightTextBox.Focus();
                }

                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                // checking for a 0 or less than 0 values
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

                    // if imperial radio button ENABLED -> 
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

                    // if metric radio button ENABLED -> 
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

        // CLEAR BUTTON
        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            //clear fields
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            ResultTextBox.Clear();
            ResultInfoTextBox.Clear();

          
            //enable textboxes 
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }

        // LINK LABEL
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
            this.linkLabel.LinkVisited = true;           
            System.Diagnostics.Process.Start("https://github.com/mirsakiyev");
        }

        // EXIT BUTTON
        private void ExitButton_Click(object sender, EventArgs e)
        {           
            Environment.Exit(1);
        }
      
    }
}
