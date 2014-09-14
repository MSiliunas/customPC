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
            this.btnNewCpu = new System.Windows.Forms.Button();
            this.btnNewMB = new System.Windows.Forms.Button();
            this.btnNewRam = new System.Windows.Forms.Button();
            this.btnNewGPU = new System.Windows.Forms.Button();
            this.btnNewHDD = new System.Windows.Forms.Button();
            this.btnNewExtra = new System.Windows.Forms.Button();
            this.panelChooseNewCat.SuspendLayout();
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
            this.title.Location = new System.Drawing.Point(165, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(209, 43);
            this.title.TabIndex = 1;
            this.title.Text = "Admin panel";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add new part";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(216, 120);
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
            this.panelChooseNewCat.Location = new System.Drawing.Point(173, 159);
            this.panelChooseNewCat.Name = "panelChooseNewCat";
            this.panelChooseNewCat.Size = new System.Drawing.Size(181, 54);
            this.panelChooseNewCat.TabIndex = 4;
            this.panelChooseNewCat.Visible = false;
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
            // btnNewMB
            // 
            this.btnNewMB.Location = new System.Drawing.Point(47, 0);
            this.btnNewMB.Name = "btnNewMB";
            this.btnNewMB.Size = new System.Drawing.Size(41, 23);
            this.btnNewMB.TabIndex = 1;
            this.btnNewMB.Text = "MB";
            this.btnNewMB.UseVisualStyleBackColor = true;
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
            // btnNewGPU
            // 
            this.btnNewGPU.Location = new System.Drawing.Point(141, 0);
            this.btnNewGPU.Name = "btnNewGPU";
            this.btnNewGPU.Size = new System.Drawing.Size(41, 23);
            this.btnNewGPU.TabIndex = 3;
            this.btnNewGPU.Text = "GPU";
            this.btnNewGPU.UseVisualStyleBackColor = true;
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 360);
            this.Controls.Add(this.panelChooseNewCat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnBack);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panelChooseNewCat.ResumeLayout(false);
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
    }
}