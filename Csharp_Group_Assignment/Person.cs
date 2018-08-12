/**
 * 
 * File: Person.cs
 * Date: August 12, 2018
 * Developer: James Grau
 * Student Number: 991443203
 * 
 **/

// Include needed packages
using System;

// Set the container to the namespace of the project
namespace Csharp_Group_Assignment {
    // This calss is sued to hold and object of a Person
    public abstract class Person {
        // Declare class attributes
        public int id { get; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; }
        public char gender { get; }
        public DateTime startDate { get; set; }
        public string name { get { return firstName + " " + lastName; } }

        /**
         * 
         * This method is used to create an instance of a Person
         * 
         * @param id: is the id of the person
         * @param firstName: is the first name of the person
         * @param lastName: is the last name of the person
         * @param birthday: is the birthday of the person
         * @param gender: is the gender of the person
         * @param startDate: is the start date of the person
         * 
         **/
        public Person(int id, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) {
            // Set class attributes
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.gender = gender;
            this.startDate = startDate;
        }

        /**
         * 
         * This function is used to dispaly the persons name in a combobox
         * 
         **/
        public override string ToString() {
            // Return the name of the person
            return name;
        }
    }
}
