   M S B A M L   `   `   `  ����K  GBudgetPlanner_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:BudgetPlanner_UI.Views.DialogWindows$BudgetPlanner_UI.Views.DialogWindows  5   	   9    3BudgetPlanner_UI.Views.DialogWindows.AddPaystubView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:BudgetPlanner_UI.Views.DialogWindows     5   	     � Title$  Add Paystubs��5   	   $	��650��6   $	��800��6+    � 
ResizeMode$ NoResize=�5	       � Left$	 800��5
      .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      �� $��0��6   ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5      �� $��0��6   
Controls5      �� 5!      $��1��6   ._�5"      �  5#   	   �� 5$   
   $
��Auto �6   �� 5%   
   $��* �6    5'   	   �� 5(   
   $
��Auto �6   �� 5)   
   $
��Auto �6   �� 5*   
   $
��Auto �6   �� 5+   
   $
��Auto �6   .+�5.   	   �� $��1��6   ��.   d� 	IsChecked 5/   
   ��  �� Path$ ReplaceOldPaystubs�.��50      Replace Old52   
   �� 54   	   $��2��6   ��.   55   
   �� $ SetDatesToNow�.��56      Set Date to Now58   
   59   	   5:      �� 5<      -   5         ��Name$ FinishCloseButton��5=      $��3��5<      ��.  .��5>      Finish5@      5A      5B      �� 5D      $��1��6   $��8��5E      $��Stretch=�5F      $��Center=�5G      ��.  5H      �� 5J      $��2��6   ._�5K      � -   5         5L      �� 5M      $
��Auto �6   �� 5N      $
��Auto �6   �� 5O      $
��Auto �6   �� 5P      $
��Auto �6   .+�5S      �� $��0��6   New Paystub5U      �� 5W      $��1��6   ._�5X      �  5Y      �� 5Z   	   $
��Auto �6   �� 5[   	   $��* �6    5]      �� 5^   	   $
��Auto �6   �� 5_   	   $
��Auto �6   �� 5`   	   $
��Auto �6   �� 5a   	   $
��Auto �6   .+�5d      �� $��1��6   $��0��6   Gross5f   	   �� 5g      -   5         ��Name$ NewBoxGross��5h   	   $��1��5g      $��1��6   $��1��5k   	   ��5j   	   �� $ NewPaystub.GrossPay�	 �� UpdateSourceTrigger$	 PropertyChanged=�5k   	   �� 5m      $��2��6   $��0��6   Net5o   	   �� 5p      -   5        $ 	NewBoxNet��5q   	   $��2��5p      $��1��6   $��2��5t   	   ��5s   	   �� $ NewPaystub.NetPay�$	 PropertyChanged=�5t   	   �� 5v      $��3��6   $��0��6   Tax5x   	   �� 5y      -   5        $ 	NewBoxTax��5z   	   $��3��5y      $��1��6   $��3��5}   	   ��5|   	   �� $ NewPaystub.TaxDeductions�$	 PropertyChanged=�5}   	   5      5�      �� 5�      $��2��6   ._�5�      �  5�      �� 5�   	   $
��Auto �6   �� 5�   	   $��* �6    5�      �� 5�   	   $
��Auto �6   �� 5�   	   $
��Auto �6   .+�5�      �� $��0��6   $��0��6   Hours5�   	   �� 5�      -   5        $ NewBoxHours��5�   	   $��0��5�      $��1��6   $��4��5�   	   ��5�   	   �� $ NewPaystub.Hours�$	 PropertyChanged=�5�   	   5�      5�      �� 5�      -   5        $ AddNewPaystubButton��5�      $��6��5�      $��2��6   ��.  .��5�      Add5�      5�      5�      �� 5�      $��3��6   $��8��5�      $��Stretch=�5�      $��Center=�5�      ��.  5�      &   System.Windows.Controls.DataGrid  5�      $��4��6   
   AutoGenerateColumns
 .     CanUserAddRows .    CanUserDeleteRows . ��.  ��5�      �� $ NewPaystubs� �� Mode$ TwoWay=�$	 PropertyChanged=� �� SelectedItem 5�      �� $ SelectedPaystub�$ TwoWay=�$	 PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Gross��6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6(   �� $ GrossPay�$	 PropertyChanged=�  5�      $	 Net��6    6&   �� $ NetPay�$	 PropertyChanged=�  5�      $	 Tax��6    6&   �� $ TaxDeductions�$	 PropertyChanged=�  5�      $ Tax %��6    6(   �� $ TaxPercentage�$	 PropertyChanged=�  5�      $ Hours��6    6(   �� $ Hours�$ TwoWay=�$	 PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 
Start Test��6      CellTemplate 5�      �� 5�      .R�5�   	   (  "System.Windows.Controls.DatePicker     SelectedDateFormat$ Short=�5�   
      DisplayDate$ 1/1/2020��5�   
      SelectedDate 5�      �� $ Period.Start�$ TwoWay=�$	 PropertyChanged=�5�   
   5�   	   5�        5�      $ End Date��6    5�      �� 5�      .R�5�   	     $ Short=�5�   
   $ 1/1/2020��5�   
    5�      �� $ 
Period.End�$ TwoWay=�$	 PropertyChanged=�5�   
   5�   	   5�        5�      $ Pay Date��6    5�      �� 5�      .R�5�   	     $ Short=�5�   
   $ 1/1/2020��5�   
    5�      �� $ Period.PayDate�$ TwoWay=�$	 PropertyChanged=�5�   
   5�   	   5�      5�      5�      5�      