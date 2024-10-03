using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(weight_txt.Text);
                double height = double.Parse(height_txt.Text);
                double body_index = Math.Round(weight / Math.Pow(height, 2), 2);

                if (body_index < 18.5)
                    answer_lbl.Text = $"{body_index}\n Status: Underweight";
                else if (body_index > 25)
                    answer_lbl.Text = $"{body_index}\n Status: Overweight";
                else
                    answer_lbl.Text = $"{body_index}\n Status: Optimal weight";
            }
            catch
            {
                answer_lbl.Text = "Invalid input. Please enter numeric values for weight and height.";
            }
        

        }
    }
}
