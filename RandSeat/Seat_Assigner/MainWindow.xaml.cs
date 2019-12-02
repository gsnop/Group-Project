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
            //LBoutput.Items.Add(CBname.SelectedItem);
            //List<int> number = new List<int>();
            //Workstation computer = new Workstation();


            //int num = 0;

            //for(int i = 0; i < 50; i++)
            //{
            //    Random rand = new Random();

            //    do
            //    {
            //        num = rand.Next(1, 49);
            //    } while (number.Contains(num));
            //}



            
        }

        private void BTNName_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines("StudentNames.txt");

            foreach (var line in lines)
            {
                string[] l = line.Split(':');
                CBname.Items.Add(l[0] + " " + l[1]);
            }

            List<int> number = new List<int>();

            int num = 0;

            for (int i = 0; i < 50; i++)
            {
                Random rand = new Random();

                do
                {
                    num = rand.Next(1, 49);
                } while (number.Contains(num));
            }



            //Generate a number between 1 and 50
            //Random rand = new Random();
            //int nums = rand.Next(1, 50);
            //txtNumbers.Text = nums.ToString();
        }
        
        //Returns number less than 50 
        //int num = random.Next(50);
        //public int RandomNumber(int min, int max)
        //{
        //    Random rand = new Random();
        //    return rand.Next(min, max);
        //}

        //int randomNumber;
        //Random rand = new Random();
        //randomNumber = rand.Next();
        //Console.WriteLine("The random number is " + randomNumber)
        //    for(int i; int <= 50; int ++)
        //    {

        //    }
        //    string text = System.IO.File.ReadAllText()
        //public class RandomGenerator
        //{
        //Generate a random number between two numbers
        //    public int RandomNumber(int min, int max)
        //    {
        //        Random rand = new Random();
        //        return random.Next(min, max);
        //    }
        //}

        private void LBoutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LBoutput.Items.Add(CBname.SelectedItem);
            List<int> number = new List<int>();
            Workstation computer = new Workstation();


            int num = 0;

            for (int i = 0; i < 50; i++)
            {
                Random rand = new Random();

                do
                {
                    num = rand.Next(1, 49);
                } while (number.Contains(num));
            }

            Student student = new Student();
            //Workstation computer = new Workstation();
            //LBoutput.Items.Add($"{student.lName} {student.fName}: Seat {num}");
            LBoutput.Items.Add($": Seat {num}");
        }

        //private void BtnClose_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

        //public class Student
        //{
        //    private static Random rand;
        //    private int[] numbers;
        //    public Student()
        //    {
        //        rand = new Random();
        //        numbers = new int[50];
        //        for(int i = 0; i < 50; i++)
        //        {
        //            numbers[i] = rand.Next();
        //        }
        //    }
        //} 
    }
}
