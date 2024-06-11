using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(txtKey.Text, txtValue.Text);
            MessageBox.Show($"\"{txtKey.Text} : {txtValue.Text}\" has added.", "Message");
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            string key = txtKey.Text;
            string value = hashtable[txtKey.Text].ToString();
            hashtable.Remove(txtKey.Text);
            MessageBox.Show($"\"{key} : {value}\" has removed.", "Message");
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            //Show all
            string message = string.Empty;

            foreach (string key in hashtable.Keys)
            {
                message += $"{key} : {hashtable[key].ToString()}\n";
            }

            MessageBox.Show(message , "Message");
        }
    }
}
