   M S B A M L   `   `   `  ����N  JBronirovanie_Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Bronirovanie_DiplomBronirovanie_Diplom  5   	   $    Bronirovanie_Diplom.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Bronirovanie_Diplom     5   	     � Title$  FoodShef��5   	   $	��450��6   $	��800��6'    � WindowState$ 	Maximized=�63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      6!   .+�5   
   ]� $��0��6   ���#ebbe42.+�5      �� 
���   �$	��Top=�6,   $	��0,0q�6B   $��45��6O    �� Orientation$ 
Horizontal=�6[   .+�5      �� $��15,0,0,0q�6   $��40��6*   $��resources/images/logo.png��65   �� 5      $��20(�6   $��	15,10,0,9q�6*   
�������$��Center=�5      $��FoodShef��63   $
��Bold"�6C   $��95��6U   5      �� 5      $��Bottom=�6   $��60��61   $ 
Horizontal=�6=   ���#1c1a2f.+�5      �� $��7q�6   $��43��6$    �� CornerRadius$ 15��6/   ��5      �� 5       �� ImageSource$  resources/images/admin.png��6%   6P   5      �� 5      $��5,0,0,0q�6   $��95��6.   $ Vertical=�69   .+�5      �� $��Коровкина��6    $��12(�61   
�������$��	0,15,10,0q�6R   $
��Bold"�6e   5      �� 5      $��Любовь��6    
�������$��12(�6A   $��0,2,10,0q�6O   $
��Bold"�6a   6u   5      �� 5      -   5        $
��Exit��5      $��50��5    ,      buttonExitStyle#��[  67    J� RenderTransformOrigin$ 	0.2,0.517&�6`   5!      �� 5"        menuList#��[ 6   $��	0,20,0,20q�6l   $��0q�5#      
������ $	��Top=�6C   ��5"   E   �� *PageCollection+ �� SelectedItem 5$      �� *CurrentPage+��5%      �� 5&      .R�5'      �� 
���   �$
��Bold"�67   $��Center=�5(   $   $��Center=�6?   $��16(�6\   ��5)   $   �� *Title+6=   5*      5,      5-       � 5.   
     � NavigationUIVisibility$ Hidden=�6   $��1��6P   ��60   �� *CurrentPage+6b   50      51      