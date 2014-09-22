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
        GPUStorage gpuStorage = new GPUStorage();
        RAMStorage ramStorage = new RAMStorage();
        HDDStorage hddStorage = new HDDStorage();

        public Admin()
        {
            InitializeComponent();
            var cpuSockets = cpuStorage.GetAvailableSockets().ToArray();
            mbCPU.Items.AddRange(cpuSockets);
            socketBox.Items.AddRange(cpuSockets);
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
            panelChooseNewCat.Hide();
            //panelNewExt.Show();
        }

        private void btnNewCpu_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewCPU.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelNewCPU.Hide();
            panelNewGPU.Hide();
            panelNewHDD.Hide();
            panelNewMB.Hide();
            panelNewRam.Hide();
        }

        private void btnNewMB_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewMB.Show();
        }

        private void btnNewRam_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewRam.Show();
        }

        private void btnNewGPU_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewGPU.Show();
        }

        private void btnNewHDD_Click(object sender, EventArgs e)
        {
            panelChooseNewCat.Hide();
            panelNewHDD.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelNewGPU.Hide();
        }

        private void btnConfirmCPU_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + productName.Text + "?", "Add CPU", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                cpuStorage.Add(new CPU(productName.Text, socketBox.Text, 0, 0));
                MessageBox.Show(productName.Text + " added successfuly!");
                productName.Text = "";
                socketBox.Text = "";
                panelNewCPU.Hide();
            }
        }

        private void btnAddNewGPU_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + nameGpu.Text + "?", "Add GPU", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                gpuStorage.Add(new GPU());
            }
        }

        private void btnAddNewHdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewRam_Click(object sender, EventArgs e)
        {

        }
    }
}
