   M S B A M L   `   `   `  ����N  JBronirovanie_Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:Bronirovanie_Diplom.Pages.WindowBronirovanie,Bronirovanie_Diplom.Pages.WindowBronirovanie  5      C    =Bronirovanie_Diplom.Pages.WindowBronirovanie.PageBronirovanie   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:Bronirovanie_Diplom.Pages.WindowBronirovanie     5      -   5        $��window��5	        N� Title$  Бронирование��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.7* �6   �� 5      $
��0.3* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $	��Top=�6<   $��25(�6T   $��5q�6b   ��6m   ��  �� ElementName$ window�� �� Path$ Title�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ spisokBroni��5         AutoGenerateColumns .  $��1��5      $��0,50,0,0q�6#      CanUserAddRows .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      
   FontSize$
 15Q�6%   ,  &System.Windows.Controls.DataGridColumn   Header$) #Номер бронирования��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *
id_booking+6p     5      $
 15Q�6%   $' !Дата бронирования��63    6N   �� *Date+6i     5      $
 15Q�6%   $ 
Время��63    6B   �� *Time+6]     5      $
 15Q�6%   $ Номер столика��63    6J   �� *Table.id_table+6o     5      $
 15Q�6%   $ Имя гостя��63    6F   �� *Name+6a     5      $
 15Q�6%   $ Комментарий��63    6H   �� *Description+6j   5       �� 5!   
   $��0��6   .+�5"      �� -   5         ��Name$ AddBroni��5"      $)��#Забронировать стол��5#      $��5,50,5,5q�62   $��15(�5$   ,   $��30��6:   $��40��6F   6W   �� 5%      -   5        $ 
RedacBroni��5%      $ ��Редактировать��5&      $��5q�6-   $��40��5'      $��15(�6=   5)      �� 5*      -   5        $ 
DeletBroni��5*      $��Удалить��5,      $��5q�6'   $��15(�62   $��40��5-      5.      5/      �� 50   
   -   5         ��Name$ Searctextbox��50      $��1��6(   ���#10101A$��Center=�6N   $��15(�51      $��
10,10,10,0q�52      $	��Top=�6&   $��30��6>      SearchTextBoxStyle#��[  53      ��51   G   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=�53   @   &   System.Windows.Controls.Calendar  54   
   -   5          Name$ serachDatePicker��54      $��2��6-   $
��Left=�6=   $��15(�6X   $��10,50,10,225q�55   P      SelectedDate$ 
10.10.2013X�6f   �� 56   
    �� Orientation$ Vertical=�6   $��2��6,   .+�57      �� $��Текущая дата��6   $��
14,220,0,0q�6,   $��15(�6@   $
��Bold"�6N   �� 58      ���#10101A$
��Left=�6,   $��15(�6G   $��	14,5,10,5q�59      $	��176��6$   $��25��60   ��58   U   �� $ serachDatePicker��$ SelectedDate� �� StringFormat$ d��$ PropertyChanged=�59   0   5:      �� 5;   
   $ 
Horizontal=�6   $��2��6.   .+�5<      �� -   5        $��Button��5<      $
��Left=�6&   $	��Top=�5=      $��65��6)     buttonSbrosFilter#��[ 5>      $��	0,270,0,0q�6<   $��60��6d   �� 5?      $%��Сбросить фильтер��6   $��-16,300,0,0q�60   $��15(�6E   $
��Bold"�6S   5@      5A      5B      