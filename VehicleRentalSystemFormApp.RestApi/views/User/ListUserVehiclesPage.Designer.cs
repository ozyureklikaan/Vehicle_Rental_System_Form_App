namespace VehicleRentalSystemFormApp.RestApi.views.User
{
    partial class ListUserVehiclesPage
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
            this.groupListUserVehicles = new System.Windows.Forms.GroupBox();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.dataGVListUserVehicles = new System.Windows.Forms.DataGridView();
            this.groupListUserVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListUserVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupListUserVehicles
            // 
            this.groupListUserVehicles.Controls.Add(this.btnRefreshList);
            this.groupListUserVehicles.Controls.Add(this.dataGVListUserVehicles);
            this.groupListUserVehicles.Location = new System.Drawing.Point(12, 12);
            this.groupListUserVehicles.Name = "groupListUserVehicles";
            this.groupListUserVehicles.Size = new System.Drawing.Size(461, 391);
            this.groupListUserVehicles.TabIndex = 10;
            this.groupListUserVehicles.TabStop = false;
            this.groupListUserVehicles.Text = "List My Vehicles";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(150, 328);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(150, 23);
            this.btnRefreshList.TabIndex = 3;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // dataGVListUserVehicles
            // 
            this.dataGVListUserVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListUserVehicles.Location = new System.Drawing.Point(6, 19);
            this.dataGVListUserVehicles.Name = "dataGVListUserVehicles";
            this.dataGVListUserVehicles.Size = new System.Drawing.Size(449, 234);
            this.dataGVListUserVehicles.TabIndex = 0;
            // 
            // ListUserVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 413);
            this.Controls.Add(this.groupListUserVehicles);
            this.Name = "ListUserVehicles";
            this.Text = "ListUserVehicles";
            this.Load += new System.EventHandler(this.ListUserVehicles_Load);
            this.groupListUserVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListUserVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupListUserVehicles;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.DataGridView dataGVListUserVehicles;
    }
}