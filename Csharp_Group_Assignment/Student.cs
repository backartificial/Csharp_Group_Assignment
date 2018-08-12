/**
* 
* File: Student.cs
* Developer: James Grau
* Student Number: 991443203
* Date: August 12, 2018
* 
* 
**/

// Include needed package
using System;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for creating an instance of a Student
    public class Student : Person {
        // Declare Class attributes
        public int studentNumber { get; }

        /**
         * 
         * This method is used for creating an instance of a student
         * 
         * @param id: is the id of the person
         * @param studentNumber: is the student number
         * @param firstName: is the first name of the person
         * @param lastName: is the last name of the person
         * @param birthday: is the birthday of the person
         * @param gender: is the gender of the person
         * @param startDate: is the start date of the person
         * 
         **/
        public Student(int id, int studentNumber, string firstName, string lastName, DateTime birthday, char gender, DateTime startDate) : base(id, firstName, lastName, birthday, gender, startDate) {
            // Set the class attributes
            this.studentNumber = studentNumber;
        }
    }
}
