using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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

namespace cours04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private class Group
        {
            public Group(string name, int time) { 
                
            }
            public enum DrinkType
            {
                Coke,
                SevenUp,
                CanadaDry,
            };



            public string Name { get; set; }
            public int Time { get; set; }



            public override string ToString()
            {
                return $"Groupe {Name} de {Time}h";
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            object doctor = new Doctor();

            Doctor d1 = (Doctor)doctor;
            if (d1 != null)
            {
                d1.Name = "Coco";
            }

            ((Doctor)doctor).Name = "Coco";
            object obj = (object)d1;


            List<object> doctors = new List<object>();
            doctors.Add(obj);
            doctors.Add(d1);

            if (obj is Doctor)
            { 
            
            }

            int number = 10;
            int? number2 = 10;

            string name = "allo";
            string? name2 = "Bonjour!";

            if (name2 != null)
            { 

            }

            checkBoxTest.IsChecked = true;

            ComboBoxGroups.Items.Add(new Group("101", 10));
            ComboBoxGroups.Items.Add(new Group("102", 12));
            ComboBoxGroups.Items.Add(new Group("103", 15));
            ComboBoxGroups.SelectionChanged += ComboBoxGroups_SelectionChanged;
        }

        private void ComboBoxGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //object selectedItems = 
            throw new NotImplementedException();
        }

        private class Doctor
        {
            //public string? Name { get; set; }
            public string? Name { get; set; } = "";

            public int Time { get; set; }
            public override string ToString()
            {
                return $"{Name} - {Time}h";
            }
        }



        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            bool? isChecked = checkBox.IsChecked; // 0 1 null (0)

            if (isChecked == true) 
            {
            
            }
        }

        private void RadioBtnDrink_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioBtnCoke.IsChecked == true)
            { 
            
            }
            else if(RadioBtn7up.IsChecked == true)
            {

            }
            else 
            {
            
            }

        }
    }
}
