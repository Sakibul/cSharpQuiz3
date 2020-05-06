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

namespace cSharpQuiz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> listStudent = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(int.Parse(txtId.Text),
                                            txtFirstName.Text, txtLastName.Text, 
                                            chkRegistered.IsChecked ?? true);

            listStudent.Add(student);
            
            

            string str = "";
            foreach(Student s in listStudent)
            {
                str += s.ToString() + "\n";
            }

            MessageBox.Show($"Added {listStudent.Count} students:\n\n{str}");
        }
    }
}
