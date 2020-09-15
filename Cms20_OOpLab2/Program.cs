using System;

namespace Cms20_OOpLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2012,1,1));

            person.BBla();


            if (person.SetName("IDIOT") == false)
            {
                Console.WriteLine("Ogiltigt namn");
            }

            person.SetName("Stefan");
            person.SetAddress("Blavägen 1", 11122, "Hejstad");




            var kerstin = new Person(new DateTime(2012, 1, 1));
            kerstin.SetName("Kerstin");
            kerstin.SetAddress("Hejgartan 111", 55511, "Blastad");

            person.BecomeSamboWith(kerstin);

        }
    }
}
