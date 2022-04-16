using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
             Student studen1 = new Student("Hikmet", 56);
            Student studen2 = new Student("Abbas", 66);
            Student studen3 = new Student("Nigar", 46);
            Student studen4 = new Student("Rustem", 86);
            Student studen5 = new Student("Tofiq", 96);

            Group group = new Group();
            group.Students.Add(studen1);
            group.Students.Add(studen2);
            group.Students.Add(studen3);
            group.Students.Add(studen4);
            group.Students.Add(studen5);

            var wantedStudnets = group.Search(x => x.FullName.Length>5);
            wantedStudnets = group.Search(delegate(Student std) { return std.Point > 65; });
            wantedStudnets = group.Search(IsPassed);



            foreach (var item in wantedStudnets)
            {
                Console.WriteLine(item.FullName+" - "+item.Point);
            }
        }
        
        static bool IsPassed(Student student)
        {
            return student.Point > 50;
        }
    }
}
