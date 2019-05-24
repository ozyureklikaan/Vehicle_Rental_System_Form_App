namespace VehicleRentalSystem.views.User
{
    partial class UserHomePage
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnListMyVehicles = new System.Windows.Forms.Button();
            this.btnRentAVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(92, 201);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 23);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(92, 162);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(200, 23);
            this.btn.TabIndex = 8;
            this.btn.Text = "-";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnListMyVehicles
            // 
            this.btnListMyVehicles.Location = new System.Drawing.Point(92, 123);
            this.btnListMyVehicles.Name = "btnListMyVehicles";
            this.btnListMyVehicles.Size = new System.Drawing.Size(200, 23);
            this.btnListMyVehicles.TabIndex = 7;
            this.btnListMyVehicles.Text = "List My Vehicles";
            this.btnListMyVehicles.UseVisualStyleBackColor = true;
            this.btnListMyVehicles.Click += new System.EventHandler(this.BtnListMyVehicles_Click);
            // 
            // btnRentAVehicle
            // 
            this.btnRentAVehicle.Location = new System.Drawing.Point(92, 84);
            this.btnRentAVehicle.Name = "btnRentAVehicle";
            this.btnRentAVehicle.Size = new System.Drawing.Size(200, 23);
            this.btnRentAVehicle.TabIndex = 6;
            this.btnRentAVehicle.Text = "Rent A Vehicle";
            this.btnRentAVehicle.UseVisualStyleBackColor = true;
            this.btnRentAVehicle.Click += new System.EventHandler(this.BtnRentAVehicle_Click);
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnListMyVehicles);
            this.Controls.Add(this.btnRentAVehicle);
            this.Name = "UserHomePage";
            this.Text = "UserHomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHomePage_FormClosed);
            this.Load += new System.EventHandler(this.UserHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnListMyVehicles;
        private System.Windows.Forms.Button btnRentAVehicle;
    }
}