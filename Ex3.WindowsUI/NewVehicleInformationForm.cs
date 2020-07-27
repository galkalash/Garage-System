using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.WindowsUI
{
    public class NewVehicleInformationForm : Form
    {
        private List<string> m_InformationLabelsStrings;
        private Label[] m_InformationLabels;
        private TextBox[] m_InformationTextBoxses;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;

        public NewVehicleInformationForm(List<string> i_InformationLabelsStrings)
        {
            m_InformationLabelsStrings = i_InformationLabelsStrings;
            m_InformationLabels = new Label[m_InformationLabelsStrings.Count];
            m_InformationTextBoxses = new TextBox[m_InformationLabelsStrings.Count];
            initializeComponent();
        }

        public TextBox[] InformationTextBoxses
        {
            get
            {
                return m_InformationTextBoxses;
            }
        }

        public List<string> InformationLabelsStrings
        {
            get
            {
                return m_InformationLabelsStrings;
            }
        }

        public Label[] InformationLabels
        {
            get
            {
                return m_InformationLabels;
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NewVehicleInformationForm";
            Text = "Vehicle Information";
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = buttonCancel;
            this.ResumeLayout(false);
            this.PerformLayout();
            updatLabels();
            updatTextBoxes();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(287, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.Top = m_InformationLabels[m_InformationLabels.Length - 1].Bottom + 10;
            this.buttonCancel.Left = m_InformationTextBoxses[m_InformationTextBoxses.Length - 1].Right - 112;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += ButtonCancel_Click;

            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.Top = m_InformationLabels[m_InformationLabels.Length - 1].Bottom + 10;
            this.buttonOK.Left = buttonCancel.Left - 110;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;

            Controls.Add(this.buttonOK);
            Controls.Add(this.buttonCancel);
            this.ClientSize = new System.Drawing.Size(m_InformationTextBoxses[0].Right + 10, buttonOK.Bottom + 10);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void updatLabels()
        {                 
            for (int i = 0; i < (m_InformationLabelsStrings.Count) ; i++)
            {
                m_InformationLabels[i] = new Label();
                m_InformationLabels[i].Text = m_InformationLabelsStrings[i];
                if (i == 0)
                {
                    m_InformationLabels[i].Top = this.Top + 10;
                }
                else
                {
                    m_InformationLabels[i].Top = m_InformationLabels[i - 1].Bottom + 30;
                }
                m_InformationLabels[i].Left = this.Left + 5;
                m_InformationLabels[i].Size = new System.Drawing.Size(190, 30);
                m_InformationLabels[i].Font = new System.Drawing.Font("Narkisim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                m_InformationLabels[i].AutoSize = true;
                Controls.Add(m_InformationLabels[i]);
            }
        }

        private void updatTextBoxes()
        {
            for (int i = 0; i < m_InformationLabelsStrings.Count; i++)
            {
                m_InformationTextBoxses[i] = new TextBox();
                if (i == 0)
                {
                    m_InformationTextBoxses[i].Top = this.Top + 10;
                }
                else
                {
                    m_InformationTextBoxses[i].Top = m_InformationLabels[i - 1].Bottom + 30;
                }
                m_InformationTextBoxses[i].Left = this.Left + 180;
                m_InformationTextBoxses[i].Size = new System.Drawing.Size(190, 30);
                m_InformationTextBoxses[i].TabIndex = i;
                Controls.Add(m_InformationTextBoxses[i]);
            }
        }
    }
}
