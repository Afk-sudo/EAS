   M S B A M L   `   `   `  ����M  IEmployeeAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EmployeeAccounting.PagesEmployeeAccounting.Pages  5   	   1    +EmployeeAccounting.Pages.AdditionalEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:EmployeeAccounting.Pages     5   	     � Title$  Employee Addition��5   	   $	��600��6#   $	��500��60   $	��500��6?    � 
ResizeMode$ NoResize=�6K   ���#00c5fa���#100e14 � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� RelativeSource
 �� Path��%  '��       �� 5
   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 5      �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent��� 5       � ��
 �  ��63   5      5      5      .��5      � .+�5   
   �� $��20(�6   $��30��6"   $	��Top=�6.   $��10q�6F   Employee Addition6e   � 5   
   $
��Auto��6   $
��Auto��6   $��20, 50, 20, 20q�6*    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!       � ColumnDefinitions 5#      �� 5$      $
��Auto �6#   �� 5%      .+�5'      �� -   5         ��Name$ EmployeeName��5'      $��1��6,   $��30��6<   $��0 0 15 0q�6H   $��16(�6Z   ���#1c1c1c���#00c5fa��6h   �� *Name+ �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��6�   �� 5(      -   5        $ EmployeePhone��5(       �� 	MaxLength$ 11��6-   $��1��6<   $��1��6L   $��30��6Y   $��0 0 15 0q�6f   $��16(�6x   ���#1c1c1c���#00c5fa��6�   �� *Phone+$
 True��$
 True��6�   �� 5)      -   5        $ EmployeeCity��5)      $��1��6,   $��2��6<   $��30��6I   $��0 0 15 0q�6U   $��16(�6g   ���#1c1c1c���#00c5fa��6u   �� *EmployeeAdress.City+$
 True��$
 True��6�   �� 5*      -   5        $ EmployeeStreet��5*      $��1��6.   $��3��6>   $��30��6K   $��0 0 15 0q�6W   $��16(�6i   ���#1c1c1c���#00c5fa��6w   �� *EmployeeAdress.Street+$
 True��$
 True��6�   �� 5+      -   5        $ EmployeeHome��5+      $��1��6,   $��4��6<   $��30��6I   $��0 0 15 0q�6U   $��16(�6g   ���#1c1c1c���#00c5fa��6u   �� *EmployeeAdress.Home+$
 True��$
 True��6�   �� 5,      -   5        $ EmployeeApartmet��5,      $��1��60   $��5��6@   $��30��6M   $��0 0 15 0q�6Y   $��16(�6k   ���#1c1c1c���#00c5fa��6y   �� *EmployeeAdress.Apartment+$
 True��$
 True��6�   � 5-      $��1��6   $��6��6#    5.      �� 5/      �� 50      .+�52      �� -   5         ��Name$ 
MaleButton��52       d� 	IsChecked$
 TrueY�6/   $	��Man��6@   $��30��6N   $��16(�6Z   $��0��6h   $��Center=�6x   $��Bottom=�6�   ���#00c5fa6�   �� 53      -   5        $ FemaleButton��53      $ FalseY�61   $��Woman��6C   $��30��6S   $��16(�6_   $��1��6m   $��Center=�6}   $��Bottom=�6�   ���#00c5fa6�   54      �� 56      $��Name :��6   $��30��6%   $��16(�61   ���#00c5fa6?   �� 57      $��1��6   $��Phone :��6!   $��30��63   $��16(�6?   ���#00c5fa6M   �� 58      $��2��6   $��City :��6!   $��30��62   $��16(�6>   ���#00c5fa6L   �� 59      $��3��6   $��Street :��6!   $��30��64   $��16(�6@   ���#00c5fa6N   �� 5:      $��4��6   $��Home :��6!   $��30��62   $��16(�6>   ���#00c5fa6L   �� 5;      $��5��6   $��
Apartmet :��6!   $��30��66   $��16(�6B   ���#00c5fa6P   �� 5<      -	   5        $��6��5<      $��Gender :��6!   $��30��64   $��16(�6@   ���#00c5fa6d   �� 5=      -
   5        $��1��5=      $��7��6%   $��Добавить��62   $��16(�6E   ���#5eba7d$	��150��6h   $��35��6t   $��209,14,15,13q�6�   ���#FFFF6�   5?      5@      5A      