   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SmartDishes.ViewsSmartDishes.Views  5   	   &     SmartDishes.Views.DishChangeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SmartDishes.Views     5   	   $	��600��5   	   $	��500��6   .��5
      �   � RowDefinitions  5      �� 5   
   �� 5   
   �� 5   
   �� 5   
   �� 5   
   �� 5   
    � ColumnDefinitions 5      �� 5   
   �� 5   
   .+�5   
   �� $��DishId: ��6   $��45,29,114,29q�6#   $��20(�69   �� 5   
   $��	DishName:��6   $��45,94,114,62q�6$   $��20(�6:   $��2��6H   �� 5   
   $��DishCategoryName:��6   $��
45,73,0,87q�6,   $��20(�6@   $
��Left=�6N   $	��106��6i   $��1��6u   $��2��6�   �� 5   
   $��
DishPrice:��6   $��51,65,98,78q�6%   $��20(�6:   $��2��6H   $��2��6U   �� 5   
   $��DishAmount:��6   $��51,59,97,96q�6&   $��20(�6;   $��3��6I   $��2��6V   �� 5   
   -   5        $��DishId��5      $��164,32,10,27q�6F    �� 
IsReadOnly . $��2��6n   ��6!   �� *DishId+ �� Mode$ TwoWay=�6n   �� 5   
   -   5        $��DishName��5      $��164,94,10,62q�6J   $��2��6`   $��2��6t   ��6#   �� *
DishName+$ TwoWay=�6t   �� 5   
   -   5        $��DishCategoryName��5      $��164,73,10,87q�6Y   $��35��6o   $��1��6{   $��2��6�   $��2��6�   ��6*   �� *DishCategoryName+$ TwoWay=�6�   �� 5    
   -   5        $��	DishPrice��5       $��164,73,10,86q�6K   $��35��6a   $��2��6m   $��2��6z   $��2��6�   ��6#   �� *	DishPrice+$ TwoWay=�6�   �� 5!   
   -   5        $��
DishAmount��5!      $��164,58,10,97q�6M   $��3��6c   $��2��6p   $��2��6�   ��6$   �� *
DishAmount+$ TwoWay=�6�   �� 5"      -   5        $��Ok��5"      $��35,58,97,57q�65   $��4��6J   $��2��6W   �� 5#      -   5        $��Cancel��5#      $��77,73,58,56q�68   $��1��6M   $��4��6]   $��2��6j   5%      5&      