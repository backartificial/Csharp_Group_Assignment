/**
 * 
 * File: Course.cs
 * Date: July 27, 2018
 * Developer: James Grau
 * Student Number: 991443203
 * 
 **/

// Include needed packages
using System;

// Set the container to the namespace of the project
namespace Csharp_Group_Assignment {
    // This calss is sued to hold and object of a course
    public class Course {
        // Define the needed class attributes
        public int id { get; }
        public string courseCode { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public TimeSpan time { get; set; }
        public int capacity { get; set; }
        public int credits { get; set; }

        /**
         * 
         * This method is used to create an instance of a course
         * 
         * @param id: is the course id in the database
         * @param courseCode: is the code of the course
         * @param name: is the name of the course
         * @param location: is the location of the course
         * @param time: is the date @ time the course occurs
         * @param capacity: is the capacity of the course
         * @param credits: is the amout of credits that a course is worth
         * 
         **/
        public Course(int id, string courseCode, string name, string location, TimeSpan time, int capacity, int credits) {
            // Set the object attributes
            this.id = id;
            this.courseCode = courseCode;
            this.name = name;
            this.location = location;
            this.time = time;
            this.capacity = capacity;
            this.credits = credits;
        }
    }
}
