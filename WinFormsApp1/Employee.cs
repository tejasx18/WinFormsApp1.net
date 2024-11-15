using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double basicSalary = Convert.ToDouble(txtBasicSalary.Text);
            double HRA = basicSalary * 0.4;
            txtHRA.Text = HRA.ToString();
            double DA = basicSalary * 0.3;
            txtDA.Text = DA.ToString();
            double TA = basicSalary * 0.2;
            txtTA.Text = TA.ToString();
            double PF = basicSalary * 0.12;
            txtPF.Text = PF.ToString();
            double grosssalary = HRA+DA+TA+PF-200;
            txtGrossSalary.Text = grosssalary.ToString();

        }
    }
}
