using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    delegate checkStudent = (S)

    public class Group
    {
        public string Name { get; set; }
        List<Student> Students = new List<Student>();

        

        public List<Student> Search(Student student)
        {
            foreach (var item in Students)
            {
                if ()
                {

                }
            }
        }

        //public List<Student> Search(double point)
        //{
        //    foreach (var item in Students)
        //    {
        //        if (!(item.Point > point))
        //        {
        //            Students.Remove(item);
        //        }
        //    }
        //    return Students;
        //}

        //public List<Student> Search(int length)
        //{

        //    foreach (var item in Students)
        //    {
        //        if (!(item.FullName.Length > length))
        //        {
        //            Students.Remove(item);
        //        }
        //    }
        //    return Students;
        //}

        //public List<Student> Search(string groupNo)
        //{
        //    foreach (var item in Students)
        //    {
        //        if (!(item.GroupNo==groupNo))
        //        {
        //            Students.Remove(item);
        //        }
        //    }
        //    return Students;
        //}
    }
}
