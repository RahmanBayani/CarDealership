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
using carDealServiceManagement.Pages;
using carDealServiceManagement.Classes;

namespace carDealServiceManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainWindow()
        {
            //using (AutoRepairContext ctx = new AutoRepairContext())
            //{
            //    LoginClass loginadmin = new LoginClass { UserName = "user2", UserPassword = "admin2" };
            //    ctx.logins.Add(loginadmin);
            //    ctx.SaveChanges();
            //}

            InitializeComponent();
            btnMechanic.IsEnabled = false;
            btnVehicle.IsEnabled = false;
            btnCustomer.IsEnabled = false;
            btnService.IsEnabled = false;
            btnPayment.IsEnabled = false;
            btnSearch.IsEnabled = false;
            //btnexit.IsEnabled = false;
        }

        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        public void Button_exitClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to Exit?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login loginPage = new Login();
            Main.Content = loginPage;

        }
                            
        private void btnVehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            Main.Content = vehicle;

        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            Main.Content = customer;
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service();
            Main.Content = service;
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            Main.Content = payment;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Search search= new Search();
            Main.Content = search;
        }

        private void btnMechanic_Click(object sender, RoutedEventArgs e)
        {
            Mechanic mechanic = new Mechanic();
            Main.Content = mechanic;

        }
    }
}
