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

namespace WpfAppTest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonClickMe.Click += Button_Click;

            TextBlockJoeMama.Text = "It's too late";

            TextBlock newTextblock =  new TextBlock();
            newTextblock.Text = "YOU ARE ALL GONNA DIE";

            StackPanelMain.Children.Add(newTextblock);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Title = "Joe mama is watching you";
            List<Doctor> doctors =  App.Doctors;


            string name = TextBoxName.Text;

            MessageBox.Show($"Watch out {name}!", "30 seconds left", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            ButtonClickMe.Click -= Button_Click;
            ButtonClickMe.Click += Button_ClickSecondTime;

        }

        private void Button_ClickSecondTime(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Joe mama is watching you", " 30 seconds left", MessageBoxButton.OK, MessageBoxImage.Stop);

        }
    }
}
