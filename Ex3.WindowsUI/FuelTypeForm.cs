using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.WindowsUI
{
    public class FuelTypeForm : Form
    {

        private string m_FuelTypes;

        public FuelTypeForm(string i_FuelTypesStr)
        {
            m_FuelTypes = i_FuelTypesStr;
            initializeComponent();
        }

        public int ComboBoxFuelTypes
        {
            get
            {
                return comboBoxFuelTypes.SelectedIndex;
            }
        }

        public Button _buttonOK
        {
            get
            {
                return buttonOK;
            }
        }

        public string _textBoxLiters
        {
            get
            {
                return textBoxLiters.Text;
            }
        }

        private void initializeComponent()
        {
            int currentPositionInFuelTypesStr =2;

            labelFuelTypes = new System.Windows.Forms.Label();
            comboBoxFuelTypes = new System.Windows.Forms.ComboBox();
            buttonCancel = new System.Windows.Forms.Button();
            labelLiters = new System.Windows.Forms.Label();
            textBoxLiters = new System.Windows.Forms.TextBox();
            buttonOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelVehicleType
            // 
            labelFuelTypes.AutoSize = true;
            labelFuelTypes.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelFuelTypes.Location = new System.Drawing.Point(12, 30);
            labelFuelTypes.Name = "VehicleType";
            labelFuelTypes.Size = new System.Drawing.Size(140, 19);
            labelFuelTypes.TabIndex = 0;
            labelFuelTypes.Text = "Vehicle Type:";
            // 
            // comboBoxVehicleType
            // 
            comboBoxFuelTypes.Location = new System.Drawing.Point(153, 30);
            comboBoxFuelTypes.Name = "comboBoxVehicleType";
            comboBoxFuelTypes.Size = new System.Drawing.Size(190, 22);
            comboBoxFuelTypes.TabIndex = 1;
            int curretnLabel = 0;
            while (currentPositionInFuelTypesStr < m_FuelTypes.Length)
            {
                int indexOfEnter = m_FuelTypes.IndexOf(" ", currentPositionInFuelTypesStr);
                if (indexOfEnter == -1)
                {
                    indexOfEnter = m_FuelTypes.Length;
                }
                string currentType = m_FuelTypes.Substring(currentPositionInFuelTypesStr, indexOfEnter - currentPositionInFuelTypesStr);
                comboBoxFuelTypes.Items.Insert(curretnLabel, currentType);
                curretnLabel++;
                currentPositionInFuelTypesStr += currentType.Length + 3;
            }
            // 
            // labelVehicleType
            // 
            labelLiters.AutoSize = true;
            labelLiters.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelLiters.Location = new System.Drawing.Point(12, 80);
            labelLiters.Name = "Liters";
            labelLiters.Size = new System.Drawing.Size(140, 19);
            labelLiters.TabIndex = 0;
            labelLiters.Text = "Liters:";
            // 
            // textBoxLiters
            //
            textBoxLiters.Location = new System.Drawing.Point(153,80);
            textBoxLiters.Size = new System.Drawing.Size(190, 22);
            textBoxLiters.Name = "textBoxLiters";
            labelLiters.TabIndex = 2;
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

            this.AcceptButton = this.buttonOK;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = this.buttonCancel;
            ClientSize = new System.Drawing.Size(411, 182);
            Controls.Add(this.buttonOK);
            Controls.Add(this.buttonCancel);
            Controls.Add(this.labelFuelTypes);
            Controls.Add(this.labelLiters);
            Controls.Add(this.textBoxLiters);
            Controls.Add(this.comboBoxFuelTypes);
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


        private System.Windows.Forms.Label labelFuelTypes;
        private System.Windows.Forms.ComboBox comboBoxFuelTypes;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}
