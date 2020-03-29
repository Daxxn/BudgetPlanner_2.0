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
        public ShellViewModel Shell { get; set; }

        protected override void OnStartup( StartupEventArgs e )
        {
            base.OnStartup(e);
            Shell = UIFactory.BuildShellViewModel();
            var shellView = new ShellView(Shell);
            shellView.Show();
        }
    }
}
