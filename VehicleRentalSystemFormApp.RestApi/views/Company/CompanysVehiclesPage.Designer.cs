namespace VehicleRentalSystem.views.Company
{
    partial class CompanysVehiclesPage
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
            this.groupListCompanysVehicles = new System.Windows.Forms.GroupBox();
            this.btnListCompanysVehicle = new System.Windows.Forms.Button();
            this.dataGVCompanysVehicles = new System.Windows.Forms.DataGridView();
            this.groupListCompanysVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCompanysVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupListCompanysVehicles
            // 
            this.groupListCompanysVehicles.Controls.Add(this.btnListCompanysVehicle);
            this.groupListCompanysVehicles.Controls.Add(this.dataGVCompanysVehicles);
            this.groupListCompanysVehicles.Location = new System.Drawing.Point(12, 12);
            this.groupListCompanysVehicles.Name = "groupListCompanysVehicles";
            this.groupListCompanysVehicles.Size = new System.Drawing.Size(461, 431);
            this.groupListCompanysVehicles.TabIndex = 10;
            this.groupListCompanysVehicles.TabStop = false;
            this.groupListCompanysVehicles.Text = "List Company\'s Vehicles";
            // 
            // btnListCompanysVehicle
            // 
            this.btnListCompanysVehicle.Location = new System.Drawing.Point(150, 364);
            this.btnListCompanysVehicle.Name = "btnListCompanysVehicle";
            this.btnListCompanysVehicle.Size = new System.Drawing.Size(150, 23);
            this.btnListCompanysVehicle.TabIndex = 3;
            this.btnListCompanysVehicle.Text = "Refresh List";
            this.btnListCompanysVehicle.UseVisualStyleBackColor = true;
            this.btnListCompanysVehicle.Click += new System.EventHandler(this.BtnListCompanysVehicle_Click);
            // 
            // dataGVCompanysVehicles
            // 
            this.dataGVCompanysVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCompanysVehicles.Location = new System.Drawing.Point(6, 19);
            this.dataGVCompanysVehicles.Name = "dataGVCompanysVehicles";
            this.dataGVCompanysVehicles.Size = new System.Drawing.Size(449, 299);
            this.dataGVCompanysVehicles.TabIndex = 0;
            // 
            // CompanysVehiclesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 453);
            this.Controls.Add(this.groupListCompanysVehicles);
            this.Name = "CompanysVehiclesPage";
            this.Text = "Company\'s Vehicles Page";
            this.Load += new System.EventHandler(this.CompanysVehiclesPage_Load);
            this.groupListCompanysVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCompanysVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupListCompanysVehicles;
        private System.Windows.Forms.Button btnListCompanysVehicle;
        private System.Windows.Forms.DataGridView dataGVCompanysVehicles;
    }
}