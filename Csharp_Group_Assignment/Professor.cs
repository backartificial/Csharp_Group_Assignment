/**
 * 
 * File: Professor.cs
 * Date: August 12, 2018
 * Developer: Nathaniel
 * 
 **/

// Include needed packages
using System;

// Set the container to the namespace of the project
namespace Csharp_Group_Assignment {
    // This calss is sued to hold and object of a Person
    public class Professor : Person {
        // Declare the needed class attributtes
        public int employeeId { get; }

        /**
         * 
         * This method is used for creating an instance of a Professor
         * 
         * @param id: is the id of the person
         * @param employeeNumber: is the employee number of the professor
         * @param firstName: is the first name of the person
         * @param lastName: is the last name of the person
         * @param birthday: is the birthday of the person
         * @param gender: is the gender of the person
         * @param startDate: is the start date of the person
         * 
         **/
        public Professor(int id, int employeeId, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) : base(id, firstName, lastName, birthday, gender, startDate) {
            // Set the class attributes
            this.employeeId = employeeId;
        }
    }
}
