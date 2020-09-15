using System;
using System.Collections.Generic;
using System.Text;

namespace Cms20_OOpLab2
{
    class Person
    {
        public string Name { get; private set; }
        public string StreetAddress { get; private set; }
        public int PostalCode { get; private set; }
        public string City { get; private set; }

        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        private bool IsOkName(string newName)
        {
            if (newName == "IDIOT") return false;
            if (newName == "HEJ") return false;
            if (newName == "HOPP") return false;
            if (newName == "JHKJKL") return false;
            if (newName.Length < 2) return false;
            return true;
        }

        public bool SetName(string newName)
        {

            if (IsOkName(newName) == false) return false;
            Name = newName;
            return true;
        }

        public void SendDiscountOnLocalIca()
        {
            //SendPost(  namer, streeaddress )
        }

        public void SendFlowers()
        {
            //SendMail("interfloa.se", "Grattis -> klevera" )
        }



        public void SetAddress(string streetAddress, int postalCode
            , string city)
        {
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            SendDiscountOnLocalIca();
        }

        public void BecomeSamboWith(Person other)
        {
            StreetAddress = other.StreetAddress;
            PostalCode = other.PostalCode;
            City = other.City;

            SendFlowers();
        }

    }
}
