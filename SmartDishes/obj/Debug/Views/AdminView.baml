   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SmartDishes.ViewsSmartDishes.Views  5   	   !    SmartDishes.Views.AdminView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SmartDishes.Views     5   	   -   5          � Title$  	AdminView��5   	   $	��760��5	      $
��1280��6    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 35��6   ��5   
   �� 5       �� 
StartPoint$	 1,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #180632��6    � Offset$ 0Q�6/   � 5      $ #5e09d5��6   $	 0.5Q�6/   � 5      $ #180632��6   $ 1Q�6/   5      ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $	��200 �6#   �� 5      
 � RowDefinitions
 5!      �� 5"      $��75 �6    �� 5#      .+�5(      �� $��Smart Dishes��6   $��Center=�5)      $��Center=�5*      
�������$��22(�5,      5.      �� 50      $��1��6   .+�52      	� -   5        $��Members��52      $��50��53      
�������$��14(�55         MenuButtonTheme#��[  56      
 � Tag$ Member��57      58      	� 5:      -   5        $��
Add a meal��5:      $��50��5;      
�������$��14(�5=      #��[  5>      $ AddMeal��5?      5@      5B      � 5D      -   5        $��MembersGrid��5D      $y�Hidden=�6'   $��1��6;   $��1��6H   .+�5E      &   System.Windows.Controls.DataGrid  -   5          Name$ MembersPersonDataGrid��5E      $��60,10,60,151q�6:   $	��960��6P   �� 5G      -   5        $��Add user��5G      $	��100��6,   $	��200��69   $��60,544,820,41q�6b   6{   �� 5H      -   5        $��
Properties��5H      $	��100��6.   $	��200��6;   $��362,544,518,41q�6k   6�   �� 5I      -   5        $��Delete��5I      $	��100��6*   $	��200��67   $��675,544,205,41q�6c   5J      � 5L      -	   5        $��AddMealGrid��5L      $y�Visible=�6'   $��1��6<   $��1��6I   .+�5M        -
   5        $ DishesDataGrid��5M      $��
0,0,10,177q�63   6I   �� 5O      -   5        $��Add dish��5O      $��35,551,877,40q�6,   6`   �� 5P      -   5        $��	Edit dish��5P      $��288,542,646,40q�6-   6i   �� 5Q      -   5        $��Delete dish��5Q      $��535,542,399,40q�6/   6g   5U      5V      5W      5X      