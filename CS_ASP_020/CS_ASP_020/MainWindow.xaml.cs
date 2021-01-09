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

namespace CS_ASP_020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //print driver ticket
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tdriverLabel.Content = $"Driver - {driverTextBox}";

            // convert text into numbers
            double ss = double.Parse(socialTextBox.Text);
            //print numbers
            tSociallabel.Content = string.Format("SSN: {0:000-00-0000}", ss);

            double pn = double.Parse(phoneTextBox.Text);

            tPhoneLabel.Content = string.Format("Phone Numner {0:(000)000-0000}",pn);
        
            //Subtracts the miles
            int miles = Convert.ToInt32(endMilesTextBox.Text) - Convert.ToInt32(startMilesTextBox.Text);
            //print numbers
            tMilesLabel.Content = $"Total Miles: {miles}";
            //subtracts days to get days remaining 
            int days = Convert.ToInt32((calanderReturn.SelectedDate.Value - calendarLeft.SelectedDate.Value).Days);

            tDaysOutlebel.Content = $"Days Out:{days}";
            //tells if the load is refridgerated and needs more pay
            double pay = (fridgeCheck.IsChecked == true) ? miles * .37 : miles * .25;

            tPayDueLabel.Content = string.Format("Pay Due: {0:c}", pay);
            //get vacation
            int vac = days / 5;

            tVacationLabel.Content = $"Vacation Earned: {vac} Days";



        }
    }
}
