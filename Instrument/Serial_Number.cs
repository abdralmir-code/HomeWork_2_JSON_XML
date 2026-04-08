using System;
namespace Symphony_Orchestra.Instrument
{
    public class Serial_Number
    {
        public Guid _serial_number {  get; set; }
        public override string ToString()
        {
            return $"{_serial_number}";
        }
    }
}
