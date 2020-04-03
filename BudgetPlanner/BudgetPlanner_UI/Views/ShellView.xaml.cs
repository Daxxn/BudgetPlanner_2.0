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

namespace BudgetPlanner_UI.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window, IView
    {
        public ShellView( ShellViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            //BudgetTab_CC.Content = UIFactory.BuildBudgetView(ShellViewModel.Instance.BudgetVM);
            BudgetTab_CC.Content = UIFactory.BuildView<BudgetView, BudgetViewModel>(ShellViewModel.Instance.BudgetVM);
            PaystubTab_CC.Content = UIFactory.BuildView<PaystubView, PaystubViewModel>(ShellViewModel.Instance.PaystubVM);
            SetBindings();
            ShellViewModel.WindowWidth = ActualWidth;
        }

        public void SetBindings( )
        {
            var vm = DataContext as ShellViewModel;
            KeyUp += vm.KeyUpEvent;
        }
    }
}
