/**
 * 
 * File: Programs.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 11, 2018
 * 
 * 
 **/

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // This is the class for creating an instance of a Program
    public class Programs {
        // Declare the needed class attributes
        public int id { get; }
        public string name { get; set; }
        public int duration { get; set; }
        public char coop { get; set; }
        public string outcome { get; set; }

        /**
         * 
         * This method is used to create a new Programs instance
         * 
         * @param id: is the programs id
         * @param name: is the program name
         * @param duration: is the duration of the program in months
         * @param coop: is the Boolean value of if the course has coop ability or not
         * @param outcome: is what a person recieves after they successfully complete the program
         * 
         **/
         public Programs(int id, string name, int duration, char coop, string outcome) {
            // Set the class attributes
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.coop = coop;
            this.outcome = outcome;
        }

        /**
         * 
         * This function is used to dispaly the program name in a combobox
         * 
         **/
        public override string ToString() {
            // Return the name of the person
            return name;
        }
    }
}
