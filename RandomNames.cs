using System;
using Testing.Data;

namespace Testing.Generator
{
    class RandomNames
    {
        private Random random = new Random();

        public string Surname()
        {
            return Data.Names.Surname[random.Next(Data.Names.Surname.Length)];
        }

        public string GivenMale()
        {
            return Data.Names.GivenMale[random.Next(Data.Names.GivenMale.Length)];
        }

        public string GivenFemale()
        {
            return Data.Names.GivenFemale[random.Next(Data.Names.GivenFemale.Length)];
        }

        public string RandomMaleFemaleGiven()
        {
            if (random.Next(1) == 1)
            {
                return GivenMale();
            }
            else
            {
                return GivenFemale();
            }
        }

        public string Name()
        {
            return string.Format("{0} {1}", RandomMaleFemaleGiven(), Surname());
        }

        public string[] NamesWithCommonSurname(int count)
        {
            string[] names = new string[count];
            string surname = Surname();
            for (int i = 0; i < count; i++)
            {
                names[i] = string.Format("{0} {1}", RandomMaleFemaleGiven(), surname);
            }
            return names;
        }
    }
}
