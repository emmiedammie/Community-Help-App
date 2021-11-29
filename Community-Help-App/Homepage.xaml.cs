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

namespace Community_Help_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Order order001 = new Order()
            {
                GroceriesItems = "Continence pad, jam, toast and chicken",
                StoreName = "Tesco",
                MedicalList = "Asprin",
                DeliveryDate = "12/02/2021",
                TotalOrderAmount = "£200"



            };
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //Set tooltip visibility

            if(Toggle_btn.IsChecked == true)

            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contact.Visibility = Visibility.Collapsed;
                tt_message.Visibility = Visibility.Collapsed;
                tt_map.Visibility = Visibility.Collapsed;
                tt_setting.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;


            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contact.Visibility = Visibility.Visible;
                tt_message.Visibility = Visibility.Visible;
                tt_map.Visibility = Visibility.Visible;
                tt_setting.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void Toggle_tn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Toggle_button_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void bg_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Toggle_btn.IsChecked = false;
        }

       
    }
}
