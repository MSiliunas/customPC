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
            updateBoxes();
        }

        private void updateBoxes()
        {
            var cpuSockets = cpuStorage.GetAvailableSockets().ToArray();
            var mbSockets = mbStorage.GetAllSockets().ToArray();
            var mbRams = mbStorage.GetAllRamTypes().ToArray();
            var mbGpus = mbStorage.GetAllGpuTypes().ToArray();
            var ramTypes = ramStorage.GetAllTypes().ToArray();
            var ramSpeeds = ramStorage.GetAllSpeeds().ToArray();

            ramSpeed.Items.Clear();
            ramType.Items.Clear();
            mbRAM.Items.Clear();
            mbCPU.Items.Clear();
            socketBox.Items.Clear();
            mbGPU.Items.Clear();

            ramSpeed.Items.AddRange(ramSpeeds);
            ramType.Items.AddRange(ramTypes);
            mbGPU.Items.AddRange(mbGpus);
            mbRAM.Items.AddRange(mbRams);
            mbCPU.Items.AddRange(mbSockets);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var cpus = cpuStorage.GetAll().ToArray();
            var gpus = gpuStorage.GetAll().ToArray();
            var mbs = mbStorage.GetAll().ToArray();
            var rams = ramStorage.GetAll().ToArray();
            var hdds = hddStorage.GetAll().ToArray();

            int i = 0;
            listParts.Groups.Add("cpu", "CPU");
            listParts.Groups.Add("gpu", "GPU");
            listParts.Groups.Add("mb", "MB");
            listParts.Groups.Add("ram", "RAM");
            listParts.Groups.Add("hdd", "HDD");

            foreach (CPU cpu in cpus)
            {
                listParts.Items.Add(cpu.ToString());
                listParts.Items[i].Group = listParts.Groups[0];
                i++;
            }

            foreach (GPU gpu in gpus)
            {
                listParts.Items.Add(gpu.ToString());
                listParts.Items[i].Group = listParts.Groups[1];
                i++;
            }

            foreach (MB mb in mbs)
            {
                listParts.Items.Add(mb.ToString());
                listParts.Items[i].Group = listParts.Groups[2];
                i++;
            }

            foreach (RAM ram in rams)
            {
                listParts.Items.Add(ram.ToString());
                listParts.Items[i].Group = listParts.Groups[3];
                i++;
            }

            foreach (HDD hdd in hdds)
            {
                listParts.Items.Add(hdd.ToString());
                listParts.Items[i].Group = listParts.Groups[4];
                i++;
            }

            panelManage.Show();
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
                cpuStorage.Add(new CPU(productName.Text, socketBox.Text, Int32.Parse(clockspeed.Text), Int32.Parse(textBox1.Text)));
                MessageBox.Show(productName.Text + " added successfuly!");
                productName.Text = "";
                socketBox.Text = "";
                clockspeed.Text = "";
                textBox1.Text = "";
                panelNewCPU.Hide();
                updateBoxes();
            }
        }

        private void btnAddNewGPU_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + nameGpu.Text + "?", "Add GPU", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                gpuStorage.Add(new GPU(nameGpu.Text, slotGpu.Text, Int32.Parse(speedGpu.Text), Int32.Parse(memoryGpu.Text)));
                MessageBox.Show(productName.Text + " added successfuly!");
                nameGpu.Text = "";
                slotGpu.Text = "";
                speedGpu.Text = "";
                memoryGpu.Text = "";
                panelNewGPU.Hide();
                updateBoxes();
            }
        }

        private void btnAddNewHdd_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + hddName.Text + "?", "Add HDD", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                hddStorage.Add(new HDD(hddName.Text, hddType.Text, hddConnector.Text, Int32.Parse(hddSize.Text)));
                MessageBox.Show(hddName.Text + " added successfuly!");
                hddName.Text = "";
                hddType.Text = "";
                hddConnector.Text = "";
                hddSize.Text = "";
                panelNewHDD.Hide();
                updateBoxes();
            }
        }

        private void btnAddNewMB_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + nameMB.Text + "?", "Add MB", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                mbStorage.Add(new MB(nameMB.Text, mbCPU.Text, mbRAM.Text, mbGPU.Text));
                nameMB.Text = "";
                mbCPU.Text = "";
                mbRAM.Text = "";
                mbGPU.Text = "";
                panelNewMB.Hide();
                updateBoxes();
            }
        }

        private void btnAddNewRam_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to add " + ramName.Text + "?", "Add RAM", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ramStorage.Add(new RAM(ramName.Text, ramType.Text, Int32.Parse(ramMemory.Text), Int32.Parse(ramSpeed.Text)));
                MessageBox.Show(ramName.Text + " added successfuly!");
                ramName.Text = "";
                ramType.Text = "";
                ramMemory.Text = "";
                ramSpeed.Text = "";
                panelNewRam.Hide();
                updateBoxes();
            }
        }

        private void btnCloseList_Click(object sender, EventArgs e)
        {
            listParts.Items.Clear();
            listParts.Groups.Clear();
            panelManage.Hide();
        }
    }
}
