﻿namespace VehicleRentalSystem.views.User
{
    partial class RentingPage
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
            this.groupRentingVehicle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.dataGVRentingVehicle = new System.Windows.Forms.DataGridView();
            this.comboRetingTime = new System.Windows.Forms.ComboBox();
            this.groupRentingVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRentingVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupRentingVehicle
            // 
            this.groupRentingVehicle.Controls.Add(this.comboRetingTime);
            this.groupRentingVehicle.Controls.Add(this.label1);
            this.groupRentingVehicle.Controls.Add(this.btnRent);
            this.groupRentingVehicle.Controls.Add(this.dataGVRentingVehicle);
            this.groupRentingVehicle.Location = new System.Drawing.Point(12, 12);
            this.groupRentingVehicle.Name = "groupRentingVehicle";
            this.groupRentingVehicle.Size = new System.Drawing.Size(461, 391);
            this.groupRentingVehicle.TabIndex = 9;
            this.groupRentingVehicle.TabStop = false;
            this.groupRentingVehicle.Text = "Rent Selected Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Renting Time";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(150, 338);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(150, 23);
            this.btnRent.TabIndex = 3;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // dataGVRentingVehicle
            // 
            this.dataGVRentingVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRentingVehicle.Location = new System.Drawing.Point(6, 19);
            this.dataGVRentingVehicle.Name = "dataGVRentingVehicle";
            this.dataGVRentingVehicle.Size = new System.Drawing.Size(449, 234);
            this.dataGVRentingVehicle.TabIndex = 0;
            // 
            // comboRetingTime
            // 
            this.comboRetingTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRetingTime.FormattingEnabled = true;
            this.comboRetingTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboRetingTime.Location = new System.Drawing.Point(177, 295);
            this.comboRetingTime.Name = "comboRetingTime";
            this.comboRetingTime.Size = new System.Drawing.Size(212, 21);
            this.comboRetingTime.TabIndex = 7;
            // 
            // RentingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 414);
            this.Controls.Add(this.groupRentingVehicle);
            this.Name = "RentingPage";
            this.Text = "Renting Page";
            this.Load += new System.EventHandler(this.RentingPage_Load);
            this.groupRentingVehicle.ResumeLayout(false);
            this.groupRentingVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRentingVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRentingVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dataGVRentingVehicle;
        private System.Windows.Forms.ComboBox comboRetingTime;
    }
}