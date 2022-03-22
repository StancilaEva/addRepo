using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    internal class Student
    {
        public int Varsta { get; set; }
        public string Nume { get; set; }
        public int FacultyId { get; set; }
        public Student(int facultyId, int varsta, string nume)
        {
            FacultyId = facultyId;
            Varsta = varsta;
            Nume = nume;

        }

        public override string? ToString()
        {
            return $"{FacultyId} {Nume} {Varsta}";
        }
    }
}
