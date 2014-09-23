namespace CustomPC
{
    partial class SetUpPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelSetUpMain = new System.Windows.Forms.Panel();
            this.panelStep3 = new System.Windows.Forms.Panel();
            this.cpuSocketLabel = new System.Windows.Forms.Label();
            this.cpuCoresLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.step3CPUList = new System.Windows.Forms.ListBox();
            this.btnStep3Next = new System.Windows.Forms.Button();
            this.panelStep2 = new System.Windows.Forms.Panel();
            this.mbGPUTypeLabel = new System.Windows.Forms.Label();
            this.mbRAMTypeLabel = new System.Windows.Forms.Label();
            this.mbCPUSocketLabel = new System.Windows.Forms.Label();
            this.mbNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.step2MBList = new System.Windows.Forms.ListBox();
            this.btnStep2Next = new System.Windows.Forms.Button();
            this.panelStep1 = new System.Windows.Forms.Panel();
            this.step1Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioGpuYes = new System.Windows.Forms.RadioButton();
            this.radioGpuNo = new System.Windows.Forms.RadioButton();
            this.panelSetUpMain.SuspendLayout();
            this.panelStep3.SuspendLayout();
            this.panelStep2.SuspendLayout();
            this.panelStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 10;
            // 
            // panelSetUpMain
            // 
            this.panelSetUpMain.Controls.Add(this.panelStep3);
            this.panelSetUpMain.Controls.Add(this.panelStep2);
            this.panelSetUpMain.Controls.Add(this.panelStep1);
            this.panelSetUpMain.Location = new System.Drawing.Point(13, 43);
            this.panelSetUpMain.Name = "panelSetUpMain";
            this.panelSetUpMain.Size = new System.Drawing.Size(259, 207);
            this.panelSetUpMain.TabIndex = 1;
            // 
            // panelStep3
            // 
            this.panelStep3.Controls.Add(this.cpuSocketLabel);
            this.panelStep3.Controls.Add(this.cpuCoresLabel);
            this.panelStep3.Controls.Add(this.cpuSpeedLabel);
            this.panelStep3.Controls.Add(this.cpuNameLabel);
            this.panelStep3.Controls.Add(this.label3);
            this.panelStep3.Controls.Add(this.step3CPUList);
            this.panelStep3.Controls.Add(this.btnStep3Next);
            this.panelStep3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStep3.Location = new System.Drawing.Point(0, 0);
            this.panelStep3.Name = "panelStep3";
            this.panelStep3.Size = new System.Drawing.Size(259, 207);
            this.panelStep3.TabIndex = 14;
            this.panelStep3.Visible = false;
            // 
            // cpuSocketLabel
            // 
            this.cpuSocketLabel.AutoSize = true;
            this.cpuSocketLabel.Location = new System.Drawing.Point(135, 82);
            this.cpuSocketLabel.Name = "cpuSocketLabel";
            this.cpuSocketLabel.Size = new System.Drawing.Size(0, 13);
            this.cpuSocketLabel.TabIndex = 14;
            // 
            // cpuCoresLabel
            // 
            this.cpuCoresLabel.AutoSize = true;
            this.cpuCoresLabel.Location = new System.Drawing.Point(135, 65);
            this.cpuCoresLabel.Name = "cpuCoresLabel";
            this.cpuCoresLabel.Size = new System.Drawing.Size(0, 13);
            this.cpuCoresLabel.TabIndex = 13;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Location = new System.Drawing.Point(135, 47);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.cpuSpeedLabel.TabIndex = 12;
            // 
            // cpuNameLabel
            // 
            this.cpuNameLabel.AutoSize = true;
            this.cpuNameLabel.Location = new System.Drawing.Point(135, 30);
            this.cpuNameLabel.Name = "cpuNameLabel";
            this.cpuNameLabel.Size = new System.Drawing.Size(0, 13);
            this.cpuNameLabel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Info:";
            // 
            // step3CPUList
            // 
            this.step3CPUList.FormattingEnabled = true;
            this.step3CPUList.Location = new System.Drawing.Point(4, 4);
            this.step3CPUList.Name = "step3CPUList";
            this.step3CPUList.Size = new System.Drawing.Size(122, 199);
            this.step3CPUList.TabIndex = 9;
            this.step3CPUList.SelectedIndexChanged += new System.EventHandler(this.step3CPUList_SelectedIndexChanged);
            // 
            // btnStep3Next
            // 
            this.btnStep3Next.Location = new System.Drawing.Point(184, 181);
            this.btnStep3Next.Name = "btnStep3Next";
            this.btnStep3Next.Size = new System.Drawing.Size(75, 23);
            this.btnStep3Next.TabIndex = 8;
            this.btnStep3Next.Text = "Next Step";
            this.btnStep3Next.UseVisualStyleBackColor = true;
            this.btnStep3Next.Click += new System.EventHandler(this.btnStep3Next_Click);
            // 
            // panelStep2
            // 
            this.panelStep2.Controls.Add(this.mbGPUTypeLabel);
            this.panelStep2.Controls.Add(this.mbRAMTypeLabel);
            this.panelStep2.Controls.Add(this.mbCPUSocketLabel);
            this.panelStep2.Controls.Add(this.mbNameLabel);
            this.panelStep2.Controls.Add(this.label2);
            this.panelStep2.Controls.Add(this.step2MBList);
            this.panelStep2.Controls.Add(this.btnStep2Next);
            this.panelStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStep2.Location = new System.Drawing.Point(0, 0);
            this.panelStep2.Name = "panelStep2";
            this.panelStep2.Size = new System.Drawing.Size(259, 207);
            this.panelStep2.TabIndex = 7;
            this.panelStep2.Visible = false;
            // 
            // mbGPUTypeLabel
            // 
            this.mbGPUTypeLabel.AutoSize = true;
            this.mbGPUTypeLabel.Location = new System.Drawing.Point(126, 81);
            this.mbGPUTypeLabel.Name = "mbGPUTypeLabel";
            this.mbGPUTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.mbGPUTypeLabel.TabIndex = 13;
            // 
            // mbRAMTypeLabel
            // 
            this.mbRAMTypeLabel.AutoSize = true;
            this.mbRAMTypeLabel.Location = new System.Drawing.Point(126, 64);
            this.mbRAMTypeLabel.Name = "mbRAMTypeLabel";
            this.mbRAMTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.mbRAMTypeLabel.TabIndex = 12;
            // 
            // mbCPUSocketLabel
            // 
            this.mbCPUSocketLabel.AutoSize = true;
            this.mbCPUSocketLabel.Location = new System.Drawing.Point(126, 47);
            this.mbCPUSocketLabel.Name = "mbCPUSocketLabel";
            this.mbCPUSocketLabel.Size = new System.Drawing.Size(0, 13);
            this.mbCPUSocketLabel.TabIndex = 11;
            // 
            // mbNameLabel
            // 
            this.mbNameLabel.AutoSize = true;
            this.mbNameLabel.Location = new System.Drawing.Point(126, 30);
            this.mbNameLabel.Name = "mbNameLabel";
            this.mbNameLabel.Size = new System.Drawing.Size(0, 13);
            this.mbNameLabel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Info:";
            // 
            // step2MBList
            // 
            this.step2MBList.FormattingEnabled = true;
            this.step2MBList.Location = new System.Drawing.Point(13, 13);
            this.step2MBList.Name = "step2MBList";
            this.step2MBList.Size = new System.Drawing.Size(103, 173);
            this.step2MBList.TabIndex = 8;
            this.step2MBList.SelectedIndexChanged += new System.EventHandler(this.step2MBList_SelectedIndexChanged);
            // 
            // btnStep2Next
            // 
            this.btnStep2Next.Location = new System.Drawing.Point(184, 181);
            this.btnStep2Next.Name = "btnStep2Next";
            this.btnStep2Next.Size = new System.Drawing.Size(75, 23);
            this.btnStep2Next.TabIndex = 7;
            this.btnStep2Next.Text = "Next Step";
            this.btnStep2Next.UseVisualStyleBackColor = true;
            this.btnStep2Next.Click += new System.EventHandler(this.btnStep2Next_Click);
            // 
            // panelStep1
            // 
            this.panelStep1.Controls.Add(this.step1Next);
            this.panelStep1.Controls.Add(this.label1);
            this.panelStep1.Controls.Add(this.radioGpuYes);
            this.panelStep1.Controls.Add(this.radioGpuNo);
            this.panelStep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStep1.Location = new System.Drawing.Point(0, 0);
            this.panelStep1.Name = "panelStep1";
            this.panelStep1.Size = new System.Drawing.Size(259, 207);
            this.panelStep1.TabIndex = 0;
            // 
            // step1Next
            // 
            this.step1Next.Location = new System.Drawing.Point(181, 181);
            this.step1Next.Name = "step1Next";
            this.step1Next.Size = new System.Drawing.Size(75, 23);
            this.step1Next.TabIndex = 6;
            this.step1Next.Text = "Next Step";
            this.step1Next.UseVisualStyleBackColor = true;
            this.step1Next.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Is integrated GPU necessary? ";
            // 
            // radioGpuYes
            // 
            this.radioGpuYes.AutoSize = true;
            this.radioGpuYes.Location = new System.Drawing.Point(56, 91);
            this.radioGpuYes.Name = "radioGpuYes";
            this.radioGpuYes.Size = new System.Drawing.Size(43, 17);
            this.radioGpuYes.TabIndex = 4;
            this.radioGpuYes.Text = "Yes";
            this.radioGpuYes.UseVisualStyleBackColor = true;
            // 
            // radioGpuNo
            // 
            this.radioGpuNo.AutoSize = true;
            this.radioGpuNo.Location = new System.Drawing.Point(56, 67);
            this.radioGpuNo.Name = "radioGpuNo";
            this.radioGpuNo.Size = new System.Drawing.Size(39, 17);
            this.radioGpuNo.TabIndex = 3;
            this.radioGpuNo.Text = "No";
            this.radioGpuNo.UseVisualStyleBackColor = true;
            // 
            // SetUpPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panelSetUpMain);
            this.Controls.Add(this.progressBar1);
            this.Name = "SetUpPC";
            this.Text = "SetUpPC";
            this.panelSetUpMain.ResumeLayout(false);
            this.panelStep3.ResumeLayout(false);
            this.panelStep3.PerformLayout();
            this.panelStep2.ResumeLayout(false);
            this.panelStep2.PerformLayout();
            this.panelStep1.ResumeLayout(false);
            this.panelStep1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panelSetUpMain;
        private System.Windows.Forms.Panel panelStep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioGpuYes;
        private System.Windows.Forms.RadioButton radioGpuNo;
        private System.Windows.Forms.Button step1Next;
        private System.Windows.Forms.Panel panelStep2;
        private System.Windows.Forms.Button btnStep2Next;
        private System.Windows.Forms.ListBox step2MBList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mbGPUTypeLabel;
        private System.Windows.Forms.Label mbRAMTypeLabel;
        private System.Windows.Forms.Label mbCPUSocketLabel;
        private System.Windows.Forms.Label mbNameLabel;
        private System.Windows.Forms.Panel panelStep3;
        private System.Windows.Forms.Button btnStep3Next;
        private System.Windows.Forms.Label cpuSocketLabel;
        private System.Windows.Forms.Label cpuCoresLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label cpuNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox step3CPUList;
    }
}