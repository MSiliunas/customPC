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
            this.btnConfirmCPU = new System.Windows.Forms.Button();
            this.panelChooseNewCat.SuspendLayout();
            this.panelNewCPU.SuspendLayout();
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
            // 
            // btnNewGPU
            // 
            this.btnNewGPU.Location = new System.Drawing.Point(141, 0);
            this.btnNewGPU.Name = "btnNewGPU";
            this.btnNewGPU.Size = new System.Drawing.Size(41, 23);
            this.btnNewGPU.TabIndex = 3;
            this.btnNewGPU.Text = "GPU";
            this.btnNewGPU.UseVisualStyleBackColor = true;
            // 
            // btnNewRam
            // 
            this.btnNewRam.Location = new System.Drawing.Point(94, 0);
            this.btnNewRam.Name = "btnNewRam";
            this.btnNewRam.Size = new System.Drawing.Size(41, 23);
            this.btnNewRam.TabIndex = 2;
            this.btnNewRam.Text = "RAM";
            this.btnNewRam.UseVisualStyleBackColor = true;
            // 
            // btnNewMB
            // 
            this.btnNewMB.Location = new System.Drawing.Point(47, 0);
            this.btnNewMB.Name = "btnNewMB";
            this.btnNewMB.Size = new System.Drawing.Size(41, 23);
            this.btnNewMB.TabIndex = 1;
            this.btnNewMB.Text = "MB";
            this.btnNewMB.UseVisualStyleBackColor = true;
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 360);
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
    }
}