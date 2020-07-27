using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SupportedVehicles = Ex03.GarageLogic.CreatingNewVehicle.SupportedVehicles;
using Ex03.GarageLogic;
using System.IO;

namespace Ex3.WindowsUI
{
    public class WindowsUIGarageSystem
    {
        private GarageSystem m_GarageSystem;
        private LicennseNumberRequestForm m_CurrentlicennseNumberRequest;
        private NewVehicleInformationForm m_NewVehicleInformationForm;
        private Vehicle m_NewVehicleToAdd;
        private StatusRequestForm m_StatusRequestForm;
        private VehicleTypesForm m_VehicleTypesForm;
        private FuelTypeForm m_FuelTypeForm;
        private MinutesToCharg m_MinutesToCharg;

        public WindowsUIGarageSystem()
        {
            m_GarageSystem = new GarageSystem();
            readFromFile();
        }

        public GarageSystem GarageSystem
        {
            get
            {
                return m_GarageSystem;
            }
        }

        public void RunGarageSystem()
        {
            GarageMainMenuForm garageMainMenu = new GarageMainMenuForm();
            garageMainMenu.FormClosing += GarageMainMenu_FormClosing;
            garageMainMenu._buttonAddNewVehicle.Click += _buttonAddNewVehicle_Click;
            garageMainMenu._buttonShowVehicles.Click += _buttonShowVehicles_Click;
            garageMainMenu._buttonUpdateVehicleStatus.Click += _buttonUpdateVehicleStatus_Click;
            garageMainMenu._buttonVehicleInformation.Click += _buttonVehicleInformation_Click;
            garageMainMenu._buttonRefuelingAVehicle.Click += _buttonRefuelingAVehicle_Click;
            garageMainMenu._buttonInflatingVehicleWheels.Click += _buttonInflatingVehicleWheels_Click;
            garageMainMenu._buttonChargeVehicleBattery.Click += _buttonChargeVehicleBattery_Click;
            garageMainMenu._buttonExit.Click += _buttonExit_Click;
            garageMainMenu.ShowDialog();
        }

