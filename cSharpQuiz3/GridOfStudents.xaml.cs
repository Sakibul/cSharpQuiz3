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
using System.Windows.Shapes;

namespace cSharpQuiz3
{
    /// <summary>
    /// Interaction logic for GridOfStudents.xaml
    /// </summary>
    public partial class GridOfStudents : Window
    {
        public GridOfStudents()
        {
            InitializeComponent();
            addStudentsToGrid();
        }

        public void addStudentsToGrid()
        {
            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student ( 1, "First 1", "Last 1", true ));
            listStudents.Add(new Student ( 2, "First 2", "Last 2", false ));
            listStudents.Add(new Student ( 3, "First 3", "Last 3", true ));
            listStudents.Add(new Student ( 4, "First 4", "Last 4", true ));
            listStudents.Add(new Student ( 5, "First 5", "Last 5", false ));
            listStudents.Add(new Student ( 6, "First 6", "Last 6", false));
            listStudents.Add(new Student ( 7, "First 7", "Last 7", false));

            studentsDataGrid.ItemsSource = listStudents;
        }
    }
}
