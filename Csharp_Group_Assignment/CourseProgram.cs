/**
 * 
 * File: CourseProgram.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 11, 2018
 * 
 * 
 **/

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for this form
    public class CourseProgram {
        // Set the class attributes
        public int courseId { get; }
        public int programId { get; }
        public string courseName { get; }
        public string programName { get; }

        /**
         * 
         * This method is used to initialize an instance of a CourseProgram
         * 
         * @param courseId: is the courses id
         * @param programId: is the program id
         * @param courseName: is the name of the course
         * @param programName: ist he name of the program
         * 
         **/
        public CourseProgram(int courseId, int programId, string courseName, string programName) {
            // Set the class attributes
            this.courseId = courseId;
            this.programId = programId;
            this.courseName = courseName;
        }
    }
}