        private void _buttonAddNewVehicle_Click(object sender, EventArgs e)
        {
            string licennseNumber = LicennseNumberRequest(false);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                m_VehicleTypesForm = new VehicleTypesForm();
                while (m_VehicleTypesForm.DialogResult != DialogResult.Cancel && m_VehicleTypesForm.DialogResult != DialogResult.OK)
                {
                    m_VehicleTypesForm.ShowDialog();
                }
                if (m_VehicleTypesForm.DialogResult != DialogResult.Cancel)
                {
                    int userVehicleType = m_VehicleTypesForm.ComboBoxVehicleType + 1;
                    SupportedVehicles.eSupportedVehicles userVehicleTypeChoice = SupportedVehicles.ParseFromString(userVehicleType.ToString());
                    m_NewVehicleToAdd = CreatingNewVehicle.CreatingNewVehicleToGarage(licennseNumber, userVehicleTypeChoice);
                    List<string> informatinMessage = m_NewVehicleToAdd.InformationMessages;
                    m_NewVehicleInformationForm = new NewVehicleInformationForm(informatinMessage);
                    m_NewVehicleInformationForm._buttonOK.Click += _buttonOKNewVehicleI_Click;
                    while (m_NewVehicleInformationForm.DialogResult != DialogResult.OK &&
                        m_NewVehicleInformationForm.DialogResult != DialogResult.Cancel)
                    {
                        m_NewVehicleInformationForm.ShowDialog();
                        if (m_NewVehicleInformationForm.DialogResult != DialogResult.Cancel)
                        {
                            m_GarageSystem.AddVehicleToGarageSystem(m_NewVehicleToAdd);
                            MessageBox.Show("The vehicle was successfully added to the garage system.", "Success!", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void _buttonShowVehicles_Click(object sender, EventArgs e)
        {
            m_StatusRequestForm = new StatusRequestForm();
            m_StatusRequestForm.ShowDialog();
            if (m_StatusRequestForm.DialogResult != DialogResult.Cancel)
            {
                int userStatusChoice = m_StatusRequestForm.ComboBoxVehicleStatus + 1;
                string vehicleToShow = m_GarageSystem.GetVehiclesLicenseMessageByChoice(userStatusChoice.ToString());
                if (vehicleToShow == null)
                {
                    MessageBox.Show("There are no vehicles in status " +
                    Vehicle.VehicleStatus.ParseFromString(userStatusChoice.ToString()), "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    ShowVehiclesForm showVehiclesForm = new ShowVehiclesForm(vehicleToShow);
                    showVehiclesForm.ShowDialog();
                }
            }

        }

        private void _buttonUpdateVehicleStatus_Click(object sender, EventArgs e)
        {
            string licennseNumber = LicennseNumberRequest(true);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                m_StatusRequestForm = new StatusRequestForm();
                m_StatusRequestForm.ShowDialog();
                if (m_StatusRequestForm.DialogResult != DialogResult.Cancel)
                {
                    int userStatusChoice = m_StatusRequestForm.ComboBoxVehicleStatus + 1;
                    string updateMessage = m_GarageSystem.UpdateVehicleStatus(licennseNumber, userStatusChoice.ToString());
                    MessageBox.Show(updateMessage, "Success", MessageBoxButtons.OK);
                }
            }
        }

        private void _buttonVehicleInformation_Click(object sender, EventArgs e)
        {
            string licennseNumber = LicennseNumberRequest(true);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                string licennseinformation = m_GarageSystem.GetVehicleInformation(licennseNumber);
                VehicleInformationForm vehicleInformationForm = new VehicleInformationForm(licennseinformation);
                vehicleInformationForm.ShowDialog();
            }
        }

        private void _buttonOKNewVehicleI_Click(object sender, EventArgs e)
        {
            if (checkInformation() == true)
            {
                m_NewVehicleInformationForm.DialogResult = DialogResult.OK;
                m_NewVehicleInformationForm.Close();
            }
        }

        private void _buttonRefuelingAVehicle_Click(object sender, EventArgs e)
        {
            string LisennseNumber = LicennseNumberRequest(true);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                RefuelingAVehicle(); 
            }
        }

        private void _buttonInflatingVehicleWheels_Click(object sender, EventArgs e)
        {
            string LisennseNumber = LicennseNumberRequest(true);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                MessageBox.Show(m_GarageSystem.InflatingVehicleWheelsToMaximum(LisennseNumber), "ERROR", MessageBoxButtons.OK);
            }
        }

        private void _buttonChargeVehicleBattery_Click(object sender, EventArgs e)
        {
            string LisennseNumber = LicennseNumberRequest(true);
            if (m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
            {
                m_MinutesToCharg = new MinutesToCharg();
                m_MinutesToCharg._buttonOK.Click += _buttonOKcharging_Click;
                while (m_MinutesToCharg.DialogResult != DialogResult.Cancel && m_MinutesToCharg.DialogResult != DialogResult.OK)
                {
                    m_MinutesToCharg.ShowDialog();
                }
            }
        }

        private void _buttonOKcharging_Click(object sender, EventArgs e)
        {
            try
            {
                string loadMessage = m_GarageSystem.LoadVehicleBattery(m_CurrentlicennseNumberRequest.LicennseNumber, m_MinutesToCharg._textBoxMinuteToCharg);
                MessageBox.Show(loadMessage, "Success", MessageBoxButtons.OK);
                m_MinutesToCharg.DialogResult = DialogResult.OK;
                m_MinutesToCharg.Close();
            }
            catch (FormatException FormatEx)
            {
                MessageBox.Show("Invalid input format, please try again.", "ERROR", MessageBoxButtons.OK);
                m_MinutesToCharg.DialogResult = DialogResult.No;                
            }
            catch (ArgumentException ArgumentEx)
            {
                MessageBox.Show(ArgumentEx.Message, "ERROR", MessageBoxButtons.OK);
                m_MinutesToCharg.DialogResult = DialogResult.Cancel;
            }
            catch (ValueOutOfRangeException RangeEx)
            {
                MessageBox.Show(RangeEx.Message, "ERROR", MessageBoxButtons.OK);
                m_MinutesToCharg.DialogResult = DialogResult.No;
            }
            catch (Exception InvalidEX)
            {
                MessageBox.Show("invalid input, please try again.", "ERROR", MessageBoxButtons.OK);
                m_MinutesToCharg.DialogResult = DialogResult.No;
            }
        }

        private void _buttonExit_Click(object sender, EventArgs e)
        {
            writeToFile();
        }

        private void GarageMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeToFile();
        }

        public bool checkInformation()
        {
            bool isValidVehicl = true;
            for (int i = 0; i < m_NewVehicleInformationForm.InformationTextBoxses.Length; i++)
            {
                try
                {
                    m_NewVehicleToAdd.CheckAndUpdateInformation(m_NewVehicleInformationForm.InformationTextBoxses[i].Text, i);

                }
                catch (ValueOutOfRangeException RangEX)
                {
                    MessageBox.Show(RangEX.Message, "ERROR- " + m_NewVehicleInformationForm.InformationLabelsStrings[i], MessageBoxButtons.OK);
                    isValidVehicl = false;
                }
                catch (FormatException FormatEx)
                {
                    MessageBox.Show("Invalid input format, please try again.", "ERROR - " + m_NewVehicleInformationForm.InformationLabelsStrings[i], MessageBoxButtons.OK);
                    isValidVehicl = false;
                }
                catch (Exception InvalidEx)
                {
                    MessageBox.Show("invalid input, please try again.", "ERROR- " + m_NewVehicleInformationForm.InformationLabelsStrings[i], MessageBoxButtons.OK);
                    isValidVehicl = false;
                }
            }
            return isValidVehicl;
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
            bool isValidLicenseNumber;
            bool isExistLicenseNumber = getVehicleLicenseNumberStrFromUser(m_CurrentlicennseNumberRequest.LicennseNumber, out isValidLicenseNumber);

            if (isValidLicenseNumber == true)
            {
                if (isExistLicenseNumber == true)
                {
                    m_CurrentlicennseNumberRequest.DialogResult = DialogResult.Yes;
                }
                else
                {
                    m_CurrentlicennseNumberRequest.DialogResult = DialogResult.No;
                }
            }
        }

        public bool getVehicleLicenseNumberStrFromUser(string i_LicenseNumberToReturn, out bool o_IsValidLicenseNumber)
        {
            bool isExistLicenseNumber = false;
            o_IsValidLicenseNumber = false;

            try
            {
                isExistLicenseNumber = m_GarageSystem.IsValidAndExistLicenseNumberStr(i_LicenseNumberToReturn);
                o_IsValidLicenseNumber = true;

            }
            catch (ValueOutOfRangeException RangEX)
            {
                MessageBox.Show(RangEX.Message, "ERROR", MessageBoxButtons.OK);
            }
            catch (FormatException FormatEx)
            {
                MessageBox.Show("Invalid input format, please try again.", "ERROR", MessageBoxButtons.OK);
            }
            catch (Exception InvalidEX)
            {
                MessageBox.Show("invalid input, please try again.", "ERROR", MessageBoxButtons.OK);
            }

            return isExistLicenseNumber;
        }

        public void readFromFile()
        {
            using (StreamReader garageData = File.OpenText("GarageData.txt")) 
            {
                string line;
                string numOfVehicles;
                line = garageData.ReadLine();
                if (line != null)
                {
                    numOfVehicles = line;
                    for (int i = 0; i < int.Parse(numOfVehicles); i++)
                    {
                        string LicennseNumber = garageData.ReadLine();
                        string userVehicleType = garageData.ReadLine();
                        string dataToUpdate;
                        SupportedVehicles.eSupportedVehicles userVehicleTypeChoice = SupportedVehicles.ParseFromString(userVehicleType);
                        m_NewVehicleToAdd = CreatingNewVehicle.CreatingNewVehicleToGarage(LicennseNumber, userVehicleTypeChoice);
                        List<string> informatinMessage = m_NewVehicleToAdd.InformationMessages;
                        for (int j = 0; j < informatinMessage.Count; j++)
                        {
                            dataToUpdate = garageData.ReadLine();
                            m_NewVehicleToAdd.CheckAndUpdateInformation(dataToUpdate, j);
                        }
                        dataToUpdate = garageData.ReadLine();
                        m_NewVehicleToAdd._VehicleStatus = Vehicle.VehicleStatus.ParseFromString(dataToUpdate);
                        m_GarageSystem.AddVehicleToGarageSystem(m_NewVehicleToAdd);
                    }
                }
            }  
        }

        public void writeToFile()
        {
            using (StreamWriter garageData = File.CreateText("GarageData.txt"))
            {
                garageData.WriteLine(m_GarageSystem.VehicleInTheGarage.Count);

                foreach (KeyValuePair<int, Vehicle> curVehicle in m_GarageSystem.VehicleInTheGarage)
                {
                    garageData.WriteLine(curVehicle.Value.LicennseNumber);
                    if (curVehicle.Value is Motorcycle)
                    {
                        if (curVehicle.Value.EnergySource is FuelTank)
                        {
                            garageData.WriteLine(SupportedVehicles.eSupportedVehicles.FuelMotorcycle.GetHashCode());
                        }
                        else
                        {
                            garageData.WriteLine(SupportedVehicles.eSupportedVehicles.ElectricMotorcycle.GetHashCode());
                        }
                    }
                    if (curVehicle.Value is Car)
                    {
                        if (curVehicle.Value.EnergySource is FuelTank)
                        {
                            garageData.WriteLine(SupportedVehicles.eSupportedVehicles.FuelCar.GetHashCode());
                        }
                        else
                        {
                            garageData.WriteLine(SupportedVehicles.eSupportedVehicles.ElectricCar.GetHashCode());
                        }
                    }
                    if (curVehicle.Value is Truck)
                    {
                        garageData.WriteLine(SupportedVehicles.eSupportedVehicles.FuelTruck.GetHashCode());
                    }

                    garageData.WriteLine(curVehicle.Value.OwnerName);
                    garageData.WriteLine(curVehicle.Value.OwnerPhoneNumber);
                    garageData.WriteLine(curVehicle.Value.ModelName);
                    garageData.WriteLine(curVehicle.Value.PrecentOfenergyRemaining);
                    garageData.WriteLine(curVehicle.Value.Wheels[0].CanufacturerName);
                    garageData.WriteLine(curVehicle.Value.Wheels[0].CurrentAirPressure);
                    if (curVehicle.Value is Motorcycle)
                    {
                        Motorcycle curMotorcycle = curVehicle.Value as Motorcycle;
                        garageData.WriteLine(curMotorcycle._LicenseType.GetHashCode());
                        garageData.WriteLine(curMotorcycle.EngineVolume);
                    }
                    else if (curVehicle.Value is Car)
                    {
                        Car curCar = curVehicle.Value as Car;
                        garageData.WriteLine(curCar._CarColor.GetHashCode());
                        garageData.WriteLine(curCar._NumOfCarDoors.GetHashCode());
                    }
                    else
                    {
                        Truck curTruck = curVehicle.Value as Truck;
                        if(curTruck.isTransportsDangerousMaterials == true)
                        {
                            garageData.WriteLine("1");
                        }
                        else
                        {
                            garageData.WriteLine("0");
                        }
                        garageData.WriteLine(curTruck.CargoVolume);
                    }
                    garageData.WriteLine(curVehicle.Value._VehicleStatus.GetHashCode());
                }
            }
        }

        private string LicennseNumberRequest(bool i_isExistRequest)
        {
            m_CurrentlicennseNumberRequest = new LicennseNumberRequestForm();
            m_CurrentlicennseNumberRequest._buttonOK.Click += _buttonOK_Click;
            if (i_isExistRequest == true)
            {
                while ((m_CurrentlicennseNumberRequest.DialogResult == DialogResult.No ||
                        m_CurrentlicennseNumberRequest.DialogResult == DialogResult.None)
                        && m_CurrentlicennseNumberRequest.DialogResult != DialogResult.Cancel)
                {
                    m_CurrentlicennseNumberRequest.ShowDialog();
                    if (m_CurrentlicennseNumberRequest.DialogResult == DialogResult.No)
                    {
                        MessageBox.Show("This license number does not exists in the system", "ERROR", MessageBoxButtons.OK);
                    }
                }
                
            }
            else
            {
                while (m_CurrentlicennseNumberRequest.DialogResult == DialogResult.Yes ||
                    m_CurrentlicennseNumberRequest.DialogResult == DialogResult.None)
                {
                    m_CurrentlicennseNumberRequest.ShowDialog();
                    if (m_CurrentlicennseNumberRequest.DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("This license number already exists in the system", "ERROR", MessageBoxButtons.OK);
                    }
                }
            }

            return m_CurrentlicennseNumberRequest.LicennseNumber;
        }

        private void RefuelingAVehicle()
        {
            int fuelType = -1;            
            try
            {
                m_GarageSystem.CheckingVehicleFuelTankInput(m_CurrentlicennseNumberRequest.LicennseNumber);
                string fuelTypsStr = m_GarageSystem.GetFuleTypeToFuelMessage();
                m_FuelTypeForm = new FuelTypeForm(fuelTypsStr);
                m_FuelTypeForm._buttonOK.Click += _buttonOKFuelType_Click1;
                while (m_FuelTypeForm.DialogResult != DialogResult.Cancel && m_FuelTypeForm.DialogResult != DialogResult.OK)
                {
                    m_FuelTypeForm.ShowDialog();
                    fuelType = m_FuelTypeForm.ComboBoxFuelTypes + 1;

                    if (fuelType != -1)
                    {
                        try
                        {
                            string refuelingMessage = m_GarageSystem.RefuelingAVehicle(m_CurrentlicennseNumberRequest.LicennseNumber, fuelType.ToString(), m_FuelTypeForm._textBoxLiters);
                            MessageBox.Show(refuelingMessage, "Success", MessageBoxButtons.OK);
                            m_FuelTypeForm.DialogResult = DialogResult.OK;
                        }
                        catch (FormatException FormatEx)
                        {
                            MessageBox.Show("Invalid input format, please try again.", "ERROR", MessageBoxButtons.OK);
                            m_FuelTypeForm.DialogResult = DialogResult.No;
                        }
                        catch (ValueOutOfRangeException RangeEx)
                        {
                            MessageBox.Show(RangeEx.Message, "ERROR", MessageBoxButtons.OK);
                            m_FuelTypeForm.DialogResult = DialogResult.No;
                        }
                        catch (Exception InvalidEX)
                        {
                            MessageBox.Show("invalid input.", "ERROR", MessageBoxButtons.OK);
                            m_FuelTypeForm.DialogResult = DialogResult.No;
                        }
                    }
                }
            }
            catch (ArgumentException ArgumentEx)
            {
                MessageBox.Show(ArgumentEx.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void _buttonOKFuelType_Click1(object sender, EventArgs e)
        {
            int fuelType = m_FuelTypeForm.ComboBoxFuelTypes + 1;
            try
            {
                m_GarageSystem.CheckingFuelTypeInput(m_CurrentlicennseNumberRequest.LicennseNumber, fuelType.ToString());
                m_FuelTypeForm.DialogResult = DialogResult.OK;
            }
            catch (ValueOutOfRangeException RangEx)
            {
                MessageBox.Show(RangEx.Message, "ERROR", MessageBoxButtons.OK);
                m_FuelTypeForm.DialogResult = DialogResult.None;
            }
            catch (FormatException FormatEx)
            {
                MessageBox.Show("Invalid input format, please try again", "ERROR", MessageBoxButtons.OK);
                m_FuelTypeForm.DialogResult = DialogResult.None;
            }
            catch (ArgumentException ArgumentEx)
            {
                MessageBox.Show(ArgumentEx.Message, "ERROR", MessageBoxButtons.OK);
                m_FuelTypeForm.DialogResult = DialogResult.None;
            }


        }
    }
}
