   M S B A M L   `   `   `  ����F  BSmartDishes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SmartDishes.ViewsSmartDishes.Views  5   	   '    !SmartDishes.Views.AdminChangeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SmartDishes.Views     5   	     � Title$  AdminChangeView��5   	   $	��600��6!   $	��500��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $
��Id: ��6   $��45,29,114,29q�6   $��20(�65   �� 5   
   $��Login:��6   $��45,94,114,62q�6!   $��20(�67   $��2��6E   �� 5   
   $��	Password:��6   $��
45,73,0,87q�6$   $��20(�68   $
��Left=�6F   $	��106��6a   $��1��6m   $��2��6z   �� 5   
   $��Name:��6   $��51,65,98,78q�6    $��20(�65   $��2��6C   $��2��6P   �� 5   
   $��Email:��6   $��51,59,97,96q�6!   $��20(�66   $��3��6D   $��2��6Q   �� 5   
   -   5        $��Id��5      $��164,32,10,27q�6B    �� 
IsReadOnly . $��2��6j   ��6   �� *UserId+ �� Mode$ TwoWay=�6j   �� 5   
   -   5        $��Login��5      $��164,94,10,62q�6D   $��2��6Z   $��2��6n   ��6    �� *Login+$ TwoWay=�6n   �� 5   
   -   5        $��Password��5      $��164,73,10,87q�6I   $��35��6_   $��1��6k   $��2��6x   $��2��6�   ��6"   �� *
Password+$ TwoWay=�6�   �� 5   
   -   5        $
��Name��5      $��164,73,10,86q�6A   $��35��6W   $��2��6c   $��2��6p   $��2��6�   ��6   �� *Name+$ TwoWay=�6�   �� 5    
   -   5        $��Email��5       $��164,58,10,97q�6C   $��3��6Y   $��2��6f   $��2��6z   ��6   �� *Email+$ TwoWay=�6z   �� 5!   
   -   5        $��Ok��5!      $��35,58,97,57q�69   $��4��6N   $��2��6[   �� 5"   
   -   5        $��Cancel��5"      $��77,73,58,56q�6<   $��1��6Q   $��4��6a   $��2��6n   5$      5%      