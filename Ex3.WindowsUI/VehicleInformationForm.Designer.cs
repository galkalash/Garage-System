using System.Windows.Forms;
namespace Ex3.WindowsUI
{
    partial class VehicleInformationForm
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
            this.SuspendLayout();
            this.Name = "VehicleInformationForm";
            this.Text = "VehicleInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            updateLabels();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(this.m_vehicleInformationLabels[1].Right + 30, this.m_vehicleInformationLabels[m_vehicleInformationLabels.Count-1].Bottom+5);
        }

        private void ButtonOK_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void updateLabels()
        {
            int indexInVehiclesToShowStr = 0;
            int i = 0;
            while (indexInVehiclesToShowStr <= m_vehicleInformation.Length)
            {
                m_vehicleInformationLabels.Add(new Label());
                int indexOfEndWord = m_vehicleInformation.IndexOf(":", indexInVehiclesToShowStr);
                indexOfEndWord++;
                if (indexOfEndWord == -1)
                {
                    indexOfEndWord = m_vehicleInformation.Length;
                }
                string currentStatus = m_vehicleInformation.Substring(indexInVehiclesToShowStr, indexOfEndWord - indexInVehiclesToShowStr);
                m_vehicleInformationLabels[i].Text = currentStatus;

                indexInVehiclesToShowStr = indexOfEndWord;
                if (i == 0)
                {
                    m_vehicleInformationLabels[i].Top = this.Top + 5;
                }
                else
                {
                    m_vehicleInformationLabels[i].Top = m_vehicleInformationLabels[i - 2].Bottom + 5;
                }
                m_vehicleInformationLabels[i].Left = this.Left + 5;

                m_vehicleInformationLabels[i].Size = new System.Drawing.Size(190, 30);
                m_vehicleInformationLabels[i].Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                m_vehicleInformationLabels[i].AutoSize = true;
                Controls.Add(m_vehicleInformationLabels[i]);
                i++;

                m_vehicleInformationLabels.Add(new Label());
                int indexOfEnter = m_vehicleInformation.IndexOf("\r\n", indexInVehiclesToShowStr);
                if (indexOfEnter == -1)
                {
                    indexOfEnter = m_vehicleInformation.Length;
                }
                string currentWord = m_vehicleInformation.Substring(indexInVehiclesToShowStr, indexOfEnter - indexInVehiclesToShowStr);
                m_vehicleInformationLabels[i].Text = currentWord;

                indexInVehiclesToShowStr = indexOfEnter + 2;
                if (i == 1)
                {
                    m_vehicleInformationLabels[i].Top = this.Top + 5;
                }
                else
                {
                    m_vehicleInformationLabels[i].Top = m_vehicleInformationLabels[i - 2].Bottom + 5;
                }
                m_vehicleInformationLabels[i].Left = this.Left + 350;
                m_vehicleInformationLabels[i].Size = new System.Drawing.Size(190, 30);
                m_vehicleInformationLabels[i].Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                m_vehicleInformationLabels[i].AutoSize = true;
                Controls.Add(m_vehicleInformationLabels[i]);
                i++;
            }
        }

        #endregion

    }
}