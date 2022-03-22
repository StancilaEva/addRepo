using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    internal class Grupa
    {
        List<Student> students;
        public List<Student> Students { get { return students; } set { Students = value; } }

        public Grupa()
        {
            students = new List<Student>();
        }
    }
}
