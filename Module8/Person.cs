using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Person
    {
        private string _fname;
        private string _lname;
        private DateTime _birthdate;
        private string _addr1;
        private string _addr2;
        private string _city;
        private string _state;
        private long _zip;
        private string _country;

        public Person(string fname, string lname, DateTime birthdate, string addr1, string city, string state, long zip, string country, string addr2 = "")
        {
            Fname = fname;
            Lname = lname;
            Birthdate = birthdate;
            Addr1 = addr1;
            Addr2 = addr2;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }

        public string Fname
        {
            get
            {
                return _fname;
            }

            set
            {
                _fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return _lname;
            }

            set
            {
                _lname = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }

            set
            {
                _birthdate = value;
            }
        }

        public string Addr1
        {
            get
            {
                return _addr1;
            }

            set
            {
                _addr1 = value;
            }
        }

        public string Addr2
        {
            get
            {
                return _addr2;
            }

            set
            {
                _addr2 = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public long Zip
        {
            get
            {
                return _zip;
            }

            set
            {
                _zip = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }
    }
}
