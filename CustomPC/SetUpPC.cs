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
    public partial class SetUpPC : Form
    {
        PC pc = new PC();
        CPUStorage cpuStorage = new CPUStorage();
        MBStorage mbStorage = new MBStorage();
        GPUStorage gpuStorage = new GPUStorage();
        RAMStorage ramStorage = new RAMStorage();
        HDDStorage hddStorage = new HDDStorage();

        public SetUpPC()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((radioGpuNo.Checked) || (radioGpuYes.Checked))
            {
                pc.prerequisites.integratedGpu = radioGpuYes.Checked;
                panelStep1.Hide();

                step2MBList.Items.AddRange(mbStorage.GetAll().ToArray());

                panelStep2.Show();
            }
            else
            {
                MessageBox.Show("Please select whether integrated GPU is necessary or not!");
            }
        }

        private void btnStep2Next_Click(object sender, EventArgs e)
        {
            if (step2MBList.SelectedItems.Count > 0)
            {
                var cpus = cpuStorage.GetAll();

                pc.Mb = (MB)step2MBList.SelectedItem;

                step3CPUList.Items.Clear();
                foreach (CPU cpu in cpus)
                {
                    if (cpu.isSocketCompatible(pc.Mb.CpuSocket))
                    {
                        step3CPUList.Items.Add(cpu);
                    }
                }

                if (step3CPUList.Items.Count > 0)
                {
                    panelStep2.Hide();
                    panelStep3.Show();
                }
                else
                {
                    MessageBox.Show("Sorry, we have no CPUs for this MB.");
                }
            }
            else
            {
                MessageBox.Show("Please select MB!");
            }
        }

        private void step2MBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (step2MBList.SelectedItems.Count > 0)
            {
                MB selected = (MB)step2MBList.SelectedItem;
                mbNameLabel.Text = selected.Name;
                mbCPUSocketLabel.Text = selected.CpuSocket;
                mbGPUTypeLabel.Text = selected.GpuType;
                mbRAMTypeLabel.Text = selected.RamType;
            }
        }

        private void step3CPUList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (step3CPUList.SelectedItems.Count > 0)
            {
                CPU selected = (CPU)step3CPUList.SelectedItem;
                cpuNameLabel.Text = selected.Name;
                cpuSpeedLabel.Text = selected.Clockspeed.ToString();
                cpuCoresLabel.Text = selected.Cores.ToString();
                cpuSocketLabel.Text = selected.Socket;
            }
        }

        private void btnStep3Next_Click(object sender, EventArgs e)
        {
            if (step3CPUList.SelectedItems.Count > 0)
            {
                pc.Cpu = (CPU)step3CPUList.SelectedItem;
                panelStep3.Hide();
                //panelStep4.Show();
            }
            else
            {
                MessageBox.Show("Please select a CPU!");
            }
        }


    }
}
