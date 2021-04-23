using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Exercise
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HrsWorkedIn.Text=="" || HrRateIn.Text=="")
            {
                HrsWorkedIn.Text = "0";
                HrRateIn.Text = "0";
            }
             
            double HrsWk = Convert.ToDouble(HrsWorkedIn.Text);
            double HrRt = Convert.ToDouble(HrRateIn.Text);

            if (HrsWk <= 37.5)
            {
                OvertimeP.Text = "";
                RegularP.Text = "";
                TotalP.Text = Math.Round((HrsWk*HrRt),2).ToString();
            }
            else
            {
                OvertimeP.Text = Math.Round(((HrsWk - 37.5) * 1.5 * HrRt),2).ToString();
                RegularP.Text = Math.Round((37.5 * HrRt),2).ToString();
                TotalP.Text = Math.Round(((HrsWk - 37.5) * 1.5 * HrRt + 37.5* HrRt),2).ToString();
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
