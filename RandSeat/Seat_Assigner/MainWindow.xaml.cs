using System;
using System.Collections.Generic;
using System.IO;
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

namespace Seat_Assigner
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

        private void CBname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BTNName_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines("StudentNames.txt");

            List<Student> students = new List<Student>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                Student temp = new Student();
                var parts = line.Split(':');
                temp.fName = parts[0];
                temp.lName = parts[1];

                foreach (var part in parts)
                {
                    CBname.Items.Add(parts[0] + " " + parts[1]);
                }
            }
        }
    }
}
