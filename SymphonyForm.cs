using Symphony_Orchestra.Instrument;
using Symphony_Orchestra.Musician;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Drawing;
using System.Xml.Serialization;
namespace Symphony_Orchestra
{
    public partial class SymphonyForm : Form
    {
        List<Conductor> conductors = new List<Conductor>();
        List<Musicians> musicians = new List<Musicians>();
        List<Instruments> instruments = new List<Instruments>();

        public void HideAllColumnsExcept(string visibleColumn)
        {
            foreach (DataGridViewColumn column in orchestraGrid.Columns)
            {
                column.Visible = column.Name == visibleColumn;
            }
        }
        public SymphonyForm()
        {
            InitializeComponent();
            CreateData_json();
            CreateData_XML();
        }
        private void orchestraGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                if (essence.SelectedNode?.Text == "Дирижёр")
                {
                    var conductor = conductors[e.RowIndex];
                    new INformation_of_conductor(conductor).ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }
            //
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                if (essence.SelectedNode?.Text == "Музыкант")
                {
                    var musicsian = musicians[e.RowIndex];
                    new INformation_of_musicsian(musicsian).ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                if (essence.SelectedNode?.Text == "Инструмент")
                {
                    var instrument = instruments[e.RowIndex];
                    new INformation_of_instrument(instrument).ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
            }

        }
        private void essence_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                orchestraGrid.DataSource = null;

                if (e.Node.Text == "Дирижёр")
                {
                    orchestraGrid.DataSource = conductors;
                    HideAllColumnsExcept("conductor_name");
                }
                else if (e.Node.Text == "Музыкант")
                {
                    orchestraGrid.DataSource = musicians;
                    HideAllColumnsExcept("musician_name");
                }
                else if (e.Node.Text == "Инструмент")
                {
                    orchestraGrid.DataSource = instruments;
                    HideAllColumnsExcept("name");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }
        public void CreateData_json()
        {
            Conductor conductor = new Conductor();
            conductor.conductor_name = "Konstantin Krimets";
            conductor.age = 94;
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
            var data = new
            {
                conductors,
                musicians,
                instruments
            };
            string path = Application.StartupPath + @"\..\..\Data\";
            string filePath = Path.Combine(path, "data.json");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json_serialized = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, json_serialized);
        }
        public void CreateData_XML()
        {
            DataBase data = new DataBase
            {
                conductors = conductors,
                musicians = musicians,
                instruments = instruments
            };
            XmlSerializer serializer = new XmlSerializer(typeof(DataBase));
            string path = Application.StartupPath + @"\..\..\Data\";
            string filePath = Path.Combine(path, "XMLF.xml");
            using (FileStream filestream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(filestream, data);
            }
        }
        public void LoadData_json()
        {
            string path = Application.StartupPath + @"\..\..\Data\";
            string filePath = Path.Combine(path, "data.json");
            string json = File.ReadAllText(filePath);
            DataBase data = JsonSerializer.Deserialize<DataBase>(json);
            conductors = data.conductors;
            musicians = data.musicians;
            instruments = data.instruments;
        }
        public void LoadData_XML()
        {
            string path = Application.StartupPath + @"\..\..\Data\";
            string filePath = Path.Combine(path, "XMLF.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(DataBase));
            using (FileStream filestream = new FileStream(filePath, FileMode.Open))
            {
                DataBase data = (DataBase)serializer.Deserialize(filestream);
                conductors = data.conductors;
                musicians = data.musicians;
                instruments = data.instruments;
            }
        }
        private void button_load_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Нажмите 'ДА', если хотите загрузить json, иначе нажмите 'НЕТ', для загрузки xml", "Выберите формат", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadData_json();
                MessageBox.Show("JSON загружен!");
            }
            else
            {
                LoadData_XML();
                MessageBox.Show("XML загружен!");
            }
        }
    }
}