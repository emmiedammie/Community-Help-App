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
    }
}
