   M S B A M L   `   `   `  ����K  GBudgetPlanner_UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BudgetPlanner_UI.ViewsBudgetPlanner_UI.Views  5      %    BudgetPlanner_UI.Views.DebtView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:BudgetPlanner_UI.Views     5      
�������.��5	      �   � ColumnDefinitions  5
      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      �� $��0��6   ._�5      �   5      �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5      �� $��0��6   $��2��6   
Controls5      �� 5       $��1��6   $��2��6   ._�5!      �   5"      �� 5#   	   $��* �6   �� 5$   	   $��* �6    5&      �� 5'   	   $
��Auto �6   �� 5(   	   $
��Auto �6   .+�5+      �� -   5         ��Name$ AddDebtButton��5+      $��0��5,   	   $��0��6   .��6&   
Add Debt5.   	   �� 5/      -   5        $ DeleteDebtButton��5/      $��1��50   	   $��0��6   .��6&   Delete Debt52   	   �� 53      -   5        $ AddDebtItemButton��53      $��0��54   	   $��1��6   .��6&   Add Payment56   	   �� 57      -   5        $ DeleteDebtItemButton��57      $��1��58   	   $��1��6   .��6&   Delete Payment5:   	   5;      5<      5=      5>      �� 5@      $��1��6      BD_DE_Tree_Main#��[  6   ._�5�      R� -   5         R�Name$ DebtTreeMain��5�       � IsSharedSizeScope . ��5�      ��  �� Path$ DebtDataList� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� R� SelectedValuePath 5�      �� 	 �� Source$	 SelectedDebt����5�      �� 5�      .R�5�      Q� $
��Debt��6   .@�5�   	   �� #��[  6   ._�5�   
   �   5�      �� 5�      
 z� SharedSizeGroup$
 DebterTitle��6   �� 5�      $
 Debter��6   �� 5�      $
 AmountTitle��6   �� 5�      $
 Amount��6   �� 5�      $
 DueDateTitle��6   �� 5�      $
 DueDate��6    5�      �� 5�      $
��Auto �6   �� 5�      $
��Auto �6   .+�5�      �� $��0��6     TB_DB_Tree_Main#��[ 5�      Debter5�      �� 5�      $��1��6     TX_DB_Tree_Main#��[ 5�      ��5�      �� $ Debter��� 5�      $��2��6   #��[ 5�      Amount5�      �� 5�      $��3��6   $��0��6#   #��[ 5�      ��5�      �� $ 
AmountOwed��� 5�      $��4��6   #��[ 5�      
Due Date5�      (  "System.Windows.Controls.DatePicker  5�      $��5��6     DP_DE_Tree_Main#��[ 5�         SelectedDate 5�      �� $ DueDate�Q� 5�      $��0��6   $��1��6(   $��6��65   $��Payment History��5�      .@�5�      �� ��6   �� $ DebtHistory�$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5�      �� $ SelectedDebtHistory�$ PropertyChanged=���5�      �� 5�      .R�5�      ��   BD_DE_Tree_Item#��[ 6   ._�5�      �   5�      �� 5�      $
 PaymentTitle��6#   �� 5�      $
 Payment��6#   �� 5�      $
 PayDateTitle��6#   �� 5�      $
 PayDate��6#   .+�5�      �� $��0��6     TB_DB_Tree_Sub#��[ 5�      	Payment5�      �� 5�      $��1��6     TX_DB_Tree_Sub#��[ 5�      ��5�      �� $ AmountPayed��� 5�      $��2��6   #��[ 5�      
Date Payed5�        5�      $��3��6     DP_DE_Tree_Sub#��[ 5�       5�      �� $ 	DatePayed�5�      5�      5�      5�      5�      5�      5�   
   5�   	   5�      5�      5�      5�      5�      