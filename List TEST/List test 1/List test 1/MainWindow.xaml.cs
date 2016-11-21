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

namespace List_test_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// https://www.youtube.com/watch?v=vWCB0gjSmPg
    /// Video de youtube donde realizan un ejemplo basico de listView
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Personas> lst = new List<Personas>();
            lst.Add(new Personas { Name = "Pepe", Edad = 25, Pais = Paises.Peru });
            lst.Add(new Personas { Name = "Carlos", Edad = 22, Pais = Paises.Ecuador });
            lst.Add(new Personas { Name = "Felipe", Edad = 28, Pais = Paises.Mexico });

            this.listView.ItemsSource = null;
            this.listView.ItemsSource = lst;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
