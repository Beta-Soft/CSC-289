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

namespace PLANS_Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EventsQnA.Text = "Hello Word!";



            //if (DateSelect == DateTime.Now)
            //{
            //    EventsQnA.Text = "Test";
            //}


        }






        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //shows popup window of selected date
            var date = Plans1.SelectedDate.Value.Date.ToShortDateString();


            DateTime date1 = new DateTime(2021, 8, 1, 0, 0, 0);
            DateTime date2 = new DateTime(2009, 8, 1, 12, 0, 0);
            int result = DateTime.Compare(date1, date2);
            string relationship;

            if (result < 0)
            {
                relationship = " is earlier than ";
            }
            else if (result == 0)
            {
                relationship = " is the same time as ";
            }                
            else
            {
                relationship = " is later than ";
            }
                

            string nii = "There are no plans for: ";

            MessageBox.Show(date1.ToShortDateString() + relationship + date2.ToShortDateString());






            ////if no date seleted shows pop up window warning
            //if( date == null)
            //{
            //    MessageBox.Show("No Date Selected.");
            //}
        }



        //private void AddSelectedDates()
        //{
        //    Plans1.SelectedDates.Add(newDateTime(2022, 3, 5));
        //}

        //get { return selectedDate; }
        //set {
        //if (selectedDate != value) { /* SelectedDate has changed */ }
        //    selectedDate = value;
        //       NotifyPropertyChanged("SelectedDate");
    }
}
