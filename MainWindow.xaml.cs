using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture_01_25_23_Class_Methods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
    }



    //    Notes
    // What is a method?
    // A method is a block of code that is given a name and runs when it is called.
    // What is the purpose of a method?
    // A method can be used to compartmentalize our code into a small portion so that we can reuse it. A method can make your code easy to call, easy to read, easy to refactor, and easy to reuse.
    //What is a class method?
    //Review: What’s the name for any field, constructor, property or method that is part of a class?
    //Review: What are the 4 parts of declaring a method?
    //    What keyword allows you to access members related to the specific instance?
    //A method build inside a class has access to what, even it’s access modifier is set to private?
    //    What does “override .ToString()” allow us to do?
    //You use the * ____ operator * do you use to access members inside of an instanced class?


    //Optional: 

    //What is method overloading?
    //What needs to be different to overload a method?
}
