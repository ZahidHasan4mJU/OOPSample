using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample2
{
    class StudentInfo
    {
        public string reg;
        public string fName;
        public string lName;

        public string getFullName()
        {
            return fName + " " + lName;
        }
    }
}
