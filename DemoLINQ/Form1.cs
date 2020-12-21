using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLINQ
{
    public partial class Form1 : Form
    {
        List<Student> students;

        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadDataButton_Click(object sender, EventArgs e)
        {
            //students = StudentService.GetStudents();
            students = await StudentInternetService.GetStudents();

            TableStudents.DataSource = students;
        }

        private void SortDataButton_Click(object sender, EventArgs e)
        {
            List<Student> copy = students.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            TableStudents.DataSource = copy;
        }

        private void SearchAgeButton_Click(object sender, EventArgs e)
        {
            int age = (int)AgeFilter.Value;

            //List<Student> copy = students.Where(x => x.Age >= age).ToList();

            var copy = from x in students
                       where x.Age >= age
                       select x;

            TableStudents.DataSource = copy.ToList();
        }

        private void SearchCountryButton_Click(object sender, EventArgs e)
        {
            string country = CountryFilter.Text.ToLower();

            List<Student> copy = students.Where(x => x.Country.ToLower() == country).ToList();
            TableStudents.DataSource = copy;
        }

        private void CalculateAvgGradeButton_Click(object sender, EventArgs e)
        {
            double average = students.Average(x => x.Age);
            MessageBox.Show("The average age is " + average);
        }
    }
}
