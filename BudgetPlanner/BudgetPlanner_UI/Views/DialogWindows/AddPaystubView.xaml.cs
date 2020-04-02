using BudgetPlanner_UI.Interfaces;
using BudgetPlanner_UI.ViewModels;
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
using System.Windows.Shapes;

namespace BudgetPlanner_UI.Views.DialogWindows
{
    /// <summary>
    /// Interaction logic for AddPaystubView.xaml
    /// </summary>
    public partial class AddPaystubView : Window, IView
    {
        public AddPaystubView( AddPaystubViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            SetBindings();
        }

        public void SetBindings( )
        {
            var vm = DataContext as AddPaystubViewModel;
        }
    }
}
