using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multi_Window_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person; // Creates a person object that will be used to hold the information of the person being displayed in the main window
        public MainWindow()
        {
            InitializeComponent();
            person = new Person(); // Just puts in some default values
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Age = 30;

            lblName.Content = person.FullName; // Displays the information of the person object in the main window
            lblAge.Content = person.Age.ToString();
            chkAdult.IsChecked = person.IsAdult;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            editWindow editWindow = new editWindow(person);
            editWindow.ShowDialog(); // Makes sure that the main window will actually uupdate

            lblName.Content = person.FullName;
            lblAge.Content = person.Age.ToString();
            chkAdult.IsChecked = person.IsAdult;
        }
    }

    
}