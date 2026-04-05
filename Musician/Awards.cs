using System;
namespace Symphony_Orchestra.Musician
{
    internal class Awards
    {
        public string name_of_award { get; set; }
        private int year_of_award;
        public int Year_of_award
        {
            get { return year_of_award; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Год получения награды не может быть отрицательным!!!!!!");
                }
                else
                {
                    year_of_award = value;
                }
            }
        }
    }
}
