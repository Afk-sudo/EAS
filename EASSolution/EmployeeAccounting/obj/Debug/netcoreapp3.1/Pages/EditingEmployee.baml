   M S B A M L   `   `   `  ����M  IEmployeeAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EmployeeAccounting.PagesEmployeeAccounting.Pages  5   	   .    (EmployeeAccounting.Pages.EditingEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:EmployeeAccounting.Pages     5   	   -   5          � Title$  Editing Employee��5   	   $	��600��6"   $	��500��6/   $	��500��6>    � 
ResizeMode$ NoResize=�6J   ���#100e14���#00c5fa � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� RelativeSource
 �� Path��%  '��       �� 5
   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 5      �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent��� 5       � ��
 �  ��63   5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ EditedEmployeeName��5   R   $��20(�6   $��30��6"   $	��Top=�6.   $��10q�6F   Edited employee:6�   � 5   
   $
��Auto��6   $
��Auto��6   $��20, 50, 20, 20q�6*    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5        � ColumnDefinitions 5"      �� 5#      $	��100��6#   �� 5$      $��* �6#   .+�5&      �� -   5         ��Name$ EmployeeName��5&      $��30��6-   $	��300��6:   $��0 0 15 0q�6G   $��16(�6Y   $��0��6g   $��1��6t   $��Right=�6�   ���#1c1c1c���#00c5fa��6�   �� *Name+ �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True�� �� ValidatesOnExceptions$
 True��6!  �� 5'      -   5        $ EmployeePhone��5'      $��30��6.   $	��300��6:   $��0 0 15 0q�6F   $��16(�6X   $��1��6g   $��1��6t   $��Right=�6�    �� 	MaxLength$ 11��6�   ���#1c1c1c���#00c5fa��6�   �� *Phone+$
 True��$
 True��$
 True��60  �� 5(      -   5        $ EmployeeCity��5(      $��1��6,   $��2��6<   $��30��6I   $	��300��6U   $��0 0 15 0q�6b   $��Right=�6t   $��16(�6�   ���#1c1c1c���#00c5fa��6�   �� *EmployeeAdress.City+$
 True��$
 True��$
 True��60  �� 5)      -   5        $ EmployeeStreet��5)      $��1��6.   $��3��6>   $��30��6K   $	��300��6X   $��0 0 15 0q�6f   $��Right=�6x   $��16(�6�   ���#1c1c1c���#00c5fa��6�   �� *EmployeeAdress.Street+$
 True��$
 True��$
 True��64  �� 5*      -   5        $ EmployeeHome��5*      $��1��6,   $��4��6<   $��30��6I   $	��300��6U   $��0 0 15 0q�6b   $��Right=�6t   $��16(�6�   ���#1c1c1c���#00c5fa��6�   �� *EmployeeAdress.Home+$
 True��$
 True��$
 True��6.  �� 5+      -   5        $ EmployeeApartmet��5+      $��1��60   $��5��6@   $��30��6M   $	��300��6Y   $��0 0 15 0q�6f   $��Right=�6x   $��16(�6�   ���#1c1c1c���#00c5fa��6�   �� *EmployeeAdress.Apartment+$
 True��$
 True��$
 True��67  � 5,      $��1��6   $��6��6#    5-      �� 5.      �� 5/      .+�51      �� -	   5         ��Name$ 
MaleButton��51       d� 	IsChecked$ FalseY�6/   $	��Man��6A   $��30��6O   $��16(�6[   $��0��6i   $��Center=�6y   $��Bottom=�6�   ���#00c5fa6�   �� 52      -
   5        $ FemaleButton��52      $ FalseY�61   $��Woman��6C   $��30��6S   $��16(�6_   $��1��6m   $��Center=�6}   $��Bottom=�6�   ���#00c5fa6�   54      �� 56      $��Name :��6   $��30��6%   $	��16 (�61   ���#00c5fa6@   �� 57      $��1��6   $��Phone :��6!   $��30��63   $��16(�6?   ���#00c5fa6M   �� 58      $��2��6   $��City :��6!   $��30��62   $��16(�6>   ���#00c5fa6L   �� 59      $��3��6   $��Street :��6!   $��30��64   $��16(�6@   ���#00c5fa6N   �� 5:      $��4��6   $��Home :��6!   $��30��62   $��16(�6>   ���#00c5fa6L   �� 5;      $��5��6   $��
Apartmet :��6!   $��30��66   $��16(�6B   ���#00c5fa6P   �� 5<      $��6��6   $��Gender :��6!   $��30��64   $��16(�6@   ���#00c5fa6N   �� 5=      -   5         ��Name$ ConfirmEditing��5=   �   $��1��6   $��7��6%   $��Изменить��62   $��16(�6E   ���#5eba7d���#FFFFFF$	��150��6}   $��35��6�   $��209,14,15,13q�6�   6�   �� 5>      -   5        $ CancleEditing��5>   �   $��1��6   $��7��6%   $��Отмена��62   $��16(�6C   ���#f7630c���#FFFFFF$	��150��6{   $��35��6�   $��-150,14,15,13q�6�   6�   5@      5A      5B      