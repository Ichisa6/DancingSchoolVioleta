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
    /// Логика взаимодействия для DanceViewPage.xaml
    /// </summary>
    public partial class DanceViewPage : Page
    {
        public DanceViewPage()
        {
            InitializeComponent();
            LVDance.ItemsSource = App.db.Dance.ToList();
            PriceCB.SelectedIndex = 0;
            var prod = App.db.Dance.ToList();
            prod.Insert(0, new Dance
            {
                TypeDance = "Все"
            });
            TypeDanceCB.ItemsSource = prod;
            TypeDanceCB.SelectedIndex = 0;
        }
        
        public void Refresh()
        {
            IEnumerable<Dance> filterService = App.db.Dance.ToList();
            if (PriceCB.SelectedIndex == 1)
                filterService = filterService.OrderBy(x => x.Price);

            else if (PriceCB.SelectedIndex == 2)
                filterService = filterService.OrderByDescending(x => x.Price);

            var filterProduct = App.db.Dance.ToList();
            if (TypeDanceCB.SelectedIndex > 0)
            {
                var a = TypeDanceCB.SelectedIndex.ToString();
                filterProduct = filterProduct.Where(x => x.TypeDance.ToString().Contains(a.ToLower())).ToList();
            }

            LVDance.ItemsSource = filterService.ToList();

        }
        private void PriceCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void RedactBtn_Click(object sender, RoutedEventArgs e)
        {
            var selService = (sender as Button).DataContext as Dance;
            NavigationService.Navigate(new CreatePage(selService));
        }

        private void TypeDanceCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
