using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace LatihanInheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string newName, int newAge)
        {
            Name = newName;
            Age = newAge;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("Orang tersebut bernama {0} dan berumur {1}", Name, Age);
        }

    }

    public class Teacher : Person
    {

        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string newName, int newAge, string newTeacherId, string newSubject) : base(newName, newAge)
        {
            TeacherId = newTeacherId;
            Subject = newSubject;
        }
    }

    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string newName, int newAge, string newStudentId, string newEmail) : base(newName, newAge)
        {
            StudentId = newStudentId;
            Email = newEmail;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Burbur", 98);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Tosoto", 55, "190302", "Ternak Lele");
            teacher.GetNameAndAge();

            Student student = new Student("Reychandra", 19, "19.11.2710", "reychandra.fahlevie@students.amikom.com");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}