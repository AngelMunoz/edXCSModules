using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class UProgram
    {
        private string _pName;
        private string _dHead;
        private Degree _degree;



        public UProgram(string pName, string dHead, Degree degree = null)
        {
            this.PName = pName;
            this.DHead = dHead;
            this.Degree = degree;
        }
        public string PName
        {
            get
            {
                return _pName;
            }

            set
            {
                _pName = value;
            }
        }

        public string DHead
        {
            get
            {
                return _dHead;
            }

            set
            {
                _dHead = value;
            }
        }

        public Degree Degree
        {
            get
            {
                return _degree;
            }

            set
            {
                _degree = value;
            }
        }
    }
}
