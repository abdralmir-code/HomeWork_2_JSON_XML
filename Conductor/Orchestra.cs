using System;
namespace Symphony_Orchestra
{
    public class Orchestra
    {
        public string name_of_orchestra { get; set; }
        public int number_of_musicians { get; set; }
        public OrchestraType type_of_orchestra { get; set; }
        public override string ToString()
        {
            return $"{name_of_orchestra} ({number_of_musicians} musicians)";
        }
    }
}
