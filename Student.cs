using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_01_25_23_Class_Methods
{
    // Access Modifiers:
    // internal, public, private, protected
    // If no access modifier is listed, the default is private.
    public class Student
    {
        // Field
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;



        // Constructor
        //public Student(string firstName)
        //{
        //    this._firstName = firstName;
        //}

        //Review: What’s the name for any field, constructor, property or method that is part of a class?
        //        Member

        // created with quick action - 
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        // Properties
        public string FirstName
        {
            // get and set
            // get allows the user to read the value
            // set allows the user to change the value

            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        // created with quick action - "encapsulate fields (but still use fields)"
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        // Method

        // What is a method?
        // A method is a block of code that is given a name and runs when it is called.

        // What is the purpose of a method?
        // A method can be used to compartmentalize our code into a small portion so that we can reuse it. A method can make your code easy to call, easy to read, easy to refactor, and easy to reuse.

        //What is a class method?
        // A class method directly interracts with the members of a class

        public double StudentAverage()
        {
            return (_csiGrade + _genEdGrade) / 2;
        } // StudentAverage



        //Review: What are the 4 parts of declaring a method?
        //    Access modifier - return type - Name - Parameters

        //    What keyword allows you to access members related to the specific instance?

        //A method build inside a class has access to what, even it’s access modifier is set to private?


        // s.FirstName + " " + s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;
        //    What does “override .ToString()” allow us to do?

        // How to override to string

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - Gen Ed Grade: {this.GenEdGrade} - CSI Grade: {this.CsiGrade}";
        } //ToString

        //Optional: 

        //What is method overloading?
        // A method with the same name accepts different parameters

        //What needs to be different to overload a method?
        // The parameters need to be different


    }
}
