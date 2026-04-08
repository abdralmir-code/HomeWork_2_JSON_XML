using System;
using System.Drawing;
namespace Symphony_Orchestra.Musician
{
    public class Musicians
    {
        public string musician_name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Возраст не может быть отрицательным!!!!!!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Instrument_species musician_instrument { get; set; }
        public Education musician_education { get; set; }
        public Awards musician_awards { get; set; }
    }
}
