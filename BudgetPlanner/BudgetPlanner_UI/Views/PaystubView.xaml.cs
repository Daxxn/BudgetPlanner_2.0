using BudgetPlanner_UI.Interfaces;
using BudgetPlanner_UI.ViewModels;
using BudgetPlanner_UI.Views.DialogWindows;
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

namespace BudgetPlanner_UI.Views
{
    /// <summary>
    /// Interaction logic for PaystubView.xaml
    /// </summary>
    public partial class PaystubView : UserControl, IView
    {
        public PaystubView( PaystubViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            SetBindings();
        }

        public void SetBindings(  )
        {
            var vm = DataContext as PaystubViewModel;
            AddMany.Click += vm.AddManyEvent;
            AddMany.Click += AddManyClick;
            AddOne.Click += vm.AddOneEvent;
            DeleteOne.Click += vm.DeleteOne;
        }

        private void AddManyClick( object sender, RoutedEventArgs e )
        {
            var vm = DataContext as PaystubViewModel;
            var addManyWindow = new AddPaystubView(vm.AddPaystubVM);

            addManyWindow.Show();
        }
    }
}
