using BudgetPlanner_UI.ViewModels;
using BudgetPlanner_UI.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetPlanner_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup( StartupEventArgs e )
        {
            FactoryTesting();
            base.OnStartup(e);
            var shellView = new ShellView(ShellViewModel.Instance);
            shellView.Show();
        }

        private void FactoryTesting(  )
        {
            UIFactory.BuildViewModel<BudgetViewModel>();
        }
    }
}
