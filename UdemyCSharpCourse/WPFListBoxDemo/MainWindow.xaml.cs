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
using WPFListBoxDemo.Data;

namespace WPFListBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>()
        {
            new Person{Name = "Stuart", Age = 41},
            new Person{Name = "Gru", Age = 34},
            new Person{Name = "Lucy", Age = 26},
            new Person{Name = "Bob", Age = 42},
            new Person{Name = "Kevin", Age = 39}
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}
