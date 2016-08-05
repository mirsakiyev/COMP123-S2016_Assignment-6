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
                    HeightTextBox.Focus();
                    HeightTextBox.SelectAll();
                }

                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("Fields can not be equal or less than 0");
                    HeightTextBox.Focus();
                    HeightTextBox.SelectAll();
                }





            }
            catch (Exception)
            {
                MessageBox.Show("Error. Press OK to continue");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            //CLEAR
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            ResultTextBox.Text = "";

            //ENABLE TEXTBOXES
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }
    }
}
