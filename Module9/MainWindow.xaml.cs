using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Module9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> _students;
        private int _currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();
            Students.Add(new Student("Angel", "Munoz", new DateTime(1992, 05, 16), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico"));
            Students.Add(new Student("Perla", "Lopez", new DateTime(1992, 12, 10), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico", "Dir2"));
            Students.Add(new Student("Victor", "Munoz", new DateTime(1992, 07, 10), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico"));
            txtCity.Text = Students[CurrentIndex].City;
            txtFirstName.Text = Students[CurrentIndex].Fname;
            txtLastName.Text = Students[CurrentIndex].Lname;
            btnNext.IsEnabled = true;
            btnPrevious.IsEnabled = false;

        }

        public List<Student> Students
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return _currentIndex;
            }

            set
            {
                _currentIndex = value;
            }
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
           
            Students.Add(new Student(txtFirstName.Text, txtLastName.Text, new DateTime(1992, 05, 20), "", txtCity.Text, "", 12345, ""));
            txtCity.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            CurrentIndex--;
            if (CurrentIndex < 0)
            {
                CurrentIndex = 0;
                btnPrevious.IsEnabled = false;
            }
            txtCity.Text = Students[CurrentIndex].City;
            txtFirstName.Text = Students[CurrentIndex].Fname;
            txtLastName.Text = Students[CurrentIndex].Lname;
            btnNext.IsEnabled = true;
           
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            CurrentIndex++;
            if (CurrentIndex >= Students.Count)
            {
                CurrentIndex = Students.Count - 1;
                btnNext.IsEnabled = false;
            }
            txtCity.Text = Students[CurrentIndex].City;
            txtFirstName.Text = Students[CurrentIndex].Fname;
            txtLastName.Text = Students[CurrentIndex].Lname;
            btnPrevious.IsEnabled = true;
           
        }
    }
}
