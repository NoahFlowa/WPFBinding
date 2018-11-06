using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WPF_Binding
{
    /// <summary>
    /// Interaction logic for Collection.xaml
    /// </summary>
    public partial class Collection : Window
    {
        private ObservableCollection<Person2> _peopleList = new ObservableCollection<Person2>();

        public Collection()
        {
            InitializeComponent();
            _peopleList = new ObservableCollection<Person2>
            {
                new Person2 { Name = "Noah", Age = 19},
                new Person2 { Name = "Keegan", Age = 19},
                new Person2 { Name = "Richie", Age = 19},
                new Person2 { Name = "Eric", Age = 18}
            };
            _list.ItemsSource = _peopleList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnAdd_Click(object sender, RoutedEventArgs e)
        {
            _peopleList.Add(new Person2 { Name="Wyatt", Age = 19});
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
