using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seat_Assigner
{
    class Student
    {
        public string fName {get; set;}
        public string lName {get; set;}
        public int id       {get; set;}

        public List<Student> students { get; set; }
    }

    class Workstation
    {
        public int comp_num { get; set; }
        public int row_num { get; set; }
    }


    class Selection
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int row_num { get; set; }
        public int comp_num {get; set;}

        public override string ToString()
        {
            return $"{fName} {lName}: row {row_num} computer {comp_num}.";
        }

        //private void Selection()
        //{

        //}
    }
}
