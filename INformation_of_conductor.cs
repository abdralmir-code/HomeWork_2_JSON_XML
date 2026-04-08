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
    public partial class INformation_of_conductor : Form
    {
        public INformation_of_conductor()
        {
            InitializeComponent();
        }

        private void INformation_of_conductor_Load(object sender, EventArgs e)
        {

        }
        public INformation_of_conductor(Conductor conductor)
        {
            InitializeComponent();
            labelname.Text = conductor.conductor_name;
            labelage.Text = conductor.age.ToString();
            labelconductor_education.Text = conductor.conductor_education.name_of_educational_institution;
            labelyears_of_experience.Text = conductor.years_of_experience.ToString();
            labelconductor_orchestra.Text = conductor.conductor_orchestra.ToString();
        }
    }
}
