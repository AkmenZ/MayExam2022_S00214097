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

namespace MayExam2022_S00214097
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// link to git https://github.com/AkmenZ/MayExam2022_S00214097
    public partial class MainWindow : Window
    {
        List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RentalPropertyData db = new RentalPropertyData();
            var query = from rp in db.RentalProperties
                        orderby rp.Price
                        select rp;

            allProperties = query.ToList();

            lbxProperties.ItemsSource = allProperties;
        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty selected = lbxProperties.SelectedItem as RentalProperty;

            //check for null
            if (selected != null)
            {
                //update display
                tblkProperties.Text = selected.Description;
            }
        }

        //opens second window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            secondWindow addWindow = new secondWindow();
            addWindow.ShowDialog();
        }
    }
}
