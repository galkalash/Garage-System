using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.WindowsUI
{
    public partial class VehicleInformationForm : Form
    {
        private string m_vehicleInformation;
        private List<Label> m_vehicleInformationLabels;
        public VehicleInformationForm(string i_vehicleInformation)
        {
            m_vehicleInformation = i_vehicleInformation;
            m_vehicleInformationLabels = new List<Label>();
            InitializeComponent();
        }
    }
}
