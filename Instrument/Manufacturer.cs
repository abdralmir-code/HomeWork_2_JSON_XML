using System;
namespace Symphony_Orchestra.Instrument
{
    public class Manufacturer
    {
         public string name_of_manufacturer { get; set; }
         public string country_of_manufacturer { get; set; }
         public override string ToString()
         {
             return $"{name_of_manufacturer} ({country_of_manufacturer})";
         }
    }
}
