using System;
namespace Symphony_Orchestra
{
    public class Education
    {
        public string name_of_educational_institution { get; set; }
        public MusicDegree Degree { get; set; }
        public override string ToString()
        {
            return $"{name_of_educational_institution} ({Degree})";
        }
    }
}
