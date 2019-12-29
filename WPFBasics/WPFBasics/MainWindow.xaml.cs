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
using WPFModel;

namespace WPFBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
           // txtBox.Text = p.Name;
            people.Add(new Person {FirstName = "Vikas", LastName = "Mishra"});
            people.Add(new Person { FirstName = "Vivek", LastName = "Jawali" });
            people.Add(new Person { FirstName = "Bhagirath", LastName = "Raghu" });
            people.Add(new Person { FirstName = "Ramesh", LastName = "B" });
            comboBoxPeople.ItemsSource = people;
        }

        private void BtnButton_OnClick(object sender, RoutedEventArgs e)
        {
            string content = ((ComboBoxItem)comboBoxPeople.SelectedItem).Content as string;
            MessageBox.Show(textBox.Text+ content);
        }
    }
}
