   M S B A M L   `   `   `  ����>  :Ded, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DedDed  5   	       Ded.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Ded     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   $	��380��5	   	   $	��460��6   $	��650��5
   	   $
��1000��6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��25 �6   .+�5   
   �� $��0,0,0,1q�6   ���#6995c26+   � 5   
   -   5         �Name$
 Head��5      $��0��6   .+�5      ]� $
��Left=�6   .+�5      �� $��logo.jpg��6   $��35��6*   $��5 0 10 0q�66    
  Shadow J� Effect# [  6H   �� 5      $��Center=�6   NBA Management System6N   5      �� 5      $��Center=�6   $��Center=�65   
Teams main6\   �� 5      $
��Back��6   $��Right=�6$   $��20��6@   $��10q�6L   $��50��6X   5      �� 5   
   $��1��6   $��10 30 10 20q�6"   
�������.@�5      �� $��Eastern��6   ���	#FFDEDEDE
�������.��5      �  � ColumnDefinitions 5      �� 5       $��1* �6+   �� 5!      -   5         ��Name$ Coll1��5!   +   $	��40* �6:   �� 5"      $��1* �6+   �� 5#      -   5        $ Coll2��5#   +   $	��40* �6:   �� 5$      $��1* �6+   �� 5%      -   5        $ Coll3��5%   +   $	��40* �6:   �� 5&      $��1* �6+   .+�5)      &   System.Windows.Controls.DataGrid     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6   
�������$��1��6B   $
��0 10q�6R   
�������   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Atlantic��61   5-        5.      $ * 6   
�������$��3��6B   $
��0 10q�6R   
������� 5/        50      $ Central��61   52      54        55      $ * 6   
�������$��5��6B   $
��0 10q�6R   
������� 56        57      $ 	Southeast��61   59      5:      5;      �� 5<      $��Western��6   ���	#FFDEDEDE
�������.��6Q   	Western6Z   5=      �� 5?   
   $��2��6   $U��OThe current season is 2016-2017, and the NBA already has a history of 71 years.��6   $��Center=�6w   ���#6995c2
�������6�   5@      5A      