using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }

        private static int _no;
        public int No { get; protected set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        public string GroupNo { get; set; }
    }
}
