   M S B A M L   `   `   `  ����S  OStripsClientWPFReeksView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StripsClientWPFReeksViewStripsClientWPFReeksView  5   	   )    #StripsClientWPFReeksView.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:StripsClientWPFReeksView     5   	     � Title$  Reeks��5   	   $	��250��6   $	��400��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Id��6-   �� 5   
   -   5        $��ReeksIdTextBox��5   /   $��0��6   $��1��6   $��5q�6E   �� 5   
   $��1��6   $��0��6   $
��Naam��6-   �� 5   
   -   5        $��NaamTextBox��5   /   $��1��6   $��1��6   $��5q�6B   $��3��6M   �� 5   
   $��2��6   $��0��6   $��Aantal��6-   �� 5   
   -   5        $��AantalTextBox��5   /   $��2��6   $��1��6   $��5q�6D   $��3��6O   �� 5   
   $��3��6   $��0��6   $��Strips��6-   &   System.Windows.Controls.DataGrid  5   
   -   5        $��StripsDataGrid��5      $��1��6)   $��4��69   $��3��6F   $��5q�6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nr��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Nr+  5       $ Titel��6%    64   �� *Titel+5"      �� 5#   
   -   5        $��GetStripButton��5#   .   $��2��6   $��0��6!   $��	Get Reeks��6D   $��5q�6u   $��2��6�   5$      5%      