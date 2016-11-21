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

namespace TestOperation1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Operation> currentList; 
      
        public MainWindow()
        {
            InitializeComponent();
            this.currentList = new List<Operation>();
            listViewOperations.ItemsSource = null;
       
        }

        private void buttonOp1_Click(object sender, RoutedEventArgs e)
        {
           
            currentList.Add(new Operation
            {
                Type = types.RGH,
                Index = DateTime.Now.ToString("hhmmss"),
                OperationType = operations.External_Turning,
                Parameters = "Z=150 XF=25.25 F125.25 Z2.5 S=12.5 Mx=12.45 TF=125.8"
            });
            
            this.listViewOperations.Items.Add(currentList);

        }

        private void buttonOp2_Click(object sender, RoutedEventArgs e)
        {
            currentList.Add(new Operation
            {
                Type = types.ZTH,
                Index = DateTime.Now.ToString("hhmmss"),
                OperationType = operations.Internal_Turning,
                Parameters = "Z=150 XF=25.25 F125.25 Z2.5 S=12.5 Mx=12.45 TF=125.8"
            });
            this.listViewOperations.Items.Add(currentList);
        }
    }
}
