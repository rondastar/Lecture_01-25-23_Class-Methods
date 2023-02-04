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
// Ronda Rutherford
// Lecture 01-25-23 - Class (Methods)
// 02-03-23
namespace Lecture_01_25_23_Class_Methods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Course csi122;
        public MainWindow()
        {
            InitializeComponent();
            csi122 = new Course("CSI 122", "Will Cram");
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {

            AddStudentToList();
            csi122.EnrollStudent(students[students.Count - 1]);

            runDisplay.Text = "";
            runDisplay.Text = csi122.CourseName + " " + csi122.Teacher + "\n";
            MessageBox.Show(csi122.RosterAverage().ToString());

            foreach (Student student in csi122.CourseRoster)
            {
                runDisplay.Text += student + "\n";
            }

            //DisplayStudents();

            //You use the * ____ operator * do you use to access members inside of an instanced class?
            //      The dot operator

            //// How do I display my student from my list?
            ////runDisplay.Text = s.FirstName + " " + s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;
            //runDisplay.Text = s.ToString();


        } // btnAddStudent_Click

        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEdGrade.Text);

            //Student student = new Student(firstName, lastName, csiGrade, genEdGrade);

            //// Add student to my list of students
            //students.Add(student);

            // Add student to my list of students -- we can add the student directly in the list because the list place acts as a variable name
            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));

            //Student s = students[0];
        } // AddStudent
        public void DisplayStudents()
        {
            // clears our display
            runDisplay.Text = "";
            // shows all of our students
            for (int i = 0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";
            }
        } // DisplayStudents
    }



    
    
}
