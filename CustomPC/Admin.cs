using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public partial class Admin : Form
    {
        CPUStorage cpuStorage = new CPUStorage();
        MBStorage mbStorage = new MBStorage();

        public Admin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCpu_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewCPU.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelNewCPU.Hide();
        }

        private void btnConfirmCPU_Click(object sender, EventArgs e)
        {
            cpuStorage.Add(new CPU(productName.Text, socketBox.Text, 0, 0));
            productName.Text = "";
            socketBox.Text = "";
            panelNewCPU.Hide();
        }
    }
}
