using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    internal class Facultate
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }


        public Facultate(int facultyId, string facultyName)
        {
            FacultyId = facultyId;
            FacultyName = facultyName;
        }
    }
}
