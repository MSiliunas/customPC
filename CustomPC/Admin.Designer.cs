namespace CustomPC
{
    partial class Admin
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
            this.btnBack = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelChooseNewCat = new System.Windows.Forms.Panel();
            this.btnNewExtra = new System.Windows.Forms.Button();
            this.btnNewHDD = new System.Windows.Forms.Button();
            this.btnNewGPU = new System.Windows.Forms.Button();
            this.btnNewRam = new System.Windows.Forms.Button();
            this.btnNewMB = new System.Windows.Forms.Button();
            this.btnNewCpu = new System.Windows.Forms.Button();
            this.panelNewCPU = new System.Windows.Forms.Panel();
            this.btnConfirmCPU = new System.Windows.Forms.Button();
            this.socketBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clockspeed = new System.Windows.Forms.TextBox();
            this.clockspeedLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.newCpuLabel = new System.Windows.Forms.Label();
            this.panelNewGPU = new System.Windows.Forms.Panel();
            this.btnAddNewGPU = new System.Windows.Forms.Button();
            this.slotGpu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.memoryGpu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.speedGpu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameGpu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelNewMB = new System.Windows.Forms.Panel();
            this.mbCPU = new System.Windows.Forms.ComboBox();
            this.mbRAM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mbGPU = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nameMB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panelNewHDD = new System.Windows.Forms.Panel();
            this.hddType = new System.Windows.Forms.ComboBox();
            this.hddConnector = new System.Windows.Forms.ComboBox();
            this.btnAddNewHdd = new System.Windows.Forms.Button();
            this.hddSize = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hddName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panelNewRam = new System.Windows.Forms.Panel();
            this.ramType = new System.Windows.Forms.ComboBox();
            this.ramSpeed = new System.Windows.Forms.ComboBox();
            this.btnAddNewRam = new System.Windows.Forms.Button();
            this.ramMemory = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ramName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ramCancel = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.panelChooseNewCat.SuspendLayout();
            this.panelNewCPU.SuspendLayout();
            this.panelNewGPU.SuspendLayout();
            this.panelNewMB.SuspendLayout();
            this.panelNewHDD.SuspendLayout();
            this.panelNewRam.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(21, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.title.Location = new System.Drawing.Point(63, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(209, 43);
            this.title.TabIndex = 1;
            this.title.Text = "Admin panel";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add new part";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Manage parts";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panelChooseNewCat
            // 
            this.panelChooseNewCat.Controls.Add(this.btnNewExtra);
            this.panelChooseNewCat.Controls.Add(this.btnNewHDD);
            this.panelChooseNewCat.Controls.Add(this.btnNewGPU);
            this.panelChooseNewCat.Controls.Add(this.btnNewRam);
            this.panelChooseNewCat.Controls.Add(this.btnNewMB);
            this.panelChooseNewCat.Controls.Add(this.btnNewCpu);
            this.panelChooseNewCat.Location = new System.Drawing.Point(71, 181);
            this.panelChooseNewCat.Name = "panelChooseNewCat";
            this.panelChooseNewCat.Size = new System.Drawing.Size(181, 54);
            this.panelChooseNewCat.TabIndex = 4;
            this.panelChooseNewCat.Visible = false;
            // 
            // btnNewExtra
            // 
            this.btnNewExtra.Location = new System.Drawing.Point(94, 29);
            this.btnNewExtra.Name = "btnNewExtra";
            this.btnNewExtra.Size = new System.Drawing.Size(41, 23);
            this.btnNewExtra.TabIndex = 5;
            this.btnNewExtra.Text = "EXT";
            this.btnNewExtra.UseVisualStyleBackColor = true;
            this.btnNewExtra.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNewHDD
            // 
            this.btnNewHDD.Location = new System.Drawing.Point(47, 29);
            this.btnNewHDD.Name = "btnNewHDD";
            this.btnNewHDD.Size = new System.Drawing.Size(41, 23);
            this.btnNewHDD.TabIndex = 4;
            this.btnNewHDD.Text = "HDD";
            this.btnNewHDD.UseVisualStyleBackColor = true;
            this.btnNewHDD.Click += new System.EventHandler(this.btnNewHDD_Click);
            // 
            // btnNewGPU
            // 
            this.btnNewGPU.Location = new System.Drawing.Point(141, 0);
            this.btnNewGPU.Name = "btnNewGPU";
            this.btnNewGPU.Size = new System.Drawing.Size(41, 23);
            this.btnNewGPU.TabIndex = 3;
            this.btnNewGPU.Text = "GPU";
            this.btnNewGPU.UseVisualStyleBackColor = true;
            this.btnNewGPU.Click += new System.EventHandler(this.btnNewGPU_Click);
            // 
            // btnNewRam
            // 
            this.btnNewRam.Location = new System.Drawing.Point(94, 0);
            this.btnNewRam.Name = "btnNewRam";
            this.btnNewRam.Size = new System.Drawing.Size(41, 23);
            this.btnNewRam.TabIndex = 2;
            this.btnNewRam.Text = "RAM";
            this.btnNewRam.UseVisualStyleBackColor = true;
            this.btnNewRam.Click += new System.EventHandler(this.btnNewRam_Click);
            // 
            // btnNewMB
            // 
            this.btnNewMB.Location = new System.Drawing.Point(47, 0);
            this.btnNewMB.Name = "btnNewMB";
            this.btnNewMB.Size = new System.Drawing.Size(41, 23);
            this.btnNewMB.TabIndex = 1;
            this.btnNewMB.Text = "MB";
            this.btnNewMB.UseVisualStyleBackColor = true;
            this.btnNewMB.Click += new System.EventHandler(this.btnNewMB_Click);
            // 
            // btnNewCpu
            // 
            this.btnNewCpu.Location = new System.Drawing.Point(0, 0);
            this.btnNewCpu.Name = "btnNewCpu";
            this.btnNewCpu.Size = new System.Drawing.Size(41, 23);
            this.btnNewCpu.TabIndex = 0;
            this.btnNewCpu.Text = "CPU";
            this.btnNewCpu.UseVisualStyleBackColor = true;
            this.btnNewCpu.Click += new System.EventHandler(this.btnNewCpu_Click);
            // 
            // panelNewCPU
            // 
            this.panelNewCPU.Controls.Add(this.btnConfirmCPU);
            this.panelNewCPU.Controls.Add(this.socketBox);
            this.panelNewCPU.Controls.Add(this.label2);
            this.panelNewCPU.Controls.Add(this.textBox1);
            this.panelNewCPU.Controls.Add(this.label1);
            this.panelNewCPU.Controls.Add(this.clockspeed);
            this.panelNewCPU.Controls.Add(this.clockspeedLabel);
            this.panelNewCPU.Controls.Add(this.productName);
            this.panelNewCPU.Controls.Add(this.productNameLabel);
            this.panelNewCPU.Controls.Add(this.btnCancel);
            this.panelNewCPU.Controls.Add(this.newCpuLabel);
            this.panelNewCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCPU.Location = new System.Drawing.Point(0, 0);
            this.panelNewCPU.Name = "panelNewCPU";
            this.panelNewCPU.Size = new System.Drawing.Size(317, 360);
            this.panelNewCPU.TabIndex = 5;
            this.panelNewCPU.Visible = false;
            // 
            // btnConfirmCPU
            // 
            this.btnConfirmCPU.Location = new System.Drawing.Point(186, 209);
            this.btnConfirmCPU.Name = "btnConfirmCPU";
            this.btnConfirmCPU.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCPU.TabIndex = 10;
            this.btnConfirmCPU.Text = "Add";
            this.btnConfirmCPU.UseVisualStyleBackColor = true;
            this.btnConfirmCPU.Click += new System.EventHandler(this.btnConfirmCPU_Click);
            // 
            // socketBox
            // 
            this.socketBox.FormattingEnabled = true;
            this.socketBox.Location = new System.Drawing.Point(140, 165);
            this.socketBox.Name = "socketBox";
            this.socketBox.Size = new System.Drawing.Size(121, 21);
            this.socketBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Socket:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Cores:";
            // 
            // clockspeed
            // 
            this.clockspeed.Location = new System.Drawing.Point(161, 113);
            this.clockspeed.Name = "clockspeed";
            this.clockspeed.Size = new System.Drawing.Size(100, 20);
            this.clockspeed.TabIndex = 5;
            // 
            // clockspeedLabel
            // 
            this.clockspeedLabel.AutoSize = true;
            this.clockspeedLabel.Location = new System.Drawing.Point(89, 116);
            this.clockspeedLabel.Name = "clockspeedLabel";
            this.clockspeedLabel.Size = new System.Drawing.Size(66, 13);
            this.clockspeedLabel.TabIndex = 4;
            this.clockspeedLabel.Text = "Clockspeed:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(114, 87);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(147, 20);
            this.productName.TabIndex = 3;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(26, 90);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(89, 13);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Name of product:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(26, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // newCpuLabel
            // 
            this.newCpuLabel.AutoSize = true;
            this.newCpuLabel.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.newCpuLabel.Location = new System.Drawing.Point(21, 28);
            this.newCpuLabel.Name = "newCpuLabel";
            this.newCpuLabel.Size = new System.Drawing.Size(184, 30);
            this.newCpuLabel.TabIndex = 0;
            this.newCpuLabel.Text = "Enter a new CPU";
            // 
            // panelNewGPU
            // 
            this.panelNewGPU.Controls.Add(this.btnAddNewGPU);
            this.panelNewGPU.Controls.Add(this.slotGpu);
            this.panelNewGPU.Controls.Add(this.label3);
            this.panelNewGPU.Controls.Add(this.memoryGpu);
            this.panelNewGPU.Controls.Add(this.label4);
            this.panelNewGPU.Controls.Add(this.speedGpu);
            this.panelNewGPU.Controls.Add(this.label5);
            this.panelNewGPU.Controls.Add(this.nameGpu);
            this.panelNewGPU.Controls.Add(this.label6);
            this.panelNewGPU.Controls.Add(this.button2);
            this.panelNewGPU.Controls.Add(this.label7);
            this.panelNewGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewGPU.Location = new System.Drawing.Point(0, 0);
            this.panelNewGPU.Name = "panelNewGPU";
            this.panelNewGPU.Size = new System.Drawing.Size(317, 360);
            this.panelNewGPU.TabIndex = 12;
            this.panelNewGPU.Visible = false;
            // 
            // btnAddNewGPU
            // 
            this.btnAddNewGPU.Location = new System.Drawing.Point(186, 209);
            this.btnAddNewGPU.Name = "btnAddNewGPU";
            this.btnAddNewGPU.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewGPU.TabIndex = 10;
            this.btnAddNewGPU.Text = "Add";
            this.btnAddNewGPU.UseVisualStyleBackColor = true;
            this.btnAddNewGPU.Click += new System.EventHandler(this.btnAddNewGPU_Click);
            // 
            // slotGpu
            // 
            this.slotGpu.FormattingEnabled = true;
            this.slotGpu.Location = new System.Drawing.Point(140, 165);
            this.slotGpu.Name = "slotGpu";
            this.slotGpu.Size = new System.Drawing.Size(121, 21);
            this.slotGpu.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Slot type:";
            // 
            // memoryGpu
            // 
            this.memoryGpu.Location = new System.Drawing.Point(161, 139);
            this.memoryGpu.Name = "memoryGpu";
            this.memoryGpu.Size = new System.Drawing.Size(100, 20);
            this.memoryGpu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Memory:";
            // 
            // speedGpu
            // 
            this.speedGpu.Location = new System.Drawing.Point(161, 113);
            this.speedGpu.Name = "speedGpu";
            this.speedGpu.Size = new System.Drawing.Size(100, 20);
            this.speedGpu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bus speed:";
            // 
            // nameGpu
            // 
            this.nameGpu.Location = new System.Drawing.Point(114, 87);
            this.nameGpu.Name = "nameGpu";
            this.nameGpu.Size = new System.Drawing.Size(147, 20);
            this.nameGpu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name of product:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter a new GPU";
            // 
            // panelNewMB
            // 
            this.panelNewMB.Controls.Add(this.mbCPU);
            this.panelNewMB.Controls.Add(this.mbRAM);
            this.panelNewMB.Controls.Add(this.button1);
            this.panelNewMB.Controls.Add(this.mbGPU);
            this.panelNewMB.Controls.Add(this.label8);
            this.panelNewMB.Controls.Add(this.label9);
            this.panelNewMB.Controls.Add(this.label10);
            this.panelNewMB.Controls.Add(this.nameMB);
            this.panelNewMB.Controls.Add(this.label11);
            this.panelNewMB.Controls.Add(this.button3);
            this.panelNewMB.Controls.Add(this.label12);
            this.panelNewMB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewMB.Location = new System.Drawing.Point(0, 0);
            this.panelNewMB.Name = "panelNewMB";
            this.panelNewMB.Size = new System.Drawing.Size(317, 360);
            this.panelNewMB.TabIndex = 13;
            this.panelNewMB.Visible = false;
            // 
            // mbCPU
            // 
            this.mbCPU.FormattingEnabled = true;
            this.mbCPU.Location = new System.Drawing.Point(139, 113);
            this.mbCPU.Name = "mbCPU";
            this.mbCPU.Size = new System.Drawing.Size(121, 21);
            this.mbCPU.TabIndex = 12;
            // 
            // mbRAM
            // 
            this.mbRAM.FormattingEnabled = true;
            this.mbRAM.Location = new System.Drawing.Point(140, 138);
            this.mbRAM.Name = "mbRAM";
            this.mbRAM.Size = new System.Drawing.Size(121, 21);
            this.mbRAM.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mbGPU
            // 
            this.mbGPU.FormattingEnabled = true;
            this.mbGPU.Location = new System.Drawing.Point(140, 165);
            this.mbGPU.Name = "mbGPU";
            this.mbGPU.Size = new System.Drawing.Size(121, 21);
            this.mbGPU.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "GPU type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "RAM type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "CPU Socket:";
            // 
            // nameMB
            // 
            this.nameMB.Location = new System.Drawing.Point(114, 87);
            this.nameMB.Name = "nameMB";
            this.nameMB.Size = new System.Drawing.Size(147, 20);
            this.nameMB.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name of product:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.Location = new System.Drawing.Point(21, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Enter a new MB";
            // 
            // panelNewHDD
            // 
            this.panelNewHDD.Controls.Add(this.hddType);
            this.panelNewHDD.Controls.Add(this.hddConnector);
            this.panelNewHDD.Controls.Add(this.btnAddNewHdd);
            this.panelNewHDD.Controls.Add(this.hddSize);
            this.panelNewHDD.Controls.Add(this.label13);
            this.panelNewHDD.Controls.Add(this.label14);
            this.panelNewHDD.Controls.Add(this.label15);
            this.panelNewHDD.Controls.Add(this.hddName);
            this.panelNewHDD.Controls.Add(this.label16);
            this.panelNewHDD.Controls.Add(this.cancel);
            this.panelNewHDD.Controls.Add(this.label17);
            this.panelNewHDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewHDD.Location = new System.Drawing.Point(0, 0);
            this.panelNewHDD.Name = "panelNewHDD";
            this.panelNewHDD.Size = new System.Drawing.Size(317, 360);
            this.panelNewHDD.TabIndex = 14;
            this.panelNewHDD.Visible = false;
            // 
            // hddType
            // 
            this.hddType.FormattingEnabled = true;
            this.hddType.Location = new System.Drawing.Point(139, 113);
            this.hddType.Name = "hddType";
            this.hddType.Size = new System.Drawing.Size(121, 21);
            this.hddType.TabIndex = 12;
            // 
            // hddConnector
            // 
            this.hddConnector.FormattingEnabled = true;
            this.hddConnector.Location = new System.Drawing.Point(140, 138);
            this.hddConnector.Name = "hddConnector";
            this.hddConnector.Size = new System.Drawing.Size(121, 21);
            this.hddConnector.TabIndex = 11;
            // 
            // btnAddNewHdd
            // 
            this.btnAddNewHdd.Location = new System.Drawing.Point(186, 209);
            this.btnAddNewHdd.Name = "btnAddNewHdd";
            this.btnAddNewHdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewHdd.TabIndex = 10;
            this.btnAddNewHdd.Text = "Add";
            this.btnAddNewHdd.UseVisualStyleBackColor = true;
            this.btnAddNewHdd.Click += new System.EventHandler(this.btnAddNewHdd_Click);
            // 
            // hddSize
            // 
            this.hddSize.FormattingEnabled = true;
            this.hddSize.Location = new System.Drawing.Point(140, 165);
            this.hddSize.Name = "hddSize";
            this.hddSize.Size = new System.Drawing.Size(121, 21);
            this.hddSize.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(105, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Size:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Connector:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Type:";
            // 
            // hddName
            // 
            this.hddName.Location = new System.Drawing.Point(114, 87);
            this.hddName.Name = "hddName";
            this.hddName.Size = new System.Drawing.Size(147, 20);
            this.hddName.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Name of product:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(26, 316);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.Location = new System.Drawing.Point(21, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 30);
            this.label17.TabIndex = 0;
            this.label17.Text = "Enter a new HDD";
            // 
            // panelNewRam
            // 
            this.panelNewRam.Controls.Add(this.ramType);
            this.panelNewRam.Controls.Add(this.ramSpeed);
            this.panelNewRam.Controls.Add(this.btnAddNewRam);
            this.panelNewRam.Controls.Add(this.ramMemory);
            this.panelNewRam.Controls.Add(this.label18);
            this.panelNewRam.Controls.Add(this.label19);
            this.panelNewRam.Controls.Add(this.label20);
            this.panelNewRam.Controls.Add(this.ramName);
            this.panelNewRam.Controls.Add(this.label21);
            this.panelNewRam.Controls.Add(this.ramCancel);
            this.panelNewRam.Controls.Add(this.label22);
            this.panelNewRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewRam.Location = new System.Drawing.Point(0, 0);
            this.panelNewRam.Name = "panelNewRam";
            this.panelNewRam.Size = new System.Drawing.Size(317, 360);
            this.panelNewRam.TabIndex = 15;
            this.panelNewRam.Visible = false;
            // 
            // ramType
            // 
            this.ramType.FormattingEnabled = true;
            this.ramType.Location = new System.Drawing.Point(139, 113);
            this.ramType.Name = "ramType";
            this.ramType.Size = new System.Drawing.Size(121, 21);
            this.ramType.TabIndex = 12;
            // 
            // ramSpeed
            // 
            this.ramSpeed.FormattingEnabled = true;
            this.ramSpeed.Location = new System.Drawing.Point(140, 138);
            this.ramSpeed.Name = "ramSpeed";
            this.ramSpeed.Size = new System.Drawing.Size(121, 21);
            this.ramSpeed.TabIndex = 11;
            // 
            // btnAddNewRam
            // 
            this.btnAddNewRam.Location = new System.Drawing.Point(186, 209);
            this.btnAddNewRam.Name = "btnAddNewRam";
            this.btnAddNewRam.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewRam.TabIndex = 10;
            this.btnAddNewRam.Text = "Add";
            this.btnAddNewRam.UseVisualStyleBackColor = true;
            this.btnAddNewRam.Click += new System.EventHandler(this.btnAddNewRam_Click);
            // 
            // ramMemory
            // 
            this.ramMemory.FormattingEnabled = true;
            this.ramMemory.Location = new System.Drawing.Point(140, 165);
            this.ramMemory.Name = "ramMemory";
            this.ramMemory.Size = new System.Drawing.Size(121, 21);
            this.ramMemory.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Location = new System.Drawing.Point(65, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Memory Size:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(92, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Speed:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(99, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Type:";
            // 
            // ramName
            // 
            this.ramName.Location = new System.Drawing.Point(114, 87);
            this.ramName.Name = "ramName";
            this.ramName.Size = new System.Drawing.Size(147, 20);
            this.ramName.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Name of product:";
            // 
            // ramCancel
            // 
            this.ramCancel.Location = new System.Drawing.Point(26, 316);
            this.ramCancel.Name = "ramCancel";
            this.ramCancel.Size = new System.Drawing.Size(75, 23);
            this.ramCancel.TabIndex = 1;
            this.ramCancel.Text = "Cancel";
            this.ramCancel.UseVisualStyleBackColor = true;
            this.ramCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label22.Location = new System.Drawing.Point(21, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 30);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter a new RAM";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 360);
            this.Controls.Add(this.panelNewRam);
            this.Controls.Add(this.panelNewHDD);
            this.Controls.Add(this.panelNewMB);
            this.Controls.Add(this.panelNewGPU);
            this.Controls.Add(this.panelNewCPU);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelChooseNewCat);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panelChooseNewCat.ResumeLayout(false);
            this.panelNewCPU.ResumeLayout(false);
            this.panelNewCPU.PerformLayout();
            this.panelNewGPU.ResumeLayout(false);
            this.panelNewGPU.PerformLayout();
            this.panelNewMB.ResumeLayout(false);
            this.panelNewMB.PerformLayout();
            this.panelNewHDD.ResumeLayout(false);
            this.panelNewHDD.PerformLayout();
            this.panelNewRam.ResumeLayout(false);
            this.panelNewRam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelChooseNewCat;
        private System.Windows.Forms.Button btnNewExtra;
        private System.Windows.Forms.Button btnNewHDD;
        private System.Windows.Forms.Button btnNewGPU;
        private System.Windows.Forms.Button btnNewRam;
        private System.Windows.Forms.Button btnNewMB;
        private System.Windows.Forms.Button btnNewCpu;
        private System.Windows.Forms.Panel panelNewCPU;
        private System.Windows.Forms.Label newCpuLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox clockspeed;
        private System.Windows.Forms.Label clockspeedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox socketBox;
        private System.Windows.Forms.Button btnConfirmCPU;
        private System.Windows.Forms.Panel panelNewGPU;
        private System.Windows.Forms.Button btnAddNewGPU;
        private System.Windows.Forms.ComboBox slotGpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memoryGpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox speedGpu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameGpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelNewMB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox mbGPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nameMB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox mbRAM;
        private System.Windows.Forms.ComboBox mbCPU;
        private System.Windows.Forms.Panel panelNewHDD;
        private System.Windows.Forms.ComboBox hddType;
        private System.Windows.Forms.ComboBox hddConnector;
        private System.Windows.Forms.Button btnAddNewHdd;
        private System.Windows.Forms.ComboBox hddSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox hddName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelNewRam;
        private System.Windows.Forms.ComboBox ramType;
        private System.Windows.Forms.ComboBox ramSpeed;
        private System.Windows.Forms.Button btnAddNewRam;
        private System.Windows.Forms.ComboBox ramMemory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ramName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ramCancel;
        private System.Windows.Forms.Label label22;
    }
}