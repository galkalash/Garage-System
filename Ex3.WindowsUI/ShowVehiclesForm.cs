using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.WindowsUI
{
    public class ShowVehiclesForm : Form
    {
        private string m_VehiclesToShow;
        private List<Label> m_LabelsVehiclesToShow;

        public ShowVehiclesForm(string i_VehiclesToShow)
        {
            m_VehiclesToShow = i_VehiclesToShow;
            m_LabelsVehiclesToShow = new List<Label>();
            initializeComponent();
        }

        public void initializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NewVehicleInformationForm";
            Text = "Vehicle Information";
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
            updatLabels();
            this.ClientSize = new System.Drawing.Size(m_LabelsVehiclesToShow[m_LabelsVehiclesToShow.Count - 1].Right +200, m_LabelsVehiclesToShow[m_LabelsVehiclesToShow.Count - 1].Bottom + 20);
        }

        private void updatLabels()
        {
            int indexInVehiclesToShowStr = 0;
            int i = 0;
            while (indexInVehiclesToShowStr <= m_VehiclesToShow.Length)
            {
                m_LabelsVehiclesToShow.Add(new Label());
                int indexOfEnter = m_VehiclesToShow.IndexOf("\r\n", indexInVehiclesToShowStr);
                if (indexOfEnter == -1)
                {
                    indexOfEnter = m_VehiclesToShow.Length;
                }
                string currentStatus = m_VehiclesToShow.Substring(indexInVehiclesToShowStr, indexOfEnter - indexInVehiclesToShowStr);
                m_LabelsVehiclesToShow[i].Text = currentStatus;
               
                indexInVehiclesToShowStr = indexOfEnter + 2;
                if (i == 0)
                {
                    m_LabelsVehiclesToShow[i].Top = this.Top + 5;
                }
                else
                {
                    m_LabelsVehiclesToShow[i].Top = m_LabelsVehiclesToShow[i - 1].Bottom + 2;
                }
                m_LabelsVehiclesToShow[i].Left = this.Left + 5;
                m_LabelsVehiclesToShow[i].Size = new System.Drawing.Size(190, 30);
                m_LabelsVehiclesToShow[i].Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                m_LabelsVehiclesToShow[i].AutoSize = true;
                Controls.Add(m_LabelsVehiclesToShow[i]);
                i++;
            }
        }
    }
}
