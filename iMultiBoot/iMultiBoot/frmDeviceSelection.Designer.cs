﻿namespace iMultiBoot
{
    partial class frmDeviceSelection
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
            this.cmbCapacitySelection = new System.Windows.Forms.ComboBox();
            this.cmbDeviceSelection = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.lblTotalCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCapacitySelection
            // 
            this.cmbCapacitySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCapacitySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacitySelection.FormattingEnabled = true;
            this.cmbCapacitySelection.Items.AddRange(new object[] {
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB"});
            this.cmbCapacitySelection.Location = new System.Drawing.Point(210, 25);
            this.cmbCapacitySelection.Name = "cmbCapacitySelection";
            this.cmbCapacitySelection.Size = new System.Drawing.Size(125, 24);
            this.cmbCapacitySelection.TabIndex = 1;
            // 
            // cmbDeviceSelection
            // 
            this.cmbDeviceSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeviceSelection.FormattingEnabled = true;
            this.cmbDeviceSelection.Location = new System.Drawing.Point(12, 25);
            this.cmbDeviceSelection.Name = "cmbDeviceSelection";
            this.cmbDeviceSelection.Size = new System.Drawing.Size(179, 24);
            this.cmbDeviceSelection.TabIndex = 2;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(350, 62);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(99, 38);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.ForeColor = System.Drawing.Color.White;
            this.lblSelectDevice.Location = new System.Drawing.Point(9, 9);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(80, 13);
            this.lblSelectDevice.TabIndex = 6;
            this.lblSelectDevice.Text = "Select Device :";
            // 
            // lblTotalCapacity
            // 
            this.lblTotalCapacity.AutoSize = true;
            this.lblTotalCapacity.ForeColor = System.Drawing.Color.White;
            this.lblTotalCapacity.Location = new System.Drawing.Point(207, 9);
            this.lblTotalCapacity.Name = "lblTotalCapacity";
            this.lblTotalCapacity.Size = new System.Drawing.Size(81, 13);
            this.lblTotalCapacity.TabIndex = 7;
            this.lblTotalCapacity.Text = "Total Capacity :";
            // 
            // frmDeviceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(461, 112);
            this.Controls.Add(this.lblTotalCapacity);
            this.Controls.Add(this.lblSelectDevice);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.cmbDeviceSelection);
            this.Controls.Add(this.cmbCapacitySelection);
            this.Name = "frmDeviceSelection";
            this.Text = "Device Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCapacitySelection;
        private System.Windows.Forms.ComboBox cmbDeviceSelection;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.Label lblTotalCapacity;
    }
}