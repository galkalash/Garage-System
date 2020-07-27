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
    public partial class GarageMainMenuForm : Form
    {
        public GarageMainMenuForm()
        {
            InitializeComponent();
        }

        public Button _buttonAddNewVehicle
        {
            get
            {
                return buttonAddNewVehicle;
            }
        }

        public Button _buttonUpdateVehicleStatus
        {
            get
            {
                return buttonUpdateVehicleStatus;
            }
        }

        public Button _buttonShowVehicles
        {
            get
            {
                return buttonShowVehicles;
            }
        }

        public Button _buttonExit
        {
            get
            {
                return buttonExit;
            }
        }

        public Button _buttonVehicleInformation
        {
            get
            {
                return buttonVehicleInformation;
            }
        }

        public Button _buttonRefuelingAVehicle
        {
            get
            {
                return buttonRefuelingAVehicle;
            }
        }

        public Button _buttonInflatingVehicleWheels
        {
            get
            {
                return buttonInflatingVehicleWheels;
            }
        }

        public Button _buttonChargeVehicleBattery
        {
            get
            {
                return buttonChargeVehicleBattery;
            }
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
