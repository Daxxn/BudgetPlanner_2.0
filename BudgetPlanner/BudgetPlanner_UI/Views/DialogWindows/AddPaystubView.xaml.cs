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
            AddNewPaystubButton.Click += vm.AddNetPaystubEvent;
            FinishCloseButton.Click += vm.FinishCloseEvent;
            FinishCloseButton.Click += FinishCloseEvent;
        }

        private void NewBox_GotKeyboardFocus( object sender, KeyboardFocusChangedEventArgs e )
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Name.StartsWith("NewBox"))
                {
                    textBox.SelectAll();
                }
            }
        }

        private void NewBox_KeyUp( object sender, KeyEventArgs e )
        {
            if (e.Key == Key.Enter)
            {
                if (NewBoxGross.Text.Length > 0 || NewBoxNet.Text.Length > 0 || NewBoxTax.Text.Length > 0)
                {
                    var vm = DataContext as AddPaystubViewModel;
                    vm.AddNetPaystubEvent(this, null);
                    NewBoxGross.Focus();
                }
            }
        }

        private void FinishCloseEvent( object sender, RoutedEventArgs e )
        {
            Close();
        }
    }
}
