   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SmartDishes.ViewsSmartDishes.Views  5   	   #    SmartDishes.Views.DishAddView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SmartDishes.Views     5   	     � Title$  DishAddView��5   	   $	��450��6   $	��500��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Dish Id:��6   $��50��6#   $��30��6.   $��47,22,403,35q�6:   �� 5   
   -   5        $��DishIdTextBox��5      $��30��6M   $��146,22,32,35q�6Y   ��6(   �� *DishId+ �� Mode$ TwoWay=�6Y   �� 5   
   $��
Dish name:��6   $��30��6%   $��1��62   $��48,0,382,57q�6?   �� 5   
   -   5        $��DishNameTextBox��5      $��30��6Q   $��1��6]   $��146,0,31,57q�6j   ��6*   �� *
DishName+$ TwoWay=�6j   �� 5   
   $��Category Name:��6   $��48,48,350,3q�6)   $��1��6>   �� 5   
   -   5        $��DishCategoryNameTextBox��5      $��150,48,27,12q�6a   $��1��6w   ��62   �� *DishCategoryName+$ TwoWay=�6w   �� 5   
   $��Dish Price:��6   $��48,8,388,49q�6&   $��2��6;   �� 5   
   -   5        $��DishPriceTextBox��5      $��150,9,27,50q�6S   $��2��6h   ��6+   �� *	DishPrice+$ TwoWay=�6h   �� 5   
   $��Dish Amount:��6   $��48,52,366,6q�6'   $��2��6<   �� 5   
   -   5        $��DishAmountTextBox��5      $��150,46,27,6q�6U   $��2��6j   ��6,   �� *
DishAmount+$ TwoWay=�6j   �� 5   
   $��Dish Image:��6   $��48,15,372,43q�6&   $��3��6<   �� 5   
   -   5        $��	DishImage��5      $��151,1,224,0q�6!   $��3��66   �� 5   
   -   5        $��UploadImage��5      $��44,44,368,9q�6>   $��Upload Photo��6S   $��3��6j   �� 5   
   -   5        $��72,9,299,11q�5      $	��Add��6&   $��4��6K   �� 5    
   -	   5        $��Cancel��5       $��380,10,31,11q�6<   $��4��6R   5"      5#      