namespace VehicleRentalSystem.views.Company
{
    partial class CompanyHomePage
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnListVehicles = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(118, 121);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(200, 23);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.BtnAddVehicle_Click);
            // 
            // btnListVehicles
            // 
            this.btnListVehicles.Location = new System.Drawing.Point(118, 160);
            this.btnListVehicles.Name = "btnListVehicles";
            this.btnListVehicles.Size = new System.Drawing.Size(200, 23);
            this.btnListVehicles.TabIndex = 1;
            this.btnListVehicles.Text = "List Company\'s Vehicles";
            this.btnListVehicles.UseVisualStyleBackColor = true;
            this.btnListVehicles.Click += new System.EventHandler(this.BtnListVehicles_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(118, 238);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(118, 199);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(200, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "-";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // CompanyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 367);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnListVehicles);
            this.Controls.Add(this.btnAddVehicle);
            this.Name = "CompanyHomePage";
            this.Text = "CompanyHomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyHomePage_FormClosed);
            this.Load += new System.EventHandler(this.CompanyHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnListVehicles;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btn;
    }
}