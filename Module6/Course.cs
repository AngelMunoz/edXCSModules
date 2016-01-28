using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Course
    {
        private string _cName;
        private int _credits;
        private int _weeks;
        private Teacher[] _teachers;
        private Student[] _students;


        public Course(string cName, int credits, int weeks, Teacher[] teachers = null, Student[] students = null)
        {
            this.CName = cName;
            this.Credits = credits;
            this.Weeks = weeks;
            this.Teachers = teachers;
            this.Students = students;
        }
        public string CName
        {
            get
            {
                return _cName;
            }

            set
            {
                _cName = value;
            }
        }

        public int Credits
        {
            get
            {
                return _credits;
            }

            set
            {
                _credits = value;
            }
        }

        public int Weeks
        {
            get
            {
                return _weeks;
            }

            set
            {
                _weeks = value;
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return _teachers;
            }

            set
            {
                _teachers = value;
            }
        }

        public Student[] Students
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
            }
        }
    }
}
