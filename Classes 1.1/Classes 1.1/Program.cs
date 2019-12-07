using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._1
{
    class Adress
    {
        private int index;
        private string country, city, street, house, apartment;

        public Adress(string country, string city, string street, string house, string apartment, int index)
        {
            Country = country;
            City = city;

            Street = street;
            House = house;

            Apartment = apartment;
            Index = index;
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public string Apartment
        {
            get
            {
                return apartment;
            }

            set
            {
                apartment = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress("Ukrain", "Dnipro", "Yavornitskogo st.", "18A", "55", 49000);

            Console.WriteLine("Country: {0}\nCity: {1}\nStreet: {2}\nHouse: {3}\nApartmenr: {4}\nIndex: {5}", adress.Country, adress.City, adress.Street, adress.House, adress.Apartment, adress.Index);
        }
    }
}
