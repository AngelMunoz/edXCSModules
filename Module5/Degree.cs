using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Degree
    {
        string name;
        int credits;
        Course[] courses;

        public Degree(string name, int credits, Course[] courses)
        {
            this.Name = name;
            this.Credits = credits;
            this.Courses = courses;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        internal Course[] Courses
        {
            get
            {
                return courses;
            }

            set
            {
                courses = value;
            }
        }
    }
}
