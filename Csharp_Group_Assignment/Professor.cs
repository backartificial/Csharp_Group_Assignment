using System;

namespace Csharp_Group_Assignment {
    public class Professor : Person {
        public int employeeId { get; }
        public string name { get {return firstName + " " + lastName;} }

        public Professor(int id, int employeeId, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) : base(id, firstName, lastName, birthday, gender, startDate) {
            // Set the class attributes
            this.employeeId = employeeId;
        }
    }
}
