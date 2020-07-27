using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using System.Windows.Forms;


namespace Ex3.WindowsUI
{
    public partial class StatusRequestForm : Form
    {
        private string m_VehicleStatus;

        public StatusRequestForm()
        {
            m_VehicleStatus = GarageSystem.EnumToString(typeof(Vehicle.VehicleStatus.eVehicleStatus));
            initializeComponent();
        }

        public int ComboBoxVehicleStatus
        {
            get
            {
                return comboBoxVehicleStatus.SelectedIndex;
            }
        }

        public Button _buttonOK
        {
            get
            {
                return buttonOK;
            }
        }

        private void initializeComponent()
        {
            int currentPositionInVehicleStatusStr = 2;

            labelVehicleStatus = new System.Windows.Forms.Label();
            comboBoxVehicleStatus = new System.Windows.Forms.ComboBox();
            buttonCancel = new System.Windows.Forms.Button();
            buttonOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelVehicleType
            // 
            labelVehicleStatus.AutoSize = true;
            labelVehicleStatus.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelVehicleStatus.Location = new System.Drawing.Point(12, 59);
            labelVehicleStatus.Name = "VehicleStatus";
            labelVehicleStatus.Size = new System.Drawing.Size(140, 19);
            labelVehicleStatus.TabIndex = 0;
            labelVehicleStatus.Text = "Vehicle Status:";
            // 
            // comboBoxVehicleType
            // 
            comboBoxVehicleStatus.Location = new System.Drawing.Point(153, 59);
            comboBoxVehicleStatus.Name = "comboBoxVehicleStatus";
            comboBoxVehicleStatus.Size = new System.Drawing.Size(190, 22);
            comboBoxVehicleStatus.TabIndex = 1;
            int curretnLabel = 0;
            while (currentPositionInVehicleStatusStr < m_VehicleStatus.Length)
            {
                int indexOfEnter = m_VehicleStatus.IndexOf(".",currentPositionInVehicleStatusStr);
                if (indexOfEnter == -1)
                {
                    indexOfEnter = m_VehicleStatus.Length +2;
                }
                string currentStatus = m_VehicleStatus.Substring(currentPositionInVehicleStatusStr, indexOfEnter - 2 - currentPositionInVehicleStatusStr);
                comboBoxVehicleStatus.Items.Insert(curretnLabel, currentStatus);
                curretnLabel++;
                currentPositionInVehicleStatusStr += currentStatus.Length + 3;
            }
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(287, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += ButtonCancel_Click;

            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 31);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += ButtonOK_Click;

            this.AcceptButton = this.buttonOK;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = this.buttonCancel;
            ClientSize = new System.Drawing.Size(411, 182);
            Controls.Add(this.buttonOK);
            Controls.Add(this.buttonCancel);
            Controls.Add(this.labelVehicleStatus);
            Controls.Add(this.comboBoxVehicleStatus);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VehicleStatusForm";
            Text = "Vehicle Status";
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxVehicleStatus.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private System.Windows.Forms.Label labelVehicleStatus;
        private System.Windows.Forms.ComboBox comboBoxVehicleStatus;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}
