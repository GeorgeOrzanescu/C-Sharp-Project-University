using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.classes
{
    public class Student
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public long Year { get; set; }
        public List<int> grades;

        public Student(string firstName, string lastName, string email, string telephone,long year)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Telephone = telephone;
            Year = year;
            grades = new List<int>() { 0,0,0,0,0,0};
        }

        public Student(long id, string firstName, string lastName, string email, string telephone, long year):this(firstName,lastName,email,telephone,year)
        {
            Id = id;
        }

        public void modifyGrade(int course,int newGrade)
        {
            grades[course] = newGrade;
        }
        
    }
}
