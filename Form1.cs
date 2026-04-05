using Symphony_Orchestra.Instrument;
using Symphony_Orchestra.Musician;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Symphony_Orchestra
{
    public partial class Form1 : Form
    {
        List<Conductor> conductors = new List<Conductor>();
        List<Musicians> musicians = new List<Musicians>();
        List<Instruments> instruments = new List<Instruments>();
        public void CreateData()
        {
            Conductor conductor = new Conductor();
            conductor.conductor_name = "Konstantin Krimets";
            conductor.Age = 94;
            conductor.years_of_experience = 70;

            Education education = new Education();
            education.name_of_educational_institution = "Juilliard School";
            education.Degree = MusicDegree.ProfessionalDiploma;
            conductor.conductor_education = education;

            Orchestra orchestra = new Orchestra();
            orchestra.name_of_orchestra = "Globalis Symphony Orchestra";
            orchestra.number_of_musicians = 100;
            conductor.conductor_orchestra = orchestra;

            Musicians musician = new Musicians();
            musician.musician_name = "Alice Smith";
            musician.Age = 30;
            musician.musician_instrument = Instrument_species.Violin;

            Education education_for_musician = new Education();
            education_for_musician.name_of_educational_institution = "Curtis Institute of Music";
            education_for_musician.Degree = MusicDegree.Bachelor;
            musician.musician_education = education_for_musician;

            Awards awards = new Awards();
            awards.name_of_award = "Best Violinist";
            awards.Year_of_award = 2020;
            musician.musician_awards = awards;

            Instruments instrument = new Instruments();
            instrument.name = Instrument_species.Accordion;
            instrument.type = Instrument_type.Keyboard;
            instrument.year_manufactured = 2015;

            Serial_Number serial_Number = new Serial_Number();
            serial_Number._serial_number = Guid.NewGuid();
            instrument.serial_number = serial_Number;

            Manufacturer manufacturer = new Manufacturer();
            manufacturer.name_of_manufacturer = "Hohner";
            manufacturer.country_of_manufacturer = "Germany";
            instrument.instrument_manufacturer = manufacturer;

            conductors.Add(conductor);
            musicians.Add(musician);
            instruments.Add(instrument);

        }

        public Form1()
        {
            InitializeComponent();
            CreateData();
        }
    }
}
