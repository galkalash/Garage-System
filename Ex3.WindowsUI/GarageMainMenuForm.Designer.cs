namespace Ex3.WindowsUI
{
    partial class GarageMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarageMainMenuForm));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAddNewVehicle = new System.Windows.Forms.Button();
            this.buttonRefuelingAVehicle = new System.Windows.Forms.Button();
            this.buttonVehicleInformation = new System.Windows.Forms.Button();
            this.buttonUpdateVehicleStatus = new System.Windows.Forms.Button();
            this.buttonShowVehicles = new System.Windows.Forms.Button();
            this.buttonInflatingVehicleWheels = new System.Windows.Forms.Button();
            this.buttonChargeVehicleBattery = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWelcome.Font = new System.Drawing.Font("Narkisim", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(70, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(507, 47);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To The Garage";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // buttonAddNewVehicle
            // 
            this.buttonAddNewVehicle.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddNewVehicle.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewVehicle.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNewVehicle.Image")));
            this.buttonAddNewVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewVehicle.Location = new System.Drawing.Point(32, 107);
            this.buttonAddNewVehicle.Name = "buttonAddNewVehicle";
            this.buttonAddNewVehicle.Size = new System.Drawing.Size(294, 52);
            this.buttonAddNewVehicle.TabIndex = 1;
            this.buttonAddNewVehicle.Text = "Add New Vehicle       ";
            this.buttonAddNewVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNewVehicle.UseVisualStyleBackColor = false;
            // 
            // buttonRefuelingAVehicle
            // 
            this.buttonRefuelingAVehicle.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonRefuelingAVehicle.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefuelingAVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefuelingAVehicle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefuelingAVehicle.Image")));
            this.buttonRefuelingAVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefuelingAVehicle.Location = new System.Drawing.Point(354, 182);
            this.buttonRefuelingAVehicle.Name = "buttonRefuelingAVehicle";
            this.buttonRefuelingAVehicle.Size = new System.Drawing.Size(294, 52);
            this.buttonRefuelingAVehicle.TabIndex = 2;
            this.buttonRefuelingAVehicle.Text = "Refueling Vehicle        ";
            this.buttonRefuelingAVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefuelingAVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefuelingAVehicle.UseVisualStyleBackColor = false;
            // 
            // buttonVehicleInformation
            // 
            this.buttonVehicleInformation.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonVehicleInformation.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVehicleInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonVehicleInformation.Image")));
            this.buttonVehicleInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVehicleInformation.Location = new System.Drawing.Point(32, 335);
            this.buttonVehicleInformation.Name = "buttonVehicleInformation";
            this.buttonVehicleInformation.Size = new System.Drawing.Size(285, 52);
            this.buttonVehicleInformation.TabIndex = 3;
            this.buttonVehicleInformation.Text = "Vehicle Information     ";
            this.buttonVehicleInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVehicleInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVehicleInformation.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateVehicleStatus
            // 
            this.buttonUpdateVehicleStatus.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonUpdateVehicleStatus.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateVehicleStatus.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateVehicleStatus.Image")));
            this.buttonUpdateVehicleStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateVehicleStatus.Location = new System.Drawing.Point(32, 257);
            this.buttonUpdateVehicleStatus.Name = "buttonUpdateVehicleStatus";
            this.buttonUpdateVehicleStatus.Size = new System.Drawing.Size(285, 52);
            this.buttonUpdateVehicleStatus.TabIndex = 4;
            this.buttonUpdateVehicleStatus.Text = "Update Vehicle Status  ";
            this.buttonUpdateVehicleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateVehicleStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdateVehicleStatus.UseVisualStyleBackColor = false;
            // 
            // buttonShowVehicles
            // 
            this.buttonShowVehicles.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonShowVehicles.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowVehicles.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowVehicles.Image")));
            this.buttonShowVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowVehicles.Location = new System.Drawing.Point(32, 182);
            this.buttonShowVehicles.Name = "buttonShowVehicles";
            this.buttonShowVehicles.Size = new System.Drawing.Size(285, 52);
            this.buttonShowVehicles.TabIndex = 5;
            this.buttonShowVehicles.Text = "Show All Vehicles       ";
            this.buttonShowVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowVehicles.UseVisualStyleBackColor = false;
            // 
            // buttonInflatingVehicleWheels
            // 
            this.buttonInflatingVehicleWheels.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInflatingVehicleWheels.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInflatingVehicleWheels.Image = ((System.Drawing.Image)(resources.GetObject("buttonInflatingVehicleWheels.Image")));
            this.buttonInflatingVehicleWheels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInflatingVehicleWheels.Location = new System.Drawing.Point(354, 107);
            this.buttonInflatingVehicleWheels.Name = "buttonInflatingVehicleWheels";
            this.buttonInflatingVehicleWheels.Size = new System.Drawing.Size(294, 52);
            this.buttonInflatingVehicleWheels.TabIndex = 6;
            this.buttonInflatingVehicleWheels.Text = "Inflating Vehicle Wheels";
            this.buttonInflatingVehicleWheels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInflatingVehicleWheels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInflatingVehicleWheels.UseVisualStyleBackColor = false;
            // 
            // buttonChargeVehicleBattery
            // 
            this.buttonChargeVehicleBattery.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonChargeVehicleBattery.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChargeVehicleBattery.Image = ((System.Drawing.Image)(resources.GetObject("buttonChargeVehicleBattery.Image")));
            this.buttonChargeVehicleBattery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChargeVehicleBattery.Location = new System.Drawing.Point(354, 257);
            this.buttonChargeVehicleBattery.Name = "buttonChargeVehicleBattery";
            this.buttonChargeVehicleBattery.Size = new System.Drawing.Size(294, 52);
            this.buttonChargeVehicleBattery.TabIndex = 7;
            this.buttonChargeVehicleBattery.Text = "Charge Vehicle           ";
            this.buttonChargeVehicleBattery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChargeVehicleBattery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChargeVehicleBattery.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(354, 335);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(294, 52);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit                           ";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // GarageMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(682, 427);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChargeVehicleBattery);
            this.Controls.Add(this.buttonInflatingVehicleWheels);
            this.Controls.Add(this.buttonShowVehicles);
            this.Controls.Add(this.buttonUpdateVehicleStatus);
            this.Controls.Add(this.buttonVehicleInformation);
            this.Controls.Add(this.buttonRefuelingAVehicle);
            this.Controls.Add(this.buttonAddNewVehicle);
            this.Controls.Add(this.labelWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GarageMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAddNewVehicle;
        private System.Windows.Forms.Button buttonRefuelingAVehicle;
        private System.Windows.Forms.Button buttonVehicleInformation;
        private System.Windows.Forms.Button buttonUpdateVehicleStatus;
        private System.Windows.Forms.Button buttonShowVehicles;
        private System.Windows.Forms.Button buttonInflatingVehicleWheels;
        private System.Windows.Forms.Button buttonChargeVehicleBattery;
        private System.Windows.Forms.Button buttonExit;
    }
}