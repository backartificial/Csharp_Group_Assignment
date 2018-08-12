using System;

namespace Csharp_Group_Assignment {
    public class Student : Person {
        public int studentNumber { get; }
        public string name { get {return firstName + " " + lastName;} }

        public Student(int id, int studentNumber, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) : base(id, firstName, lastName, birthday, gender, startDate) {
            // Set the class attributes
            this.studentNumber = studentNumber;
        }
    }
}
