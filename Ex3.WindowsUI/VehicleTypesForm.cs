using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SupportedVehicles = Ex03.GarageLogic.CreatingNewVehicle.SupportedVehicles;

namespace Ex3.WindowsUI
{
    public class VehicleTypesForm : Form
    {
        private string m_VehicleTypes; 

        public VehicleTypesForm()
        { 
            m_VehicleTypes = SupportedVehicles.SupportedVehiclesToString();
            initializeComponent();
        }

        public int ComboBoxVehicleType
        {
            get
            {
                return comboBoxVehicleType.SelectedIndex;
            }
        }

        private void initializeComponent()
        {
            int currentPositionInVehicleTypesStr = 0;                 

            labelVehicleType = new System.Windows.Forms.Label();
            comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            buttonCancel = new System.Windows.Forms.Button();
            buttonOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelVehicleType
            // 
            labelVehicleType.AutoSize = true;
            labelVehicleType.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelVehicleType.Location = new System.Drawing.Point(12, 59);
            labelVehicleType.Name = "VehicleType";
            labelVehicleType.Size = new System.Drawing.Size(140, 19);
            labelVehicleType.TabIndex = 0;
            labelVehicleType.Text = "Vehicle Type:";
            // 
            // comboBoxVehicleType
            // 
            comboBoxVehicleType.Location = new System.Drawing.Point(153, 59);
            comboBoxVehicleType.Name = "comboBoxVehicleType";
            comboBoxVehicleType.Size = new System.Drawing.Size(190, 22);
            comboBoxVehicleType.TabIndex = 1;
            int curretnLabel = 0;
            while (currentPositionInVehicleTypesStr < m_VehicleTypes.Length)
            {
                int indexOfEnter = m_VehicleTypes.IndexOf("\r\n", currentPositionInVehicleTypesStr);
                if (indexOfEnter == -1)
                {
                    indexOfEnter = m_VehicleTypes.Length;
                }
                string currentType = m_VehicleTypes.Substring(currentPositionInVehicleTypesStr, indexOfEnter - currentPositionInVehicleTypesStr);
                comboBoxVehicleType.Items.Insert(curretnLabel, currentType);
                curretnLabel++;
                currentPositionInVehicleTypesStr += currentType.Length + 2;
            }
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(287, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 31);
            this.buttonOK.TabIndex = 3;
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
            Controls.Add(this.labelVehicleType);
            Controls.Add(this.comboBoxVehicleType);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VehicleTypesForm";
            Text = "Vehicle Types";
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;

    }
}
