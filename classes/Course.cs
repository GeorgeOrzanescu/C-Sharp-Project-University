
using System;

namespace StudentApp.classes
{   
    [Serializable]
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int numCredits { get; set; }

        public Course()
        {

        }
        public Course(string name, string teacher, int numCredits)
        {
            Name = name;
            Teacher = teacher;
            this.numCredits = numCredits;
        }

        public override string ToString()
        {
            return Name + "\t" + Teacher + "\t" + numCredits;
        }
    }
}
