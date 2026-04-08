using Symphony_Orchestra.Musician;
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
    public partial class INformation_of_musicsian : Form
    {
        public INformation_of_musicsian()
        {
            InitializeComponent();
        }
        public INformation_of_musicsian(Musicians musician)
        {
            InitializeComponent();
            labelname_music.Text = musician.musician_name;
            labelage_music.Text = musician.Age.ToString();
            labelinstrument_music.Text = musician.musician_instrument.ToString();
            labeleducation.Text = musician.musician_education.ToString();
            labelaward.Text = musician.musician_awards.ToString();
        }
    }
}
