using System;
using System.Windows.Forms;
// For Bianry serialization
using System.Runtime.Serialization.Formatters.Binary;
// for xml serialization
using System.Xml.Serialization;
//for soap
using System.Runtime.Serialization.Formatters.Soap;
//for JSON
using System.Text.Json;
using System.IO;

namespace WinFormsApp1
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void btnBinaryW_Click(object sender, EventArgs e)
        {
            try
            {
#pragma warning disable SYSLIB0011
                FileStream fs = new FileStream(@"D:\Dotnet\BinaryEmployee.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                Employee1 emp = new Employee1();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                bf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryR_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\BinaryEmployee.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Employee1 emp = new Employee1();
                emp = (Employee1)bf.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtSalary.Text = emp.Salary.ToString();
                txtName.Text = emp.Name;
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLW_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\XMLEmployee.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee1));
                Employee1 emp = new Employee1();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                xs.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLR_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\XMLEmployee.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee1));
                Employee1 emp = new Employee1();
                emp = (Employee1)xs.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtSalary.Text = emp.Salary.ToString();
                txtName.Text = emp.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPW_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\SOAPEmployee.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                Employee1 emp = new Employee1();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                sf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPR_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\SOAPEmployee.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Employee1 emp = new Employee1();
                emp = (Employee1)sf.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtSalary.Text = emp.Salary.ToString();
                txtName.Text = emp.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONW_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\JSONEmployee.json", FileMode.Create, FileAccess.Write);
                Employee1 emp = new Employee1();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                JsonSerializer.Serialize<Employee1>(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONR_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\JSONEmployee.json", FileMode.Open, FileAccess.Read);
                Employee1 emp = new Employee1();
                emp = JsonSerializer.Deserialize<Employee1>(fs);
                txtId.Text = emp.Id.ToString();
                txtSalary.Text = emp.Salary.ToString();
                txtName.Text = emp.Name;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtSalary.Clear();
            txtName.Clear();
        }
    }
}
