   M S B A M L   `   `   `  ����N  JBronirovanie_Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Bronirovanie_Diplom.Pages.WindowTable%Bronirovanie_Diplom.Pages.WindowTable  5      7    1Bronirovanie_Diplom.Pages.WindowTable.PageStolici   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Bronirovanie_Diplom.Pages.WindowTable     5      -   5        $��window��5	        N� Title$  Столики��5
      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��
10,100,0,0q�6,   $
��Left=�6@   .+�5      �� -   5         ��Name$ addTable��5      $	��150��6(   $��40��64   $��15(�6W   .��6f   Добавить6p   �� 5      -   5        $ redactorTable��5      $	��150��6H   $��40��6T   $
��5,10q�6`   $��15(�6n   .��6|   Редактировать6�   �� 5      -   5        $ deleteTable��5      $	��150��6*   $��40��66   $��15(�6\   .��6k   Удалить6t   5      �� 5   
   $
��Left=�6   $	��Top=�6/   $��Roboto)�6G   $��25(�6[   $��30q�6i   ��6u   ��  �� ElementName$ window�� �� Path$ Title�6�   �� 5   
   $��0q�6   $��220,100,35,35q�6)      tabItemStyle#��[  6@   .@�5      �� -   5         ��Name$	 _ti��5      ��5      �� 5      $��5q�6   $��20��6'   $��20��62   ��5      H� 5       H� Drawing 5   "   I� 5   &   .��5   *   �   vec1 � Geometry# [ 6m    � Brush 6:   �� $	 _ti��$ 
Foreground�6�   5   '   5      5       ��5"      �� 5#      -   5        	 ��Name$	 spisok1��5#      $��0q�6/   $��0q�6:   
������   PetsItemstyle#��[ 5$      $��Disabled=�6R   ��5#   g   �� *Table+��5%      �� 5&      .R�5'   "   � 6.   5(      ��5*      �� 5+      .R�5,   "   ]� $	��250��6,   $	��450��68   .+�5-   &   �� $��0,20,0,0q�6,   $	��Top=�6>   $	��150��6S   $	��250��6_   ��6l   �� *image+  	imageConv
 �� 	Converter#
 [ 6�   �� 5.   &   $	��Top=�60   $��20,0,0,0q�6E    �� TextAlignment$
 Left=�6X   $��16(�6m   $
��Wrap=�6{   Номер столика: �� 6�   �6�   �� *
id_table+6�   6�   5/   #   50      52      54      �� 55      -   5        $
 _ti2��55      ��56      �� 57      $��5q�6   $��20��6'   $��20��62   ��58      H� 59       5:   "   I� 5;   &   .��5<   *   �   vec2# [ 6n    6:   �� $
 _ti2��$ 
Foreground�6�   5=   '   5?      5A      ��5C      &   System.Windows.Controls.DataGrid  5D      -   5          Name$ spisok2��5D         SelectionMode$ Single=�60      GridLinesVisibility$ 
Horizontal=�6G      RowHeaderWidth$ 0Q�5E      
������    
IsReadOnly .    CanUserSortColumns .  $��0q�5F   L      AutoGenerateColumns .  ��5G      �� *Table+   Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер столика��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *
id_table+6g   4  .System.Windows.Controls.DataGridTemplateColumn  5J         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 65   $ Изображение��6A      CellTemplate 5K   "   �� 5L   &   .R�5M   *   �� $	��100��60   ��6=   �� *image+#
 [ 6~   5N   '   5P        5Q      $# Количество мест��61    6J   �� *Number_of_seats+6p     5R      $ Описание��61    6C   �� *Description+6e   5T      5V      5W      �� 5X   
   -	   5         ��Name$ 	SearchBox��5Y   B   ���#10101A$��Center=�5X   (   $��16(�5Y      $��220,30,30,0q�5Z      $	��Top=�6'   $��35��6?     SearchTextBoxStyle#��[ 5[      6@   5\      5]      