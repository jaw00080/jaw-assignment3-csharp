using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Multi_Window_WPF
{
    /// <summary>
    /// Interaction logic for editWindow.xaml
    /// </summary>
    public partial class editWindow : Window
    {
        private Person person; // Variable to hold the person object that is being edited
        public editWindow(Person person)
        {
            InitializeComponent();
            this.person = person; // Runs through and initializes the text boxes with the values of the person object that is being edited
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtAge.Text = person.Age.ToString();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close(); // just closes the window without saving any changes made to the person object
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text; // Updates the person object with the values from the text boxes when the OK button is clicked
            person.LastName = txtLastName.Text;
            person.Age = int.Parse(txtAge.Text);
            Close();
        }

    }
}