using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppTest2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // object initialazer sur des listes
        public List<int> ints = new List<int>()
        {
            1,
            2,
            3
        };
        
        public static List<Doctor> Doctors = new List<Doctor>()
        { 
            new Doctor() { Id = "456" },
            new Doctor(),
            new Doctor()
        };

        //object initialazer
        public Doctor doc123 = new Doctor() { Id = "123", Name = "Yeehaw" };
    }

    public class Doctor
    {
        // private string _id; --> inutile
        // set = init, peut juste être defini dans le constructeur ou dans le object initialazer
        public string Id { get; init; }
        public string Name { get; set; }
    }
}
