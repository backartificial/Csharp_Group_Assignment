using System;

namespace Csharp_Group_Assignment {
    public abstract class Person {
        public int id { get; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; }
        public char gender { get; }
        public DateTime startDate { get; set; }

        public Person(int id, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) {
            // Set class attributes
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.gender = gender;
            this.startDate = startDate;
        }
    }
}
