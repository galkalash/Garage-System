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
    public partial class LicennseNumberRequestForm : Form
    {
        public LicennseNumberRequestForm()
        {
            InitializeComponent();
        }

        public string LicennseNumber
        {
            get
            {
                return textBoxLicennseNumber.Text;
            }
        }

        public Button _buttonOK
        {
            get
            {
                return buttonOK;
            }
        }

    }
}
