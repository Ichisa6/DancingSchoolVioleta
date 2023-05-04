using DancingSchoolVioleta.Components;
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

namespace DancingSchoolVioleta.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Page
    {
        Dance dance;
        public CreatePage(Dance dance)
        {
            InitializeComponent();
            this.dance = dance;
            this.DataContext = dance;
        }

        private void TypeDanceTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PriceTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dance.ID == 0)
            {
                App.db.Dance.Add(dance);
            }
            App.db.SaveChanges();
            MessageBox.Show("Успешно");
            NavigationService.Navigate(new DanceViewPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
       
}
