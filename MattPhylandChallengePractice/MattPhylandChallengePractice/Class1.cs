using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattPhylandChallengePractice
{
    public abstract class Person
    {
        public string FirstName { get; set; } //first name of the person
        public string Surname { get; set; } //surname of the person
        public int YearOfBirth { get; set; } //Year of birth
        public virtual void GetName()
        {
            Console.WriteLine(FirstName + " " + Surname);
        }
        public virtual void GetAge()
        {
            Console.WriteLine(2018 - YearOfBirth);
        }
        public Person(string firstname, string surname, int yearofbirth)
        {
            this.FirstName = firstname;
            this.Surname = surname;
            this.YearOfBirth = yearofbirth;
        }
    }
    public class Student : Person
    {
        public int ID { get; set; } //ID number of the student
        public Student(int id, string firstname, string surname, int yearofbirth) : base(firstname, surname, yearofbirth)
        {
            this.ID = id;
        }
    }
    public abstract class Staff : Person
    {
        public string Username { get; set; } //Username of the staff member
        public Staff(string username, string firstname, string surname, int yearofbirth) : base(firstname, surname, yearofbirth)
        {
            this.Username = username;
        }
    }
    public class Teacher : Staff
    {
        public string Expertise { get; set; } //Expertise of the teacher
        public Teacher(string expertise, string username, string firstname, string surname, int yearofbirth) : base(username, firstname, surname, yearofbirth)
        {
            this.Expertise = expertise;
        }
    }
    public class Admin : Staff
    {
        public int OfficeNo { get; set; } //Office's identifying number
        public Admin(int officeno, string username, string firstname, string surname, int yearofbirth) : base(username, firstname, surname, yearofbirth)
        {
            this.OfficeNo = officeno;
        }
    }
}
