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
    class Student
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
    }
}
