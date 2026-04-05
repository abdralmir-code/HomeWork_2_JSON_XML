using Symphony_Orchestra.Musician;
using System;
namespace Symphony_Orchestra.Instrument
{
    internal class Instruments
    {
        public Instrument_species name {  get; set; }
        public Instrument_type type { get; set; }
        private int YearManufactured;
        public int year_manufactured
        {
            get { return YearManufactured; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Год изготовления не может быть отрицательным!!!!!!");
                }
                else
                {
                    YearManufactured = value;
                }
            }
        }
        public Manufacturer instrument_manufacturer { get; set; }
        public Serial_Number serial_number { get; set; }

    }
}
