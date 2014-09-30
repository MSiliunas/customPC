using System;
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
				bool ok = true;
				var cpus = cpuStorage.GetAll();
				var gpus = gpuStorage.GetAll();
				var rams = ramStorage.GetAll();
				var hdds = hddStorage.GetAll();

				MB selectedMb = (MB) step2MBList.SelectedItem;

				hddListBox.Items.Clear();
				foreach (HDD hdd in hdds)
				{
					hddListBox.Items.Add(hdd);
				}

				gpuListBox.Items.Clear();
				foreach (GPU gpu in gpus)
				{
					if (gpu.isSocketCompatible(selectedMb.GpuType))
					{
						gpuListBox.Items.Add(gpu);
					}
				}

				step3CPUList.Items.Clear();
				foreach (CPU cpu in cpus)
				{
					if (cpu.isSocketCompatible(selectedMb.CpuSocket))
					{
						step3CPUList.Items.Add(cpu);
					}
				}

				ramListBox.Items.Clear();
				foreach (RAM ram in rams)
				{
					if (ram.isSocketCompatible(selectedMb.RamType))
					{
						ramListBox.Items.Add(ram);
					}
				}

				if (step3CPUList.Items.Count <= 0 || (gpuListBox.Items.Count <= 0 && !selectedMb.IntegratedGpu) || pc.prerequisites.integratedGpu != selectedMb.IntegratedGpu || ramListBox.Items.Count <= 0)
					ok = false;

				if (ok)
				{
					pc.Mb = selectedMb;
					panelStep2.Hide();
					panelStep3.Show();
				}
				else
				{
					MessageBox.Show("Sorry, we have no parts for this MB.");
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
				panelStep4.Show();
			}
			else
			{
				MessageBox.Show("Please select a CPU!");
			}
		}

		private void btnStep4Next_Click(object sender, EventArgs e)
		{
			if (gpuListBox.SelectedItems.Count > 0)
			{
				pc.Gpu = (GPU) gpuListBox.SelectedItem;
				panelStep4.Hide();
				panelStep5.Show();
			}
			else
			{
				MessageBox.Show("Please select a GPU!");
			}
		}

		private void btnStep5Next_Click(object sender, EventArgs e)
		{
			if (ramListBox.SelectedItems.Count > 0)
			{
				pc.Ram = (RAM) ramListBox.SelectedItem;
				panelStep5.Hide();
				panelStep6.Show();
			}
			else
			{
				MessageBox.Show("Please select rams!");
			}
		}

		private void btnStep6Next_Click(object sender, EventArgs e)
		{
			if (hddListBox.SelectedItems.Count > 0)
			{
				pc.Hdd = (HDD) hddListBox.SelectedItem;
				panelStep6.Hide();
			}
			else
			{
				MessageBox.Show("Please select a HDD!");
			}
		}

		private void hddListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (hddListBox.SelectedItems.Count > 0)
			{
				HDD selected = (HDD) hddListBox.SelectedItem;
				hddName.Text = selected.Name;
				hddType.Text = selected.Type;
				hddConnector.Text = selected.Connector;
				hddSize.Text = selected.Size.ToString();
			}
		}

		private void ramListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ramListBox.SelectedItems.Count > 0)
			{
				RAM selected = (RAM) ramListBox.SelectedItem;
				ramName.Text = selected.Name;
				ramType.Text = selected.Type;
				ramSpeed.Text = selected.Speed.ToString();
				ramSize.Text = selected.Size.ToString();
			}
		}

		private void gpuListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gpuListBox.SelectedItems.Count > 0)
			{
				GPU selected = (GPU) gpuListBox.SelectedItem;
				gpuName.Text = selected.Name;
				gpuType.Text = selected.Type;
				gpuSpeed.Text = selected.Speed.ToString();
				gpuMemory.Text = selected.Memory.ToString();
			}
		}
	}
}
