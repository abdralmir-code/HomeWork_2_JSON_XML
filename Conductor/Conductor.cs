using System;
namespace Symphony_Orchestra
{
    public class Conductor
    {
        public string conductor_name { get; set; }
        private int Age_;
        public int age
        {
            get { return Age_; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Возраст не может быть отрицательным!!!!!!");
                }
                else
                {
                    Age_ = value;
                }
            }
        }
        private int YearsOfExperience;
        public int years_of_experience
        {
            get { return YearsOfExperience; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Опыт работы не может быть отрицательным!!!!!!");
                }
                else
                {
                    YearsOfExperience = value;
                }
            }
        }
        public Education conductor_education { get; set; }
        public Orchestra conductor_orchestra { get; set; }
    }
}
