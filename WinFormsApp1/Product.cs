using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WinFormsApp1
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream sw = new FileStream(@"D:\Dotnet\product.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(sw);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToInt32(txtPrice.Text));
                bw.Close();
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Dotnet\product.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPrice.Text = br.ReadInt32().ToString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
