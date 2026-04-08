using Symphony_Orchestra.Instrument;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symphony_Orchestra
{
    public partial class INformation_of_instrument : Form
    {
        public INformation_of_instrument()
        {
            InitializeComponent();
        }
        public INformation_of_instrument(Instruments instrument)
        {
            InitializeComponent();
            label_name.Text = instrument.name.ToString();
            label_type.Text = instrument.type.ToString();
            label_year_manufactured.Text = instrument.year_manufactured.ToString();
            label_instrument_manufacturer.Text = instrument.instrument_manufacturer.ToString();
            label_serial_number.Text = instrument.serial_number.ToString();
        }
    }
}
