   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Курсовая_ПродКурсовая_Прод  5   	   *    $Курсовая_Прод.NewStudent   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Курсовая_Прод     5   	     � 
ResizeMode$  NoResize=�5      ���#1D7074 � Title$ 
NewStudent��5
   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� ���#FF7600$��0��6%   $��0��62   $��Имя:��6B   $
��Bold"�6Q   $��20(�6c   �� 5   
   -   5         ��Name$ NameTextBox��5   /   $��0��6   $��1��6   6/   �� 5    
   ���#FF7600$��1��6&   $��0��63   $��Фамилия:��6C   $��20(�6V   $
��Bold"�6d   �� 5!   
   -   5        $ SurnameTextBox��5!   /   $��1��6   $��1��6   6/   �� 5"   
   ���#FF7600$��2��6%   $��0��62   $��Номер группы:��6B   $��20(�6Z   $
��Bold"�6h   �� 5#   
   -   5        $ GroupNumberTextBox��5#   /   $��2��6   $��1��6   6/   �� 5$   
   -   5        ���#FFB473$��3��5$   &   $��1��63   $��Добавить��6C   $��18(�6l   $
��Bold"�6z   �� 5%   
   ���#FF7600$��4��6%   $��0��62   $6��0Добавленные пользователи:��6B   $��15(�6f   $
��Bold"�6t   �� 5&   
   -   5        $ UsersTextBox��5&   /   $��4��6   $��1��6    �� 
IsReadOnly$
 True��6E   5'      5(      