﻿using BudgetPlanner_UI.Interfaces;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetPlanner_UI.Views
{
    /// <summary>
    /// Interaction logic for DebtView.xaml
    /// </summary>
    public partial class DebtView : UserControl, IView
    {
        public DebtView( DebtViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            SetBindings();
        }

        public void SetBindings( )
        {
            var vm = DataContext as DebtViewModel;

            #region Button Events
            AddDebtButton.Click += vm.AddDebtEvent;
            DeleteDebtButton.Click += vm.DeleteDebtEvent;
            AddDebtItemButton.Click += vm.AddDebtItemEvent;
            DeleteDebtItemButton.Click += vm.DeleteDebtItemEvent;
            #endregion

            DebtTreeMain.SelectedItemChanged += vm.SelectedMainValueChangedEvent;
        }
    }
}
